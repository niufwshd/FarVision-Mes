using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.ExternalInterface.DNC
{
    [DataContract]
    public class dncResult
    {
        /// <summary>
        /// 状态 0成功 -1失败
        /// </summary>
        [DataMember]
        public int ReturnCode { get; set; }
        [DataMember]
        public string ReturnMsg { get; set; }
    }
}
