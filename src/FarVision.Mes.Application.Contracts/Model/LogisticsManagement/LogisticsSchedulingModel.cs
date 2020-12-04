using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.LogisticsManagement
{

    /// <summary>
    /// 物流调度实体
    /// </summary>
    public class LogisticsSchedulingModel
    {
        /// <summary>
        /// 拣料单ID
        /// </summary>
        public string PickMaterialID { get; set; }

        /// <summary>
        /// 拣料单编号
        /// </summary>
        public string PickMaterialNo { get; set; }

        /// <summary>
        /// 目的仓库
        /// </summary>
        public string TargetWareHouse { get; set; }

        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }
        /// <summary>
        /// 工作中心
        /// </summary>
        public string WkCenter_No { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
