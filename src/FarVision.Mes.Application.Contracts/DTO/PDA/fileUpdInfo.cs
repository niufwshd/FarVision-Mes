using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PDA
{
    [DataContract]
    public class fileUpdInfo
    {
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public string FilePath { get; set; }
        [DataMember]
        public string WorkSys { get; set; }
        [DataMember]
        public string ClientPath { get; set; }
        [DataMember]
        public bool ClientDelete { get; set; }

        [DataMember]
        public string HashValue { get; set; }
    }
}
