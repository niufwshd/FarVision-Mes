using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.Quality
{
    [Serializable]
    [DataContract]
    public class RecordValue
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int MID { get; set; }

        [DataMember]
        public string QC_RESULT { get; set; }

        [DataMember]
        public string QC_VALUE { get; set; }

        [DataMember]
        public int INSPECTIONQTY { get; set; }

        [DataMember]
        public string SourceBillNo { get; set; }

        /// <summary>
        /// 炉批次
        /// </summary>
        [DataMember]
        public string FurnaceBatch { get; set; }

        /// <summary>
        /// 铸件批次
        /// </summary>
        [DataMember]
        public string CastingBatch { get; set; }

        [DataMember]
        public string Feature { get; set; }
    }
}
