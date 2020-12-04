using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class PDRollBackInfo
    {
        [DataMember]
        public string rollBackZC_NO{get;set;}
        [DataMember]
        public string rollToZC_NO{get;set;}
        [DataMember]
        public string wrNo{get;set;}
         [DataMember]
        public string moNo { get; set; }

        [DataMember]
        public string idNo{get;set;}
        [DataMember]
        public string sal_no{get;set;}
        [DataMember]
        public string backReason{get;set;}

        [DataMember]
        public string tz_no { get; set; }

        [DataMember]
        public string prdNo { get; set; }

       
         [DataMember]
        public string unit { get; set; }


        [DataMember]
        public decimal qty { get; set; }
        [DataMember]
        public decimal qty_lost { get; set; }
        [DataMember]
        public decimal qty_scrap { get; set; }
        [DataMember]
        public List<string> barList{get;set;}
    }
}
