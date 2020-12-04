using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
     [DataContract]
    public class tzInfo
    {
        [DataMember]
        public string barCode { get; set; }

        [DataMember]
        public string prdNo { get; set; }
        [DataMember]
        public string tz_no { get; set; }
        [DataMember]
        public string zc_no { get; set; }
        [DataMember]
        public string seb_no { get; set; }

        [DataMember]
        public string sal_no { get; set; }
    }

     [DataContract]
     public class woSchedulInfo
     {
        /// <summary>
        /// 排产日期，即工作日期
        /// </summary>
         [DataMember]
         public DateTime pcDate { get; set; }


         [DataMember]
         public List<schedulBan> pcBans { get; set; }

         public woSchedulInfo()
         {
             pcBans = new List<schedulBan>();
         }
     }
     [DataContract]
     public class schedulBan
     {
         [DataMember]
         public string SHIFT_NO { get; set; }

        [DataMember]
        public string SHIFT_NAME { get; set; }

        [DataMember]
        public string LAYOUT_NO { get; set; }

        [DataMember]
        public string LAYOUT_NAME { get; set; }

        /// <summary>
        /// 班次日期，即工作日期
        /// </summary>
        [DataMember]
        public DateTime WORK_DATE { get; set; }

        /// <summary>
        /// 班次开始时间
        /// </summary>
        [DataMember]
        public DateTime SHIFT_START_DATE { get; set; }

        [DataMember]
         public int qty { get; set; }
     }
}
