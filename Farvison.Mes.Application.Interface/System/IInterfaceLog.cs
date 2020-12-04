using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.SystemModel;

namespace WebMES.Service.Interface.System
{
    public interface IInterfaceLog
    {
        Task AddInterfaceLog(InterfaceLog interfaceLog);

        Task<IEnumerable<InterfaceLog>> GetInterfaceLogs(string keyword);
    }
}
