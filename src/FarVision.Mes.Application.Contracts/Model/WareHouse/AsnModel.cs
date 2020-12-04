using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// Asn实体
    /// </summary>
    public class AsnModel
    {
        /// <summary>
        /// Asn单号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_No { get; set; }
        /// <summary>
        /// 单据类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        public string Status { get; set; }

        public string StatusName { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string Dept { get; set; }


        public string DeptName { get; set; }
        /// <summary>
        /// 来源编号
        /// </summary>
        public string SourceNo_Form { get; set; }

        public string SourceName_Form { get; set; }
        /// <summary>
        /// 目标编号
        /// </summary>
        public string TargetNo_Form { get; set; }

        public string TargetName_Form { get; set; }
        /// <summary>
        /// 交货日期
        /// </summary>
        public string AcceptingDate { get; set; }


        /// <summary>
        /// 首次收货时间
        /// </summary>
        public string FirstReceiptTime { get; set; }
        /// <summary>
        /// 单据子表 （产品明细）
        /// </summary>
        public List<AsnProductModel> ProductList { get; set; }


    }
    public class AsnProductModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string ID { get; set; }

        public string MID { get; set; }

        /// <summary>
        /// 行项目来源单
        /// </summary>
        public string Source_No { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_No { get; set; }

        public string Prod_Name { get; set; }

        /// <summary>
        /// 产品规格
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
        /// 数量
        /// </summary>
        public decimal FinishQuantity { get; set; }


        /// <summary>
        /// 拒收数量
        /// </summary>
        public decimal RefuseQuantity { get; set; }

        /// <summary>
        /// 目标地点
        /// </summary>
        public string Location { get; set; }


        /// <summary>
        /// 目标地点名称
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 原料批次
        /// </summary>
        public string MaterialBatch_No { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        public string StatusName { get; set; }

        public string StorageType { get; set; }

        /// <summary>
        ///  目标仓库编号
        /// </summary>
        public string TargetWareHouseNo { get; set; }

        /// <summary>
        /// 目标仓库名称
        /// </summary>
        public string TargetWareHouseName { get; set; }


        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        public string ItemNo { get; set; }


        /// <summary>
        /// 移库类型 
        /// </summary>
        public string TransferType { get; set; }
        /// <summary>
        /// 产品条码（包装）
        /// </summary>
        public List<AsnProductBarcodeModel> ProductBarcodeList { get; set; }
    }


    public class AsnProductBarcodeModel
    {
        
        public string ID { get; set; }
        public string MID { get; set; }

        public string Prod_No { get; set; }

        public string Prod_Name { get; set; }


        public string Batch_No { get; set; }

        public string PackageNo { get; set; }


        public decimal Quantity { get; set; }


        public decimal FinishQuantity { get; set; }


        public string Unit { get; set; }


        public string Status { get; set; }

        public string StatusName { get; set; }

        public string ProductionDate { get; set; }

        public string StorageType { get; set; }
    }


}
