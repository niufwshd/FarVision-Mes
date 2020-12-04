using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
    [DataContract]
    public class HeatNoDto
    {
        [DataMember]
        public string BAT_NO { get; set; }

        [DataMember]
        public DateTime TZ_DD { get; set; }
        
    }
}
