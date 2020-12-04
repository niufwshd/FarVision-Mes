using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.Common
{
     [DataContract]
    public class ResultDTO
    {

         [DataMember]
         public bool success
         {
             get
             {
                 return errorText==null || string.IsNullOrEmpty(errorText.Trim());

             }
         }
        [DataMember]
        public string errorText { get; set; }

        [DataMember]
        public string info { get; set; }
         [DataMember]
        public string errorCode { get; set; }
         [DataMember]

        public object data { get; set; }
    }
}
