using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
    [DataContract]
    public class shiftInfo
    {
        [DataMember]
        public string curBanNo { get; set; }

        [DataMember]
        public string curBanName { get; set; }
        [DataMember]
        public DateTime curBanDate { get; set; }
        [DataMember]
        public DateTime curBanStart { get; set; }

        [DataMember]
        public DateTime curBanEnd { get; set; }

        [DataMember]
        public string lastBanNo { get; set; }
        [DataMember]
        public string lastBanName { get; set; }
        [DataMember]
        public DateTime lastBanDate { get; set; }

        [DataMember]
        public DateTime lastBanStart { get; set; }
        [DataMember]
        public DateTime lastBanEnd { get; set; }
    }

    [Serializable]
    public class ShiftDto
    {
        public string shiftNo { get; set; }

        public string shiftName { get; set; }

        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }
        /// <summary>
        /// 有效时间,小时
        /// </summary>
        public decimal effTime { get; set; }
    }
}
