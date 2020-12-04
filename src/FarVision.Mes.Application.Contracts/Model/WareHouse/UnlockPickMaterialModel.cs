using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    ///拣料解锁实体
    /// </summary>
    public class UnlockPickMaterialModel
    {
       /// <summary>
       /// ID
       /// </summary>
        public string ID { get; set; }
        /// <summary>
        ///品名
        /// </summary>
        public string Prod_No { get; set; }
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }
         /// <summary>
         /// 批次
         /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 来源仓库
        /// </summary>
        public string SourceWareHouse { get; set; }

        /// <summary>
        /// 拣料单号
        /// </summary>
        public string PickMaterialNo { get; set; }
        /// <summary>
        ///  生产日期
        /// </summary>
        public string ProductionDate { get; set; }
    }
}
