using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.SystemModel;

namespace WebMES.Service.Interface.System
{
    public interface IAlarmLog
    {
        Task AddAlarmLog(AlarmLog AlarmLog);

        Task<IEnumerable<AlarmLog>> GetAlarmLogs(string keyword);
    }
}
