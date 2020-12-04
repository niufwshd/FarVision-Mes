using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.SysData
{
    public class PasswordModel
    {
        /// <summary>
        /// 原密码
        /// </summary>
        public string OldPassword { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }
    }
}
