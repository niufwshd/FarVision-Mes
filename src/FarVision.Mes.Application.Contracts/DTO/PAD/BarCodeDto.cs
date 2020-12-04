using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class BarCodeDto
    {
        [DataMember]
        public string barCode { get; set; }

        [DataMember]
        public string prdNo { get; set; }
        [DataMember]
        public string unit { get; set; }
        [DataMember]
        public string tz_no { get; set; }
        [DataMember]
        public string process_no { get; set; }
        [DataMember]
        public string seb_no { get; set; }
        [DataMember]
        public string sal_no { get; set; }

        [DataMember]
        public string code_Status { get; set; }

        [DataMember]
        public string entryID { get; set; }
        [DataMember]
        public string spcNo { get; set; }
        [DataMember]
        public string spcName { get; set; }
        [DataMember]
        public string mo_no { get; set; }
        [DataMember]
        public string id_no { get; set; }

      
        [DataMember]
        public string SPC_DESCR { get; set; }
        
        [DataMember]
        public string RESP_ZCNO { get; set; }
        [DataMember]
        public DateTime DSP_DD { get; set; }
        [DataMember]
        public string BAN_NO { get; set; }
        [DataMember]
        public string DEPT { get; set; }
        [DataMember]
        public string STEEL_NO { get; set; }

        /// <summary>
        /// //0-unchange,1-add,2-modify,3-delete,4-unDef
        /// </summary>
        [DataMember]
        public int dataState { get; set; }

    }
}
