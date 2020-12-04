using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
    [DataContract]
    public class permissionDto
    {
        [DataMember]
        public string actionName { get; set; }

        [DataMember]
        public int actionValue { get; set; }

    }
}
