using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Trace
{
    /// <summary>
    /// 数采数据模型
    /// </summary>
    public class ProcessParametes
    { 
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceNo { get; set; }

        /// <summary>
        /// 追溯码
        /// </summary>
        public string TraceCode { get; set; }

        /// <summary>
        /// 数采参数
        /// </summary>
        public Dictionary<string, object> ParametObjs { get; set; }
    }
}
