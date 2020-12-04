using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class autoScanResultDto
    {
        [DataMember]
        public string tz_no { get; set; }
        [DataMember]
        public string barCode { get; set; }

        [DataMember]
        public int qty { get; set; }

    }
}
