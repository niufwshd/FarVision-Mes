using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    public class OutFormMaterialPreparaPlanModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 出库单号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_No { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        public string Status { get; set; }


        public string StatusName { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        public string SourceNo_Form { get; set; }


        public string SourceName_Form { get; set; }

        /// <summary>
        /// 目的编号
        /// </summary>
        public string TargetNo_Form { get; set; }

        public string TargetName_Form { get; set; }


        public string SysDate { get; set; }

        public string USR { get; set; }

        public string USRNAME { get; set; }

        /// <summary>
        /// 目的类型
        /// </summary>
        public string TargetType { get; set; }




        /// <summary>
        /// 出库备料子表 （产品明细）
        /// </summary>
        public List<OutFormMaterialPreparaPlanItem> ProductList { get; set; }


    }
    public class OutFormMaterialPreparaPlanItem
    {
        public string ID { get; set; }

        public string MID { get; set; }

        /// <summary>
        /// 来源行id （出库申请行id）
        /// </summary>
        public string SourceItemID { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_No { get; set; }


        public string Prod_Name { get; set; }

        /// <summary>
        ///  产品规格
        /// </summary>
        public string PROD_SPC { get; set; }


        /// <summary>
        /// 产品简称
        /// </summary>
        public string PROD_SNM { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 确认数量
        /// </summary>
        public decimal ConfirmQuantity { get; set; }


        /// <summary>
        /// 捡料数量
        /// </summary>
        public decimal PickMaterialQuantity { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        public decimal UnQualifiedQuantity { get; set; }


        /// <summary>
        /// 合格数量
        /// </summary>
        public decimal QualifiedQuantity { get; set; }


        /// <summary>
        /// 来源地点
        /// </summary>
        public string SourceLocation { get; set; }


        public string SourceLocationName { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public string Location { get; set; }


        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }





        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }


        /// <summary>
        /// ERP订单号
        /// </summary>
        public string ERPOrderNumber { get; set; }

        /// <summary>
        /// 出库单捡料单号
        /// </summary>
        public string PickMaterialNo { get; set; }


        public string Status { get; set; }


        public string StatusName { get; set; }

        public string TargetNo_Form { get; set; }








        /// <summary>
        /// 条码集合
        /// </summary>
        public List<ProductBarcodeModel> ProductBarcodeList { get; set; }

    }
}
