using WebMES.DTO.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
     [DataContract]
    public class QueryPageInfo
    {
        [DataMember]
        public string queryNo {get;set;}
        [DataMember]
        int page { get; set; }

        [DataMember]
        int pageSize { get; set; }
        [DataMember]
        string custParams { get; set; }

        [DataMember]
        string custSort { get; set; }

        [DataMember]
        FilterCustomDTO[] filterCustom { get; set; }
    }  
}
