using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using YueMES.Base.Dal;
using YueMES.Data.Business;
using YueMES.Data.Query;

namespace WebMES.Utils.Cache
{
    public class AppCache
    {
        private static ConcurrentDictionary<object, CacheObject> dicCache = new ConcurrentDictionary<object, CacheObject>();
        private static object _lock = new object();
        private static bool isExpireMonIni = false;
        static System.Timers.Timer timer = null;
        public static bool ContainsKey(object key)
        {
            var nkey = key.Equals(Thread.CurrentThread.ManagedThreadId) ? key : $"{key}_{DAO.DBNo}";
            if (dicCache.ContainsKey(nkey))
            {
                CacheObject cobj;
                if (dicCache.TryGetValue(nkey, out cobj))
                {
                    if ((DateTime.Now - cobj.CacheStartTime).TotalMinutes > cobj.ExpireTime)
                    {
                        AppCache.Remove(nkey);
                        return false;
                    }
                }
            }
            return dicCache.ContainsKey(nkey);
        }


        public static T GetCache<T>(object key)
        {
            var nkey = key.Equals(Thread.CurrentThread.ManagedThreadId) ? key : $"{key}_{DAO.DBNo}";
            dicCache.TryGetValue(nkey, out CacheObject obj);
            if (obj == null) return default(T);
            if ((DateTime.Now - obj.CacheStartTime).TotalMinutes > obj.ExpireTime)
            {
                AppCache.Remove(nkey);
                return default(T);
            }
            return (T)obj.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key">关键字</param>
        /// <param name="value">缓存值</param>
        /// <param name="_ExpireTime">过期时间，单位分钟</param>
        public static void Add(object key, object value, int _ExpireTime = -1)
        {
            try
            {
                var nkey =key.Equals(Thread.CurrentThread.ManagedThreadId) ?key: $"{key}_{DAO.DBNo}";
                if (nkey.ToString().StartsWith("GetQueryDataByPageCustFilter_"))
                {
                    //排除的查询号不能缓存
                    string[] sps = new string[] { "_|_" };
                    string queryNo = nkey.ToString().Split(sps, StringSplitOptions.None)[1];
                    List<ExpireConfig> expConfig = ExpireTimeConfigClass.Instance.GetExpConfigQueryNos;
                    var v = expConfig.FirstOrDefault(f => f.ConName == queryNo);

                    if (v != null)
                    {
                        if (v.ExpireTime <= 0)
                            return;
                        else
                            _ExpireTime = v.ExpireTime;
                    }
                }
                CacheObject cobj = new CacheObject(_ExpireTime > 0 ? _ExpireTime : 10) { Key = nkey, Value = value, CacheStartTime = DateTime.Now };
                dicCache[nkey] = cobj;
                if (!isExpireMonIni)
                {
                    lock (_lock)
                    {
                        if (isExpireMonIni) return;
                        isExpireMonIni = true;
                        timer = new System.Timers.Timer();
                        timer.Elapsed += timer_Elapsed;
                        timer.Interval = 1000 * 60;
                        timer.Enabled = true;
                        timer.Start();
                    }
                }
            }
            catch(Exception ex)
            {
                LogHelper.Error(ex);
            }
        }


        public static void Remove(object key)
        {
            if (dicCache.TryRemove(key, out _)) return;
            var nkey = key.Equals(Thread.CurrentThread.ManagedThreadId) ? key : $"{key}_{DAO.DBNo}";
            dicCache.TryRemove(nkey, out _);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        public static async Task<T> GetOrWaitCache<T>(object key, int waitTime = 30)
        {
           
            if (AppCache.ContainsKey(key))
            {
                object objCache = AppCache.GetCache<T>(key);
                if (objCache != null)
                {
                    return (T)objCache;
                }
                else
                {
                    DateTime dtNow = DateTime.Now;
                    while ((DateTime.Now - dtNow).TotalSeconds < waitTime)
                    {
                        await Task.Delay(50);
                        objCache = AppCache.GetCache<T>(key);
                        if (objCache != null)
                        {
                            return (T)objCache;
                        }
                    }
                    return default(T);
                }
            }
            else
            {
                AppCache.Add(key, null);
                return default(T);
            }
        }


        public static void ClearQueryCache(string busiNo)
        {
            try
            {
                string queryNo = null;
                string[] sps = new string[] { "_|_" };
                foreach (var key in dicCache.Keys)
                {
                    if (!key.ToString().StartsWith("GetQueryDataByPageCustFilter_")) continue;
                    queryNo = key.ToString().Split(sps, StringSplitOptions.None)[1];
                    bf_Query query = bf_Querys.GetItem(queryNo);
                    if (query == null) continue;
                    bf_Busi busi = bf_Busis.GetItem(busiNo);
                    var flg = false;
                    foreach (bf_Query_Item qi in query.Items)
                    {
                        if (qi.Business.TableNameDB == busi.TableNameDB)
                        {
                            flg = true;
                            break;
                        }
                    }
                    if (flg) break;
                    queryNo = null;
                }
                if (string.IsNullOrEmpty(queryNo)) return;
                List<object> lstKey = new List<object>();

                foreach (var key in dicCache.Keys)
                {
                    if (!key.ToString().StartsWith("GetQueryDataByPageCustFilter_")) continue;
                    if (key.ToString().Split(sps, StringSplitOptions.None)[1] == queryNo)
                    {
                        lstKey.Add(key);
                    }
                }
                foreach (var k in lstKey)
                {
                    Remove(k);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("ClearQueryCache", ex);
            }
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CacheExpireMoni();
        }
        private static void CacheExpireMoni()
        {
            try
            {
                var v = dicCache.Values.OrderBy((itm) => { return itm.ExpireTime; }).Take(20);
                DateTime dtNow = DateTime.Now;
                foreach (var c in v)
                {
                    if ((dtNow - c.CacheStartTime).TotalMinutes > c.ExpireTime)
                    {
                        AppCache.Remove(c.Key);
                    }

                }
            }
            catch { }
        }
    }

    public class CacheObject
    {
        public object Key { get; set; }
        public object Value { get; set; }
        public DateTime CacheStartTime { get; set; }

        /// <summary>
        /// 过期时间，单位分
        /// </summary>
        public int ExpireTime { get; private set; }

        public CacheObject(int _ExpireTime)
        {
            ExpireTime = _ExpireTime;
        }
    }

    public class ExpireConfig
    {
        public string ConName { get; set; }

        public int ExpireTime { get; set; }
    }
}