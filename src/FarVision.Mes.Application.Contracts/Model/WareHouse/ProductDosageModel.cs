using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 产品物料用量
    /// </summary>
    public class ProductDosageModel
    {
        /// <summary>
        /// 产品
        /// </summary>
        public string MPROD_NO { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        public string PROD_NO { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        public string ProcessNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string VerNo { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
    }
}
