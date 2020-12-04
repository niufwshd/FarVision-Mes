using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.ExternalInterface.Production.JL
{
    [Serializable]
    public class PLMFileDto
    {
        public int DocID { get; set; }

        public string DocName { get; set; }

        public string DocPath { get; set; }
        public string DocNo { get; set; }
        /// <summary>
        /// 文件类型，分别用CPT、GYKP、QXT、CZZDS来表示文件是产品图、工艺卡片、缺陷图、操作指导书
        /// </summary>
        public string JL_TYPE { get; set; }

        public string MD5 { get; set; }

        public bool isLoading { get; set; }

    }
}
