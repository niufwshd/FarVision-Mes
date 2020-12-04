using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Quality
{
    /// <summary>
    /// 送检单条码信息
    /// </summary>
    public class QMSIOBCI
    {
        /// <summary>
        /// 条码信息
        /// </summary>
        /// <returns></returns>
        public string BarCode { get; set; }

        /// <summary>
        /// 工序号
        /// </summary>
        /// <returns></returns>
        public string ProcessNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty { get; set; }

        public int? HandleResult { get; set; }

        public string SourceLocation { get; set; }

        public string TargetLocation { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

    }
}
