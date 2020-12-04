using FarVision.Mes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farvison.Mes.Application.Interface.System
{
    public interface ISysPropertysService
    {
        void Add(List<int> InsList, string dbNo, string key = null);
        void Remove(List<int> DelList, string dbNo, string key = null);
        void Update(List<int> UpdList, string dbNo, string key = null);
        string BusiNo { get; }
        List<SysProperty> DefaultSysPropertys { get; }

        SysProperty GetItem(int id, string? key);
    }
}
