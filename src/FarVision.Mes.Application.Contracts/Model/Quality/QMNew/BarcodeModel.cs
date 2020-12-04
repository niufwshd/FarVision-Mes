using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Quality.QMNew
{
    public class BarcodeModel
    {
        /// <summary>
        /// 条码
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 来源地点
        /// </summary>
        public string SourceLocation { get; set; }

        /// <summary>
        /// 目标地点
        /// </summary>
        public string TargetLocation { get; set; }

        /// <summary>
        /// 产品号
        /// </summary>
        public string ProductionNo { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public string BatchNo { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime? ProducedDate { get; set; }

        /// <summary>
        /// 条码状态
        /// </summary>
        public string Status { get; set; }
    }
}
