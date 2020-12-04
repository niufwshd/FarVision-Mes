using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 表单行项目
    /// </summary>
    public class FormItem
    {
        /// <summary>
        /// 库存ID
        /// </summary>
        public string StorageID { get; set; }
        /// <summary>
        /// 品号
        /// </summary>
        public string PROD_NO { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 主仓库编号
        /// </summary>
        public string MasterWareHouseNo { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_NO { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        /// <summary>
        /// 是否强制下架
        /// </summary>
        public bool isForcedOffShelves { get; set; }

        /// <summary>
        /// 来源单号 （出入移）
        /// </summary>
        public string Source_No { get; set; }

        /// <summary>
        /// 来源行项目（唯一）
        /// </summary>
        public string SourceLineNumber { get; set; }

        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }


        /// <summary>
        ///  目标编号 - 泛指仓库
        /// </summary>
        public string TargetNo_Form { get; set; }

       /// <summary>
       /// 仓管员
       /// </summary>
        public string SAL_NO { get; set; }

        /// <summary>
        /// 是否齐套拣料
        /// </summary>
        public bool IsGroupPickMaterial { get; set; }

        /// <summary>
        ///BOM 标准用量
        /// </summary>
        public decimal StandardQty { get; set; }

        /// <summary>
        /// 齐套数量
        /// </summary>
        public decimal GroupQty { get; set;}

        /// <summary>
        /// 客户订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// ERP订单号
        /// </summary>
        public string ERPOrderNumber { get; set; }

        /// <summary>
        /// 出库申请单行项目ID
        /// </summary>
        public string OutFormApplyItemID { get; set; }

        
 
    }
}
