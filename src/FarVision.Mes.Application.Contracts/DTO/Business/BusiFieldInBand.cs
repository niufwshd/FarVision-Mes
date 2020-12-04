using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.Business
{
    [Serializable]
    [DataContract]
    public  class BusiFieldInBand
    {


        [DataMember]
        public bf_Busi_BandDTO Band { get; set; }
        [DataMember]
        public bf_Busi_FieldDTO[] Fields  { get; set; }
         [DataMember]
        public bool bandVisible { get; set; }
        public BusiFieldInBand()
        {
            bandVisible = true;
        }

        public BusiFieldInBand(bf_Busi_BandDTO band,bf_Busi_FieldDTO[]  fields)
        {
            Band = band;
            Fields = fields;
            bandVisible = true;
        }

    }
}
