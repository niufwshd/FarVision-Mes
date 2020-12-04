using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    public class StorageModel
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
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_NO { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 最后一次入库时间
        /// </summary>
        public DateTime LateStorageDate { get; set; }
        /// <summary>
        /// 最后一次出库时间
        /// </summary>
        public DateTime LateDeliveryDate { get; set; }
        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_NO { get; set; }
        /// <summary>
        /// 进出标识
        /// </summary>
        public string IOType { get; set; }

        //是否临时库位（有值的话 代表是临时库位）
        public string IsTempLocation { get; set;}


    }
}
