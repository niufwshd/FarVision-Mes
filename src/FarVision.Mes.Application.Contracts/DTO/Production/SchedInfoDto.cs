using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Production
{
    [Serializable]
    public class SchedInfoDto
    {
        public DateTime day { get; set; }

        public int value { get; set; }

        public bool isRelease { get; set; }
    }
}
