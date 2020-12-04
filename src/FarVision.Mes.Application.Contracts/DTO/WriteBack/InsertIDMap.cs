using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.WriteBack
{
    /// <summary>
    /// 插入后新旧ID映射
    /// </summary>
     [DataContract]
    public class InsertIDMap
    {
         [DataMember]
        public string busino { get; set; }

         [DataMember]
         public string bilNo { get; set; }
        
        [DataMember]
        public IDMap[] idmaps{ get; set; }

    }
  [DataContract]
    public class IDMap
    {
      [DataMember]
        public object oldID { get;set; }
      [DataMember]
        
         public object newID { get;set; }
    }
}
