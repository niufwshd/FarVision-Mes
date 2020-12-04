using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Data
{
    [DataContract]
    public class ResponseStatusModel<T>
    {
        [DataMember]
        public string StatusCode { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public bool IsSuccess { get; set; }
        [DataMember]
        public T Data { get; set; }
    }
}
