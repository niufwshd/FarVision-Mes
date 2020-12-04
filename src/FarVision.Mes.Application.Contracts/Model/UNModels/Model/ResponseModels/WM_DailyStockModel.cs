using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 定时轮询库存查询接口
    /// </summary>
    public class WM_DailyStockModel : ResponseBaseModel
    {

        public List<WM_DailyStockHead> queryInfoList { get; set; }
    }

    public class WM_DailyStockHead
    {
        ///// <summary>
        ///// 接口交易ID
        ///// </summary>
        //public string ZGUID { get; set; }

        /// <summary>
        /// 料品（非必传项）
        /// </summary>
        public Product Item { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Organization Org { get; set; }

       

        /// <summary>
        /// 仓库
        /// </summary>
        public WareHouse Wh { get; set; }
    }
}
