using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Common
{
    [DataContract]
    [Serializable]
    public class BillNoInfo
    {
        [DataMember]
        public string billID { get; set; }
        [DataMember]
        public string billType { get; set; }
        [DataMember]
        public DateTime billDate { get; set; }
        [DataMember]
        public string dep { get; set; }
        [DataMember]
        public string maker { get; set; }
        [DataMember]
        public string db { get; set; }
        [DataMember]
        public string other { get; set; }
        [DataMember]
        public bool isUpdate { get; set; }
        [DataMember]
        public string noFieldName { get; set; }
        [DataMember]
        public string tableName { get; set; }
        [DataMember]
        public string prdNo { get; set; }

    }
    [DataContract]
    [Serializable]
    public class BillNo
    {
        [DataMember]
        public string billNo { get; set; }
        [DataMember]
        public string fixPart { get; set; }
        [DataMember]
        public string serialNum { get; set; }

    }
}
