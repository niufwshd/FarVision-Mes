using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ExtInterfaceModel.Production.JL
{
    /// <summary>
    /// 数据下发标记表
    /// </summary>
    public class IssuedUpdateInfoModel
    {
        /// <summary>
        /// 记录惟一标识号
        /// </summary>
       // public string ID { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime RQSJ { get; set; }
        /// <summary>
        /// 工单下发标记
        /// </summary>
        public string WorkOrder { get; set; }
        /// <summary>
        /// 模具信息下发标记
        /// </summary>
        public string MouldInfo { get; set; }

    }
}
