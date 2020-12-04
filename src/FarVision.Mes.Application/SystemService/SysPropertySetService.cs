using Abp.Runtime.Caching;
using Abp.Runtime.Caching.Memory;
using Farvison.Mes.Application.Interface.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace FarVision.Mes.SystemService
{
    public class SysPropertySetService:ISysPropertySetService 
    {
        private  IRepository<SysPropertySet> _repository;
        private  ICacheManager _cacheManagger;
        public SysPropertySetService(IRepository<SysPropertySet> sysProperties,ICacheManager cacheManager)
        {
            _repository = sysProperties;
            _cacheManagger = cacheManager;
        }
        public List<SysPropertySet> DefaultSysPropertySets
        {
            get
            {
                var key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
                object obj = null;
                if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
                    return obj as List<SysPropertySet>;
                var value = _repository.GetListAsync().Result;
                _cacheManagger.GetCache(BusiNo).Set(key, value);
                return value;
            }
        }
        public  string BusiNo
        {
            get { return "Sys_Property_Set"; }
        }
        public void Add(List<int> InsList, string dbNo, string key = null)
        {
            if (InsList == null || InsList.Count == 0) return;
            StringBuilder sbd = new StringBuilder();
            foreach (var id in InsList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }
            var data = _repository.Where(o => sbd.ToString().Contains(o.Id.ToString()));
            if (data == null) return;
            if (key == null)
            {
                key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
            }
            if (DefaultSysPropertySets == null)
            {
                _cacheManagger.GetCache(BusiNo).Set(key, data);
                return;
            }
            foreach (var o in data)
            {
                if (!DefaultSysPropertySets.Contains(o))
                {
                    DefaultSysPropertySets.Add(o);
                }
            }
            _cacheManagger.GetCache(BusiNo).Set(key, DefaultSysPropertySets);
        }

        public void Remove(List<int> DelList, string dbNo, string key = null)
        {
            if (DelList == null || DelList.Count == 0) return;
            StringBuilder sbd = new StringBuilder();
            foreach (var id in DelList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }
            object obj = null;
            if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
            {
                if (key == null)
                {
                    key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
                }
                if (obj != null)
                {
                    List<SysPropertySet> data = obj as List<SysPropertySet>;
                    data.RemoveAll(obj => sbd.ToString().Contains(obj.Id.ToString()));
                    _cacheManagger.GetCache(BusiNo).Set(key, data);
                }
            }
        }
        public void Update(List<int> UpdList, string dbNo, string key = null)
        {
            if (UpdList == null || UpdList.Count == 0) return;
            StringBuilder sbd = new StringBuilder();
            foreach (var id in UpdList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }
            var data = _repository.Where(o => sbd.ToString().Contains(o.Id.ToString()));
            if (data == null) return;
            if (key == null)
            {
                key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
            }
            object obj = null;
            if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
            {
                if (obj != null)
                {
                    List<SysPropertySet> dataCache = obj as List<SysPropertySet>;
                    dataCache.RemoveAll(obj => sbd.ToString().Contains(i.ToString()));
                    dataCache.AddRange(data);
                    _cacheManagger.GetCache(BusiNo).Set(key, dataCache);
                }
                else
                {
                    _cacheManagger.GetCache(BusiNo).Set(key, data);
                }
            }
            else
            {
                _cacheManagger.GetCache(BusiNo).Set(key, data);
            }
        }
        public void Clear(string dbNo,string? key)
        {
            if (key == null)
            {
                key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
            }
            _cacheManagger.GetCache(BusiNo).Remove(key);
        }

        public SysPropertySet GetItem(int id,string? key)
        {
            if (key == null)
            {
                key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
            }
            try
            {
                object obj = null;
                if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
                {
                    if (obj == null) return null;
                    List<SysPropertySet> data = obj as List<SysPropertySet>;
                    return data.FirstOrDefault(obj => obj.Id == id);
                }
                return null;
            }
            catch(Exception ex) { 
                return null; 
            }
        }

    }
}
