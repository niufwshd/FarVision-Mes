using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// BOM主数据
    /// </summary>
    public class MDM_BOMModel
    {

  
        public BaseModel HEAD { get; set; }
        public List<MDM_BOMModels> ITEM { get; set; }

    }

    /// <summary>
    /// BOM主数据
    /// </summary>
    public class MDM_BOMModels
    {

        public BOMHead  MastData { get; set; }
       
        public List<BOMItem> ChildData { get; set; }

    }

    /// <summary>
    /// 头
    /// </summary>
    public class BOMHead 
    {
        [Description("母件料号")]
        public string PartNo { get; set; }

        [Description("生产目的")]
        public string ProductionPurpose { get; set; }

        [Description("版本号")]
        public string VersionNo { get; set; }

        [Description("有效性")]
        public string IsEffective { get; set; }

        [Description("生效日期")]
        public string EffectiveDate { get; set; }

        [Description("失效日期")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// 操作标志（A U D）
        /// </summary>
        public string FLAG { get; set; }
    }

    ///<summary>
    ///
    /// </summary>         
    public class BOMItem  
    {

        [Description("行号")]
        public string Seq { get; set; }

        [Description("子项料号")]
        public string MaterialNo { get; set; }

        [Description("用量")]
        public decimal Quantity { get; set; }

        [Description("母件底数")]
        public decimal ParentBaseQty { get; set; }

        [Description("计量单位编码")]
        public string MeasuringUnit { get; set; }

        [Description("计量单位名称")]
        public string MeasuringUnitName { get; set; }

        [Description("发料方式")]
        public string FeedingMode { get; set; }

        [Description("存储地点")]
        public string StorageLocation { get; set; }

        [Description("存储地点代码")]
        public string StorageLocationCode { get; set; }

        [Description("虚拟标识")]
        public string VirtualId { get; set; }

        [Description("备注")]
        public string Remark { get; set; }

        [Description("有效性")]
        public string IsEffective { get; set; }

        [Description("生效日期")]
        public string EffectiveDate { get; set; }

        [Description("失效日期")]
        public string ExpirationDate { get; set; }
    }

}
