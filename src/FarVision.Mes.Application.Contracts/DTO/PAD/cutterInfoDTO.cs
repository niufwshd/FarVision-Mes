using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class cutterInfoDTO
    {
        [DataMember]
        public string cutter_no { get; set; }
        [DataMember]
        public string cutter_name { get; set; }
        [DataMember]
        public string cutter_sn { get; set; }
        [DataMember]
        public string tz_no { get; set; }
        [DataMember]
        public string seb_no { get; set; }
        [DataMember]
        public string prd_no { get; set; }
        [DataMember]
        public string zc_no { get; set; }
        [DataMember]
        public string zc_step { get; set; }

        [DataMember]
        public string install_site { get; set; }


    }
}
