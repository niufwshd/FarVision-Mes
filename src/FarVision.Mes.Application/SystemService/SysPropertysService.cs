using Abp.Runtime.Caching;
using Abp.Runtime.Caching.Memory;
using Farvison.Mes.Application.Interface.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using WebMES.Model.SystemModel;
using WebMES.Utils.Context;

namespace FarVision.Mes.SystemService
{
    public class SysPropertysService: ISysPropertysService
    {
        private  IRepository<SysProperty> _repository;
        private ISysPropertySetService _sysPropertySetService;
        private ICacheManager _cacheManagger;
        private ISysUserService _sysUserService;
        public SysPropertysService(IRepository<SysProperty> sysProperties, 
            ISysPropertySetService sysPropertySetService,ICacheManager cacheManger, ISysUserService sysUserService)
        {
            _repository = sysProperties;
            _sysPropertySetService = sysPropertySetService;
            _cacheManagger = cacheManger;
            _sysUserService = sysUserService;
        }
        public List<SysProperty> DefaultSysPropertys
        {
            get
            {
                var key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
                object obj = null;
                if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
                    return obj as List<SysProperty>;
                var value = _repository.GetListAsync().Result;
                _cacheManagger.GetCache(BusiNo).Set(key, value);
                return value;
            }
        }
        public string BusiNo
        {
            get { return "Sys_Property"; }
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
            if (DefaultSysPropertys == null)
            {
                _cacheManagger.GetCache(BusiNo).Set(key, data);
                return;
            }
            foreach (var o in data)
            {
                if (!DefaultSysPropertys.Contains(o))
                {
                    DefaultSysPropertys.Add(o);
                }
            }
            _cacheManagger.GetCache(BusiNo).Set(key, DefaultSysPropertys);
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
                    List<SysProperty> data = obj as List<SysProperty>;
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
                    List<SysProperty> dataCache = obj as List<SysProperty>;
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

        public SysProperty GetItem(int id,string? key)
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
                    List<SysProperty> data = obj as List<SysProperty>;
                    return data.FirstOrDefault(obj => obj.Id == id);
                }
                return null;
            }
            catch(Exception ex) { 
                return null; 
            }
        }

        public object GetPropertyValue(string menuNo, string itemName, object defaultValue)
        {
            object result = GetPropertyValue(menuNo, itemName);
            if (result == null) result = defaultValue;
            return result;
        }
        public  object GetPropertyValue(string menuNo, string itemName)
        {
           var data  = this.DefaultSysPropertys.FirstOrDefault( o=>o.MenuNo.Equals(menuNo) &&  o.ItemNo.Equals(itemName));
            return GetPropertyValue(menuNo, data);
        }
        private object GetPropertyValue(string menuNo, SysProperty sp)
        {
            if (sp == null) return null;
            if (sp.IsSystem)
            {
                SysPropertySet valuetext = _sysPropertySetService.GetItem(sp.Id,null);
                if (valuetext == null || String.IsNullOrEmpty(valuetext.Value)) return sp.ItemValue;
                //是否要更新缓存？
                return valuetext.Value;
            }
            else
            {
                Sys_Property_Set valuetext = _sysUserService.DefaultSysUsers.FirstOrDefault(o=>o.No == HttpContextExt.UserNo).Menu_Properties.GetValueOrDefault(menuNo);
                if(valuetext == null) return sp.ItemValue;
                return valuetext.Value;
            }
        }

    }
}
