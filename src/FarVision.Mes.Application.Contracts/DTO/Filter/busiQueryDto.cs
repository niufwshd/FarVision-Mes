using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Filter
{
    [Serializable]
    public class busiQueryDto
    {
        public string key { get; set; }
        public string busiNo { get; set; } 
        public string filter { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public  filterConidtions filterConditions { get; set; }
    }
}
