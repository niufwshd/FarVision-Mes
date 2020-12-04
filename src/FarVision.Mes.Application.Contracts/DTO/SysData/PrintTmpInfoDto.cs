using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.SysData
{
    /// <summary>
    /// 打印模板
    /// </summary>
    [Serializable]
    public class PrintTmpInfoDto
    {

        public string TmpNo { get; set; }
        public List<string> IDList { get; set; }
    }
}
