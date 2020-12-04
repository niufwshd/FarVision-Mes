using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Quality.QMNew
{
   public class PadInspectionModel
    {
        /// <summary>
        /// 方案Id
        /// </summary>
        public int SchemesId { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string SourceBillNo { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// 工单号
        /// </summary>
        public string TZ_NO { get; set; }

        /// <summary>
        /// 班次号
        /// </summary>
        public string BAN_NO { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string SEB_NO { get; set; }

        /// <summary>
        /// 工序号
        /// </summary>
        public string ZC_NO { get; set; }

        /// <summary>
        /// 工位号
        /// </summary>
        public string WorkStationNo { get; set; }

        /// <summary>
        /// 模具号
        /// </summary>
        public string MOD_NO { get; set; }

        /// <summary>
        /// 产品号
        /// </summary>
        public string ProductionNo { get; set; }

        /// <summary>
        /// 方案类型
        /// </summary>
        public string SchemeType { get; set; }

        /// <summary>
        /// 方案特性
        /// </summary>
        public string SchemeFeature { get; set; }

        /// <summary>
        /// 工序号
        /// </summary>
        public string ProcessNo { get; set; }

    }
}
