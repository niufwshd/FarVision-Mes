using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.SysData
{
    [Serializable]
    public class BusiValueInfoDto
    {
        public string busiNo { get; set; }

        public string valueField { get; set; }

        public string nameField { get; set; }

        public string value { get; set; }

        public string condition { get; set; }

    }

    public class BusiValueNameMapDto
    {
        public string busiNo { get; set; }

        public string value { get; set; }
        public string name { get; set; }
    }
}
