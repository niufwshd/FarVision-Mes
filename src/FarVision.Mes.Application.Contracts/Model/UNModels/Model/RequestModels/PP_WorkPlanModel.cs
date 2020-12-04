using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 生产订单
    /// </summary>
    public class PP_WorkPlanModel
    {

        public BaseModel HEAD { get; set; }
        public List<PP_WorkPlanModels> ITEM { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class PP_WorkPlanModels
    {

        public WorkPlanHead MastData { get; set; }

        //public List<BOMItem> ChildData { get; set; }

    }


    /// <summary>
    /// 头
    /// </summary>
    public class WorkPlanHead : BaseModel
    {
        [Description("订单类型编码")]
        public string PlanType { get; set; }

        [Description("订单类型名称")]
        public string PlanTypeDesc { get; set; }

        [Description("单号")]
        public string No { get; set; }

        [Description("生产订单状态")]
        public string DocSTatus { get; set; }        

        [Description("生产部门名称")]
        public string WorkShop { get; set; }

        [Description("生产部门代码")]
        public string WorkShopCode { get; set; }

        [Description("料号")]
        public string PartNo { get; set; }

        [Description("生产数量")]
        public decimal Quantity { get; set; }

        [Description("生产单位编码")]
        public string Unit { get; set; }

        [Description("生产单位名称")]
        public string UnitDesc { get; set; }

        [Description("创建人编码")]
        public string CreateUser { get; set; }

        [Description("创建人名称")]
        public string UserName { get; set; }

        [Description("计划开工日期")]
        public string PlanStartDate { get; set; }

        [Description("计划完工日期")]
        public string PlannEndDate { get; set; }

        [Description("入库仓库编码")]
        public string WarehouseCode { get; set; }

        [Description("入库仓库名称")]
        public string WarehouseName { get; set; }

        [Description("入库组织编码")]
        public string FactoryCode { get; set; }

        [Description("入库组织名称")]
        public string FactoryName { get; set; }


        /// <summary>
        /// 操作标志（A U D）
        /// </summary>
        public string FLAG { get; set; }
    }

    ///<summary>
    ///
    /// </summary>         
    public class WorkPlanItem : BaseModel
    {

    }
}
