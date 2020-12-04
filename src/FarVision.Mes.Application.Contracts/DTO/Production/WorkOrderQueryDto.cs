using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Production
{
    /// <summary>
    /// 工单信息查询
    /// </summary>
    [Serializable]
    public class WorkOrderQueryDto
    {
        public string prodNo { get; set; }
        public string prodSpec { get; set; }
        public string processNo { get; set; }
        public string stationNo { get; set; }
        public string banNo { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }


    }
}
