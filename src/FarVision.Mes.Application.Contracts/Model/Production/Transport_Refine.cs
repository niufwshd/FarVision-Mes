using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Production
{
    public class Transport_Refine
    {
        public int ID { get; set; }

        public int RL_ID { get; set; }

        public string LSB_NO { get; set; }

        public string YZJ_NO { get; set; }

        public DateTime? SYSDATE { get; set; }

        public DateTime? OUTTIME { get; set; }

        public string TZ_NO { get; set; }

        public string RL_TZ { get; set; }

        public decimal? ZY_CAPACITY { get; set; }

        public string SEB_NO { get; set; }

        public string BAN_NO { get; set; }

        public string ZC_NO { get; set; }

        public string UNIT { get; set; }

        public string LSB_TZ { get; set; }

        public decimal TEMPERATURE { get; set; }

        public string ids { get; set; }

        public List<string> DYZZList { get; set; }

        public List<SBPDRecord> sbparList { get; set; }


    }
    public class HistoryMaterial
    {

        /// <summary>
        /// 工序
        /// </summary>
        public string ZC_NO { get; set; }

        /// <summary>
        /// 品号
        /// </summary>
        public string PRD_NO { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string BEGIN_DATE { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string END_DATE { get; set; }
    }


    public class SBPDRecord
    {

        public string NO { get; set; }

        public string PA_NO { get; set; }

        public string PA_Name { get; set; }

        public string SEB_NO { get; set; }

        public string SEB_Name { get; set; }

        public string Para_NO { get; set; }

        public string Para_Name { get; set; }

        public string Para_Value { get; set; }

        public string UT { get; set; }

        public string UsrName { get; set; }

        public DateTime SysDate { get; set; }

        public string ZC_NO { get; set; }

        public string CL_TB { get; set; }

        public int PType { get; set; }
    }
}
