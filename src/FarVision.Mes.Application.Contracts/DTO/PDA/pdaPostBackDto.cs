using WebMES.DTO.Common;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PDA
{
    [Serializable]
    [DataContract]
    public class pdaPostBackDto
    {
       
        [DataMember]
        public string dataByteStr { get; set; }

        [DataMember]
        public List<RowStatesDTO> rowStates { get; set; }
    }
}
