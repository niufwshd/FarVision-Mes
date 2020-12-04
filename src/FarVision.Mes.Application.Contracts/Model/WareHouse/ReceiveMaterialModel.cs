using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 待收料实体
    /// </summary>
    public class ReceiveMaterialModel
    {


        public string ID { get; set; }
        /// <summary>
        /// 备料单号
        /// </summary>
        public string MaterialPreparaPlanNo { get; set; }

        /// <summary>
        /// 拣料单号
        /// </summary>
        public string PickMaterialNo { get; set; }

        /// <summary>
        /// 拣料单ID
        /// </summary>
        public string PickMaterialID { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        public string LogisticsNo { get; set; }

        /// <summary>
        /// 物流行项目ID
        /// </summary>
        public string LogisticsItemId { get; set; }
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        /// 品号
        /// </summary>
        public string PROD_NO { get; set; }

        /// <summary>
        /// 品名
        /// </summary>
        public string PROD_NAME { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string PROD_SPC { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string BATCH_NO { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        public string PackageNo { get; set; }

        /// <summary>
        /// 来源仓库
        /// </summary>
        public string SourceWareHouse { get; set; }

        /// <summary>
        /// 来源库位
        /// </summary>
        public string SourceLocation { get; set; }

        /// <summary>
        /// 收料仓库
        /// </summary>
        public string TargetWareHouse { get; set; }

        /// <summary>
        /// 收料库位
        /// </summary>
        public string TargetLocation { get; set; }

        /// <summary>
        /// 到达数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 收货数量
        /// </summary>
        public decimal FinishQuantity { get; set; }

        /// <summary>
        /// 拒收数量
        /// </summary>
        public decimal RefuseQuantity { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        ///单位
        /// </summary>
        public string Unit { get; set; }


    }
}
