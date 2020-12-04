using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Production
{
    [Serializable]
    public class DefectList
    {
        public DefectList()
        {
            defectQty = 1;
        }
        public string defectNo { get; set; }

        public string defectName { get; set; }

        /// <summary>
        /// 1-可疑,2-报废,3-返修
        /// </summary>
        public string defectType { get; set; }

        public int defectQty { get; set; }

        public string defectProcess { get; set; }
    }
}
