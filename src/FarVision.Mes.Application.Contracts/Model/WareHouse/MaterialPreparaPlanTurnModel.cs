using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 备料计划转单实体
    /// </summary>
    public class MaterialPreparaPlanTurnModel
    {
        /// <summary>
        /// 计划单号
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
        /// 开工日期(来源工单的预开工日期)
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 工作中心
        /// </summary>
        public string WkCenter_No { get; set; }

        /// <summary>
        /// 优先级顺序 （来源工单的生产顺序）
        /// </summary>
        public string PriorityOrder { get; set; }
        /// <summary>
        /// 交货日期
        /// </summary>
        public string CreateDate { get; set; }



        //行项目
        
        public string Prod_No { get; set; }

        public string Prod_Name { get; set; }
        /// <summary>
        /// 需求数量
        /// </summary>
        public decimal PlanQuantity { get; set; }

        /// <summary>
        /// 转单数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 移库数量
        /// </summary>
        public decimal TransferQuantity { get; set; }

        /// <summary>
        /// 未完成数量
        /// </summary>
        public decimal UnFinishedQuantity { get; set; }


        public decimal NeedQuantity { get; set; }

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
        public string ItemStatus { get; set; }

        public string ItemStatusName { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }


        public string LineNumber { get; set; }

    }

  
}
