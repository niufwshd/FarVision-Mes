using WebMES.DTO.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
    [DataContract]
    [Serializable]
    public  class MenuActionCombox
    {
        [DataMember]
        public string actionName { get; set; }
        [DataMember]
        public bf_ComboxItemDTO[] comboxItems { get; set; }

    }
}
