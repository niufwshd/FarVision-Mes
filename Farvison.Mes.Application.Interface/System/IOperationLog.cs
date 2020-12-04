using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.SystemModel;

namespace WebMES.Service.Interface.System
{
    public interface IOperationLog
    {
        Task AddOperationLog(OperationLog operationLog);

        Task<IEnumerable<OperationLog>> GetOperationLogs(string keyword);
    }
}
