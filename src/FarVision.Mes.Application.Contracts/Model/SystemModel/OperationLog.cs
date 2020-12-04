using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace WebMES.Model.SystemModel
{
    [Table("SYS_OperationLog")]
    public class OperationLog
    {
        #region 实体成员
        /// <summary>
        /// 唯一编号
        /// </summary>
        /// <returns></returns>
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string MenuCode { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        /// <returns></returns>
        public string IP { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        /// <returns></returns>
        public string UserID { get; set; }

        /// <summary>
        /// Url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 请求信息
        /// </summary>
        /// <returns></returns>
        public string RequestInfo { get; set; }

        /// <summary>
        /// 响应信息
        /// </summary>
        /// <returns></returns>
        public string ResponseInfo { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        /// <returns></returns>
        public DateTime CreateDate { get; set; }

        #endregion
    }
}
