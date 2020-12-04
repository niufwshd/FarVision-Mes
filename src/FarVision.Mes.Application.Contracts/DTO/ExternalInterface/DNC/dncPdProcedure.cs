using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.ExternalInterface.DNC
{
    [DataContract]
    public class dncPdProcedure
    {
        [DataMember]
        public string partno { get; set; }
        [DataMember]
        public List<string> ops { get; set; }

        public dncPdProcedure()
        {
            this.ops = new List<string>();
        }
    }
}
