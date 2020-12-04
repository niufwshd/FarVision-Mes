using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PDA
{
    [Serializable]
    [ProtoContract]
    public class pdaDataDto
    {
        [ProtoMember(1)]
        public bool IsSuccess { get; set; }

        [ProtoMember(2)]
        public int pageCount { get; set; }

        [ProtoMember(3)]
        public byte[] protoData { get; set; }

        [ProtoMember(4)]
        public string strData { get; set; }
    }
}
