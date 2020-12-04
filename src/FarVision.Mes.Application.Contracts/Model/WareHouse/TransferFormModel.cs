using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    public class TransferFormModel
    {
        /// <summary>
        /// 移库单号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_No { get; set; }
        /// <summary>
        /// 单号规则编号
        /// </summary>
        public string RuleCode { get; set; }
        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_No { get; set; }


        /// <summary>
        /// 种类
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        //public string Scene { get; set; }


        /// <summary>
        /// 单据类型
        /// </summary>
        public string Type { get; set; }


        public string TypeName { get; set; }
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
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 送检单类型
        /// </summary>
        public string InspectionType { get; set; }

        /// <summary>
        /// 单据完成是否需要校验送检单
        /// </summary>
        public bool IsCompleteConfirmInspection { get; set; }

        /// <summary>
        /// ERP单别单号
        /// </summary>
        public string ERPSingle { get; set; }

        /// <summary>
        /// ERP单别
        /// </summary>
        public string ERPType { get; set; }

        /// <summary>
        /// ERP类型
        /// </summary>
        public string ERPObject { get; set; }

        /// <summary>
        /// 移动类型
        /// </summary>
        public string TransferType { get; set; }

        public string USR { get; set; }

        public string SYSDATE { get; set;}

        /// <summary>
        /// 备注
        /// </summary>
        public string REM { get; set; }

        /// <summary>
        /// 单据子表 （产品明细）
        /// </summary>
        public List<TransferFormProductModel> ProductList { get; set; }

        
    }
    public class TransferFormProductModel
    {

        public string ID { get; set; }

        public string MID { get; set; }



        /// <summary>
        /// 序号
        /// </summary>
        public int SerialNo { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_No { get; set; }



        public string Prod_Name { get; set; }


        public string PROD_SPC { get; set; }

        public string PROD_SNM { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 完成数量
        /// </summary>
        public decimal FinishQuantity { get; set; }
        /// <summary>
        /// 来源地点
        /// </summary>
        public string SourceLocation { get; set; }

        public string SourceLocationName { get; set; }
        /// <summary>
        /// 目标地点
        /// </summary>
        public string Location { get; set; }

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
        /// 状态
        /// </summary>
        public string Status { get; set; }


        public string StatusName { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }

        //库存类型
        public string StorageType { get; set; }


        /// <summary>
        /// 来源行项目编号（唯一）
        /// </summary>
        public string SourceLineNumber { get; set; }

        /// <summary>
        /// 来源单号  2020-03-27 下沉到行项目
        /// </summary>
        public string Source_No { get; set; }

        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        /// 客户订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// ERP订单号
        /// </summary>
        public string ERPOrderNumber { get; set; }


        /// <summary>
        /// 验收单行项目ID
        /// </summary>
        public string AcceptanceItemID { get; set; }


        /// <summary>
        /// Asn单上的目标库位 传递给送检单 子表
        /// </summary>
        public string InspectionLocation { get; set; }


       /// <summary>
        /// 原料批次
        /// </summary>
        public string MaterialBatch_No { get; set; }


        /// <summary>
        /// 不合格数量
        /// </summary>
        public decimal UnQualifiedQuantity { get; set; }

        /// <summary>
        /// 合格数量
        /// </summary>
        public decimal QualifiedQuantity { get; set; }

        public string OutFormApplyItemID { get; set;}

        /// <summary>
        /// 条码集合
        /// </summary>
        public List<ProductBarcodeModel> ProductBarcodeList { get; set; }


    }
}
