using Abp.Runtime.Caching;
using Abp.Runtime.Caching.Memory;
using Dapper;
using Farvison.Mes.Application.Interface.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.Dapper;
using WebMES.Model.SystemModel;

namespace FarVision.Mes.SystemService
{
    public class SysUserService : ISysUserService
    {
        private IRepository<SysUser> _repository;

        private IDapperRepository _dapperRepository;

        private ICacheManager _cacheManagger;

        public SysUserService(IRepository<SysUser> sysProperties,
            IDapperRepository dapperRepository, ICacheManager cacheManagger
       )
        {
            _repository = sysProperties;
            _dapperRepository = dapperRepository;
            _cacheManagger = cacheManagger;

        }
        public List<Sys_User> DefaultSysUser
        {
            get
            {
                var key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
                object obj = null;
                if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
                    return obj as List<Sys_User>;
                string sql = "select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep = dp.dep";
                var value = _dapperRepository.DbConnection.Query<Sys_User>(sql);
                _cacheManagger.GetCache(BusiNo).Set(key, value);
                return value != null ? value.ToList() : null;
            }
        }
        public string BusiNo
        {
            get { return "Sys_User"; }
        }

        public List<Sys_User> DefaultSysUsers => _cacheManagger.GetCache(BusiNo) as List<Sys_User>;;

        public void Add(List<int> InsList, string dbNo, string key = null)
        {
            if (InsList == null || InsList.Count == 0) return;
            StringBuilder sbd = new StringBuilder();
            foreach (var id in InsList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }
            string sql = string.Format("select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep=dp.dep where su.ID in({0})", sbd.ToString(0, sbd.Length - 1));
            IEnumerable<Sys_User> data = _dapperRepository.DbConnection.Query<Sys_User>(sql);
            if (data == null) return;
            foreach (var o in data)
            {
                string sqlRole = string.Format(@"select sr.* from sys_Role_User sru
                                            left join sys_Role sr on sr.ID=sru.MID
                                            where sru.UserID={0}", o.Id);
                //暂且强制把sysrole 转化为sys_role
                var roles = _dapperRepository.DbConnection.Query<Sys_Role>(sqlRole);
                o.OwnerRoles = roles != null ? roles.ToList():null;
            }
            if (key == null)
            {
                key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
            }
            if (DefaultSysUser == null)
            {
                _cacheManagger.GetCache(BusiNo).Set(key, data);
                return;
            }
            foreach (var o in data)
            {
                if (!DefaultSysUser.Contains(o))
                {
                    DefaultSysUser.Add(o);
                }
            }
            _cacheManagger.GetCache(BusiNo).Set(key, DefaultSysUser);

            //重置role缓存...
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
                    List<SysUser> data = obj as List<SysUser>;
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
            string sql = string.Format("select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep=dp.dep where su.ID in({0})", sbd.ToString(0, sbd.Length - 1));
            IEnumerable<Sys_User> data = _dapperRepository.DbConnection.Query<Sys_User>(sql);
            if (data == null) return;
            foreach (var o in data)
            {
                string sqlRole = string.Format(@"select sr.* from sys_Role_User sru
                                            left join sys_Role sr on sr.ID=sru.MID
                                            where sru.UserID={0}", o.Id);
                //暂且强制把sysrole 转化为sys_role
                var roles = _dapperRepository.DbConnection.Query<Sys_Role>(sqlRole);
                o.OwnerRoles = roles != null ? roles.ToList() : null;
            }
            if (key == null)
            {
                key = $"{Consts.DatabaseType}_{Consts.GBF_DB_Name}_{this.BusiNo}";
            }
            object obj = null;
            if (_cacheManagger.GetCache(BusiNo).TryGetValue(key, out obj))
            {
                if (obj != null)
                {
                    List<SysUser> dataCache = obj as List<SysUser>;
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

        public Sys_User GetItem(int id,string? key)
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
                    List<Sys_User> data = obj as List<Sys_User>;
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
