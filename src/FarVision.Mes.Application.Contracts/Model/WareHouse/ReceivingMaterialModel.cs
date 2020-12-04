using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 收料实体
    /// </summary>
    public class ReceivingMaterialModel
    {
        /// <summary>
        /// 移库单行项目id
        /// </summary>
        public string ItemID { get; set; }
        /// <summary>
        /// 单据编号
        /// </summary>
        public string FormNo { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string LTNO { get; set; }
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        /// 母件产品编号
        /// </summary>
        public string MPROD_NO { get; set; }


        /// <summary>
        /// 产品
        /// </summary>
        public string PROD_NO { get; set; }

        public string PROD_NAME { get; set; }

        public string PROD_SPC { get; set; }

        public string PROD_SNM { get; set; }

        /// <summary>
        /// 行项目计划数量
        /// </summary>
       public decimal PlanQuantity { get; set; }

        /// <summary>
        /// 行项目完成数量
        /// </summary>
        public decimal FinishQuantity { get; set; }
        /// <summary>
        /// 行项目未完成数量
        /// </summary>
        public decimal UnFinishedQuantity { get; set; }

        /// <summary>
        ///  到货数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }
        /// <summary>
        /// 物流单计划数量
        /// </summary>

        public decimal LTPlanQuantity { get; set; }

        /// <summary>
        /// 物流单完成数量
        /// </summary>
        public decimal LTFinishQuantity { get; set; }

        /// <summary>
        /// 物流单行项目ID
        /// </summary>
        public string LTITEMID { get; set; }
        /// <summary>
        ///  物流单ID
        /// </summary>
        public string LTID { get; set; }

        /// <summary>
        ///  目标仓库
        /// </summary>
        public string TargetWareHouse { get; set; }

        /// <summary>
        /// 来源仓库
        /// </summary>
        public string SourceWareHouse { get; set;}


        /// <summary>
        /// 条码集合
        /// </summary>
        public List<ReceivingMaterialBarcode> BarcodeList { get; set; }

    }
    //收料，拒收  条码
    public class ReceivingMaterialBarcode
    {

        public string ID { get; set;}

        public string MID { get; set;}


        public string MaterialPreparaPlanNo { get; set; }

        public string PickMaterialNo { get; set; }

        public string LogisticsNo { get; set; }

        public string WO_NO { get; set; }

        public string PROD_NO { get; set;}

        public string PROD_NAME { get; set; }

        public string PROD_SPC { get; set; }

        public string Unit { get; set; }

        public string BATCH_NO { get; set; }

        public string PACKAGENO { get; set; }


        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        /// <summary>
        /// 送达数量
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
        /// 数量
        /// </summary>
        public decimal QTY { get; set; }



        public string SourceWareHouse { get; set; }

        public string SourceLocation { get; set; }


        public string TargetWareHouse { get; set; }

        public string TargetLocation { get; set; }

        public string LogisticsItemId { get; set; }

        public string PickMaterialID { get; set; }

    }
}
