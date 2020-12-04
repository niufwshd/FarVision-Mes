using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 库存查询[废弃]
    /// </summary>
    public class WM_StockModel
    {
        public BaseModel HEAD { get; set; }
        public List<WM_StockModels> ITEM { get; set; }
    }

    /// <summary>
    /// BOM主数据
    /// </summary>
    public class WM_StockModels
    {

        public StockHead MastData { get; set; }

        //public List<BOMItem> ChildData { get; set; }

    }


    /// <summary>
    /// 头
    /// </summary>
    public class StockHead : BaseModel
    {
        [Description("工厂编号")]
        public string FactoryNo { get; set; }

        [Description("仓库编号")]
        public string WarehouseNo { get; set; }

        [Description("料号")]
        public string MaterialNo { get; set; }

        [Description("数量")]
        public string Quantity { get; set; }

        [Description("批次")]
        public string BatchNo { get; set; }


        /// <summary>
        /// 操作标志（A U D）
        /// </summary>
        public string FLAG { get; set; }
    }
    ///<summary>
    ///
    /// </summary>         
    public class StockItem : BaseModel
    {

    }
}
