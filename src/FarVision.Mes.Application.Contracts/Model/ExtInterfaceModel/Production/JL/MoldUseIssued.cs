using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ExtInterfaceModel.Production.JL
{
    /// <summary>
    ///当前使用模具下发
    /// </summary>
    public class MoldUseIssued
    {
        public MoldUseIssued()
        {
            CreateTime = DateTime.Now;
            Flag = "true";
        }
        /// <summary>
        /// 记录惟一标识号
        /// </summary>
       // public string ID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string Dev_No { get; set; }
        /// <summary>
        /// sheb简称
        /// </summary>
        public string ABB_No { get; set; }
        /// <summary>
        /// 模号
        /// </summary>
        public string Mould_No { get; set; }
        /// <summary>
        /// 新数据标记，下发时设为true
        /// </summary>
        public string Flag { get; set; }

    }
}
