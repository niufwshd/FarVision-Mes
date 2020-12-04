using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMES.DTO.SysData
{
    /// <summary>
    /// 身份模型
    /// </summary>
    public class IdentityDto
    {
        /// <summary>
        /// 获取或设置令牌
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 获取或设置用户
        /// </summary>
        public Sys_UserDTO User { get; set; }
    }
}
