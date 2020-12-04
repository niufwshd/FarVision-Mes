using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 条码库存
    /// </summary>
    public class StorageBarcodeModel
    {
        /// <summary>
        /// 库位
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 产品
        /// </summary>
        public string Prod_NO { get; set; }
        /// <summary>
        /// 条码（包装好）
        /// </summary>
        public string PackageNO { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_NO { get; set; }


        /// <summary>
        /// 原料批次
        /// </summary>
        public string MaterialBatch_NO { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_NO { get; set; }
        /// <summary>
        /// 增减标识(+\-)
        /// </summary>
        public string IOType { get; set; }
    }
}
