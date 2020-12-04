using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.Config
{
    [Serializable]
    [DataContract]
    public class DBNoName
    {
         [DataMember]
        public string DBNo { get; set; }

        [DataMember]
        public string DBName { get; set; }

         [DataMember]
        public string Rem { get; set; }
         [DataMember]
        public string DBDesc { get; set; }

        [DataMember]
        public string DBType { get; set; }
    }
}
