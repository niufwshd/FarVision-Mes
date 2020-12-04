using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 退料实体
    /// </summary>
    public class RejectedMaterialModel
    {

        /// <summary>
        /// 投料ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 品号
        /// </summary>
        public string Prod_No { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }
        /// <summary>
        /// 单位
        /// </summary>

        public string Unit { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        /// <summary>
        /// 包装
        /// </summary>
        public string PackageNo { get; set; }
        /// <summary>
        /// 出库单条码ID 用于回写出库单 条码的退料数量
        /// </summary>
        public string FormBarcodeID { get; set; }


        
        /// <summary>
        ///  退料数量
        /// </summary>
        public decimal ReturnQuantity { get; set; }

        /// <summary>
        /// 来源单  出库单条码
        /// </summary>
        public decimal Source_No { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WareHouseNo { get; set; }

        /// <summary>
        /// 是否单件
        /// </summary>
        public bool isSingle { get; set; }


        /// <summary>
        /// 退料是否新包装
        /// </summary>
        public bool IsNewPackage { get; set; }


        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        /// 领料类型
        /// </summary>
        public string FeedType { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        public string ZC_NO { get; set; }

        /// <summary>
        /// 单件退料 实体
        /// </summary>
        public List<SingleBarcodeMode> SingleBarcodeList { get; set; }

    }


    public class SingleBarcodeMode
    {
        /// <summary>
        ///  包装条码绑定历史ID，用于改变标记是否已经
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 来源单据
        /// </summary>
        public string Source_No { get; set; }

        /// <summary>
        /// 包装
        /// </summary>
        public string PackageNo { get; set; }

        /// <summary>
        /// 单件条码
        /// </summary>
        public string Barcode { get; set; }
    }
}
