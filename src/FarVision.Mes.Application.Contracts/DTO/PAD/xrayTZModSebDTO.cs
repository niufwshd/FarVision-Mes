using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class xrayTZModSebDTO
    {
        [DataMember]
        public string TZ_NO { get; set; }
        [DataMember]
        public string MOD_NO { get; set; }

        [DataMember]
        public string MOD_NO_NEW { get; set; }

        [DataMember]
        public string YZJ_NO { get; set; }

        [DataMember]

        public string MRP_NO { get; set; }

        [DataMember]
        public string Info { get; set; }

    }
}
