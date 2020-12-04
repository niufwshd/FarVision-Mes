using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.WriteBack
{
    [DataContract]
    public class KeyValue
    {
        [DataMember]
        public string key { get; set; }
        [DataMember]
        public object value { get; set; }

        [DataMember]
        public string att1 { get; set; }

        [DataMember]
        public string att2 { get; set; }

        [DataMember]
        public string att3 { get; set; }

    }
}
