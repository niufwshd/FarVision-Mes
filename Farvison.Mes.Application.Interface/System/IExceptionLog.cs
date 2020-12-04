using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.SystemModel;

namespace WebMES.Service.Interface.System
{
    public interface IExceptionLog
    {
        Task AddExceptionLog(ExceptionLog exceptionLog);

        Task<IEnumerable<ExceptionLog>> GetExceptionLogs(string keyword);
    }
}
