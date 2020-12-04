using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 供应商主数据
    /// </summary>
    public class MDM_SupplierModel
    {
        public BaseModel HEAD { get; set; }
        public List<MDM_SupplierModels> ITEM { get; set; }
    }

    /// <summary>
    /// BOM主数据
    /// </summary>
    public class MDM_SupplierModels
    {

        public SupplierHead MastData { get; set; }

        //public List<BOMItem> ChildData { get; set; }

    }

    /// <summary>
    /// 头
    /// </summary>
    public class SupplierHead : BaseModel
    {
        [Description("供应商编码")]
        public string SupplierNO { get; set; }

        [Description("名称")]
        public string NAME { get; set; }

        [Description("简称")]
        public string ShortName { get; set; }

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
    public class SupplierItem : BaseModel
    {



    }
}
