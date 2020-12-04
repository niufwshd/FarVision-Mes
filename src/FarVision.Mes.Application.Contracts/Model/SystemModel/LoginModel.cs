using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.SystemModel
{
    public class LoginModel
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        public IDICLoginModel icidInfo { get; set; }
    }


    public class IDICLoginModel
    {
        public string No { get; set; }
        public string info { get; set; }


    }
}
