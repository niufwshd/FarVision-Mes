using WebMES.DTO.SysData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PostBack
{
    [Serializable]
    [DataContract]
    public class PostData
    {
        [DataMember]
        public BusiData[] BusiDatas { get; set; }
        [DataMember]
        public RelationDTO[] relations { get; set; }

        [DataMember]
        public string otherData { get; set; }

       
    }
    [Serializable]
    [DataContract]
    public class BusiData 
    {
        [DataMember]
        public string BusiNo { get; set; }

        [DataMember]
        public string ParentBusiNo { get; set; }

        [DataMember]
        public string JsonData { get; set; }


        public string TableName { get; set; }

        public string ParentTableName { get; set; }

        public object objBDO { get; set; }
    
    }

    [Serializable]
    [DataContract]
    public class RowsData
    {
        [DataMember]
        public string JsonData { get; set; }
    }
}
