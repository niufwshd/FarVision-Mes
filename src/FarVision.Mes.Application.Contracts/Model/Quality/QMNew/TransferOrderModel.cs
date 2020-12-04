using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Quality.QMNew
{
    public class TransferOrderModel
    {
        /// <summary>
        /// 单据编号规则
        /// </summary>
        public string RuleCode { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        public string BillNo { get; set; }

        /// <summary>
        /// 产品信息
        /// </summary>
        public List<ProductionModel> Productions { get; set; }
    }
}
