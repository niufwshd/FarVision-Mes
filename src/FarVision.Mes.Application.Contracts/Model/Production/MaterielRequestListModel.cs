using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Production
{
    /// <summary>
    ///  安灯叫料清单
    /// </summary>
    public class MaterielRequestListModel
    {
        /// <summary>
        /// 工单
        /// </summary>
        public string TZ_NO { get; set; }

        /// <summary>
        /// 工作中心
        /// </summary>
        public string WkCenter_No { get; set; }

        /// <summary>
        /// 总成型号
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        /// 零件型号
        /// </summary>
        public string CST_PRD { get; set; }

        /// <summary>
        /// 需求数
        /// </summary>
        public decimal PlanQuantity { get; set; }

        /// <summary>
        /// 叫料原因（生产缺料/换型）
        /// </summary>
        public string Call_Cause { get; set; }

        /// <summary>
        /// 状态（缺料中、已完成、已取消） 
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 创建人 
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateUser { get; set; }
    }
}
