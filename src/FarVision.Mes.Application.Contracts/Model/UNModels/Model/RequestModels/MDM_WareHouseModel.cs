using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 仓库主数据
    /// </summary>
    public class MDM_WareHouseModel
    {   
        public BaseModel HEAD{ get; set; }
        public List<MDM_WareHouseModels> ITEM { get; set; }
    }


    /// <summary>
    /// BOM主数据
    /// </summary>
    public class MDM_WareHouseModels
    {

        public WareHouseHead MastData { get; set; }

        //public List<BOMItem> ChildData { get; set; }

    }

    /// <summary>
    /// 头
    /// </summary>
    public class WareHouseHead : BaseModel
    {
        [Description("仓库编号")]
        public string No { get; set; }

        [Description("仓库名称")]
        public string Name { get; set; }

        [Description("到货地址")]
        public string Address { get; set; }

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


}
