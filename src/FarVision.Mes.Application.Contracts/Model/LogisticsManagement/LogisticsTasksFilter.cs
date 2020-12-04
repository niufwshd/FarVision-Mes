using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace WebMES.Model.LogisticsManagement
{
    [Serializable]
    [DataContract]
    public class LogisticsTasksFilter
    {
        /// <summary>
        /// 物流任务单
        /// </summary>
        [DataMember]
        public LogisticsTasksModel LogisticsTasks { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        [DataMember]
        public string Location { get; set; }

    }
}
