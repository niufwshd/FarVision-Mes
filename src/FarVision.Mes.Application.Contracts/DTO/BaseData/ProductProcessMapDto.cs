using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.BaseData
{
    [Serializable]
    public class ProductProcessMapDto
    {
        public string ID { get; set; }
        public string Proc_No { get; set; }

        public string Ver_No { get; set; }
        public string Prod_No { get; set; }

        public string bomNo { get; set; }
    }
}
