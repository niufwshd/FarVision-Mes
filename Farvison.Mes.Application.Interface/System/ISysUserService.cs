using FarVision.Mes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//using WebMES.Model.SystemModel;

namespace Farvison.Mes.Application.Interface.System
{
    public interface ISysUserService
    {
        void Add(List<int> InsList, string dbNo, string key = null);
        void Remove(List<int> DelList, string dbNo, string key = null);
        void Update(List<int> UpdList, string dbNo, string key = null);
        string BusiNo { get; }
        //List<Sys_User> DefaultSysUsers { get; }
        //Sys_User GetItem(int id, string? key);
    }
}
