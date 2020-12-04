using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PostBack
{
    [Serializable]
    [DataContract]
    public class PostJsonStr
    {
        [DataMember]
        public string JsonData { get; set; }

    }
}
