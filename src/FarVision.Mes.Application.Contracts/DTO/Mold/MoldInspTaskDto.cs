using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Mold
{
    public class MoldInspTaskDto
    {

        //检验方案代号

        public string programNo { get; set; }


        /// <summary>
        /// 执行人
        /// </summary>
        public string userExce { get; set; }

        /// <summary>
        /// 执行人所在部门
        /// </summary>

        public string userDept { get; set; }
    }
}
