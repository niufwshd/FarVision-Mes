using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Production
{
    [Serializable]
    public class OrderLoginDto
    {
        public string type { get; set; }
        public string woNo { get; set; }

        public string prodNo { get; set; }
        public string processNo { get; set; }
        public string stationNo { get; set; }
        public string shiftNo { get; set; }
        public string usrNo { get; set; }

        
        public DateTime shiftStartTime { get; set; }

        public DateTime shiftEndTime { get; set; }

        /// <summary>
        /// 是否覆盖已报工的人员
        /// </summary>
        public bool isCoverOutputUsr{get;set;}

    }
}
