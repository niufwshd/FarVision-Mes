using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace WebMES.Model.SystemModel
{
    [Table("SYS_AlarmLog")]
    public class AlarmLog
    {
        #region 实体成员
        /// <summary>
        /// 唯一编号
        /// </summary>
        /// <returns></returns>
        public Guid ID { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        /// <returns></returns>
        public string IP { get; set; }

        /// <summary>
        /// 模块
        /// </summary>
        /// <returns></returns>
        public string Module { get; set; }

        /// <summary>
        /// 操作信息
        /// </summary>
        /// <returns></returns>
        public string OperationInfo { get; set; }

        /// <summary>
        /// 报警信息
        /// </summary>
        /// <returns></returns>
        public string AlarmInfo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        /// <returns></returns>
        public string UserID { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        /// <returns></returns>
        public DateTime CreateDate { get; set; }

        #endregion

    }
}
