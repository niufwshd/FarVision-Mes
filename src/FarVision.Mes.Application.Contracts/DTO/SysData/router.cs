using WebMES.DTO.WriteBack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
    [DataContract]
    public class router
    {
        [DataMember]
        public string routeName { get; set; }
        [DataMember]
        public routerInfo routerInfo { get; set; }

        public router()
        {
            routerInfo = new routerInfo();
        }

    }
    [DataContract]
    public class routerInfo
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public routerData data { get; set; }
        [DataMember]
        public string templateUrl { get; set; }

        [DataMember]
        public bool @abstract{get;set;}

        [DataMember]
        public string template { get; set; }

        public routerInfo()
        {
            data = new routerData();
        }
    }

    [DataContract]
    public class routerData
    {
         [DataMember]
        public string pageTitle { get; set; }
    }
}
