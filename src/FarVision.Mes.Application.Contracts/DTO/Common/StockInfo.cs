using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Common
{
    [DataContract]
    public class StockInfo
    {

        [DataMember]
        public string Wh;
        [DataMember]
        public string PrdNo;
        [DataMember]
        public string Type;
        [DataMember]
        public string Flag  ;
        [DataMember]
        public decimal Qty = 0m; 
        [DataMember]
        public  decimal Qty_Brw =0m ;  
        [DataMember]
        public decimal Qty_Lrn = 0m; 
        [DataMember]
        public decimal Qty_Rk = 0m;  
        [DataMember]
        public decimal Qty_Ck = 0m; 
        [DataMember]
        public decimal Qty_Sq = 0m;   
        [DataMember]
        public decimal Qty_Zg = 0m; 
        [DataMember]
        public decimal Qty_Sa = 0m; 
        [DataMember]
        public decimal Qty_On_Odr = 0m; 
        [DataMember]
        public decimal Qty_On_Way = 0m; 
        [DataMember]
        public decimal Qty_On_Prc = 0m; 
        [DataMember]
        public decimal Qty_On_Rsv = 0m; 
    }
}
