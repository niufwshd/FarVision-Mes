using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.Quality
{

    public class InspectionRecord
    {

        public int ID { get; set; }

        public string QC_DATE { get; set; }

        public string BillDate { get; set; }

        public string SysDate { get; set; }

        public string SourceType { get; set; }

        public string TZ_NO { get; set; }

        public string Usr { get; set; }

        public string PRJ_CATEGORY { get; set; }


        public string PRJ_TYPE { get; set; }

        public string BAN_NO { get; set; }

        public string SEB_NO { get; set; }


        public string ZC_NO { get; set; }


        public string BILTYPE { get; set; }

        public string PRD_NO { get;set; }


        public string QC_Result { get; set; }

        public string USER_NAME { get; set; }

        public string BatchNo { get; set; }


        public string BillStatus { get; set; }

        /// <summary>
        /// 检验结果值集合
        /// </summary>
        public List<InspectionRecordValue> ValueList { get; set; }

    }


    public class InspectionRecordValue
    {
        public string ID { get; set; }

        public string MID { get; set; }

        public string FirstValueID { get; set; }

        public string FirstValue { get; set; }

        public string NUM_MAX { get; set; }
        public string NUM_MIN { get; set; }

        public string QC_ITM { get; set; }
        public string QC_RESULT { get; set; }

        public string QC_UNIT { get; set; }

        public string QC_VALUE { get; set; }

        public string QC_MODEL { get; set; }

        public string QC_Enum_BusiNo { get; set; }

        public int InspectionQty { get; set; }

        public string InspectionDept { get; set; }  
    }
}
