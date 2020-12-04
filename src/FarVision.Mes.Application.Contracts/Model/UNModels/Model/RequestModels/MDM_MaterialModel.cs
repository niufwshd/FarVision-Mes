using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 物料主数据
    /// </summary>
    public class MDM_MaterialModel
    {
        public BaseModel HEAD { get; set; }
        public List<MDM_MaterialModels> ITEM { get; set; }
    }

    /// <summary>
    /// BOM主数据
    /// </summary>
    public class MDM_MaterialModels
    {

        public MaterialHead MastData { get; set; }

        

    }

    public class WareHouseProduction
    {
        /// <summary>
        /// 仓库代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 库存上限
        /// </summary>
        public decimal Max { get; set; }

        /// <summary>
        /// 安全库存
        /// </summary>
        public decimal Min { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Replenish { get; set; }
    }



    /// <summary>
    /// 头
    /// </summary>
    public class MaterialHead : BaseModel
    {
        [Description("料号")]
        public string Code { get; set; }

        [Description("料品形态属性")]
        public string Type { get; set; }

        [Description("品名")]
        public string Name { get; set; }

        [Description("规格描述")]
        public string Spec { get; set; }

        [Description("图号")]
        public string FigureNo { get; set; }

        [Description("计量单位")]
        public string MeasuringUnit { get; set; }

        [Description("重量单位")]
        public string WeightUnit { get; set; }

        [Description("描述")]
        public string Describe { get; set; }

        [Description("仓库代码")]
        public string WareHouseCode { get; set; }

        [Description("仓库名称")]
        public string WareHouseName { get; set; }

        [Description("库存上限")]
        public Decimal MaxLimitQty { get; set; }

        [Description("库存下限")]
        public Decimal MinLimitQty { get; set; }

        [Description("发料倍量")]
        public Decimal Multiple { get; set; }

        [Description("有效性")]
        public string IsEffective { get; set; }

        [Description("生效日期")]
        public string EffectiveDate { get; set; }

        [Description("失效日期")]
        public string ExpirationDate { get; set; }

        [Description("是否BOM发料")]
        public string IsBOM { get; set; }

        [Description("生产部门")]
        public string ProductionDepartment { get; set; }

        [Description("生产部门")]
        public string ProductionDepartmentName { get; set; }

        [Description("仓库产品对应关系")]
        public List<WareHouseProduction> Warehose { get; set; }


        /// <summary>
        /// 操作标志（A U D）
        /// </summary>
        public string FLAG { get; set; }
    }

    ///<summary>
    ///
    /// </summary>         
    public class MaterialItem : BaseModel
    {



    }
}
