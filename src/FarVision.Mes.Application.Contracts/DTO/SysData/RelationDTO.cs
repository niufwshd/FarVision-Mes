using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
    [Serializable]
    [DataContract]
    public class RelationDTO
    {
        [DataMember]
        public string name {get;set;}
        [DataMember]
        public string parentBusiNo { get; set; }
        [DataMember]
        public List<string> parentCols { get; set; }
        [DataMember]
        public List<string> childCols { get; set; }
        public RelationDTO()
        {
            parentCols = new List<string>();
            childCols = new List<string>();
        
        }

    }
}
