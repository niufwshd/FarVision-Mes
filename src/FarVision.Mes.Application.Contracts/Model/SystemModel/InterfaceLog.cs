using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace WebMES.Model.SystemModel
{
    [Table("SYS_InterfaceLog")]
    public class InterfaceLog
    {
        #region 实体成员
        /// <summary>
        /// 唯一编号
        /// </summary>
        /// <returns></returns>
        public Guid ID { get; set; }

        /// <summary>
        /// 接口编号
        /// </summary>
        /// <returns></returns>
        public string InterfaceCode { get; set; }

        /// <summary>
        /// 请求IP
        /// </summary>
        /// <returns></returns>
        public string RequestIP { get; set; }

        /// <summary>
        /// 请求信息
        /// </summary>
        /// <returns></returns>
        public string RequestInfo { get; set; }

        /// <summary>
        /// 响应IP
        /// </summary>
        /// <returns></returns>
        public string ResponseIP { get; set; }

        /// <summary>
        /// 响应信息
        /// </summary>
        /// <returns></returns>
        public string ResponseInfo { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <returns></returns>
        public bool Success { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        /// <returns></returns>
        public DateTime CreateDate { get; set; }

        #endregion
    }
}
