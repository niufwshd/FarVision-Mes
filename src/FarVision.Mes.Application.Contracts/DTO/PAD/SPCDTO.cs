using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{

    [DataContract]
    public class SPCsDTO
    {
        [DataMember]
        public string SPC_TYPE { get; set; }
        [DataMember]
        public string SPC_TYPENAME { get; set; }
        [DataMember]
        public int QTY { get; set; }

        [DataMember]
        public string EntryID { get; set; }

        [DataMember]
        public List<SPCDTO> SPCS { get; set; }

        public SPCsDTO()
        {
            SPCS = new List<SPCDTO>();
        }
    }
    [DataContract]
    public class SPCDTO
    {
        [DataMember]
        public string SPC_TYPE { get; set; }
        [DataMember]
        public string SPC_NO { get; set; }
         [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string RESP_ZCNO { get; set; }

        [DataMember]
        public string RESP_ZCNAME { get; set; }
    }
}
