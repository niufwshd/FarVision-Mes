using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Production
{
    /// <summary>
    /// 创建工单的主要信息
    /// </summary>
    public class OrderModel
    {
        public string zcNo {get;set;}
        public string prdNo { get; set; }
        public string idNo { get; set; }
        public string moNo { get; set; }
        public string jhNo { get; set; }
        public int jhqty { get; set; }
        public string unit { get; set; }
        public string dep { get; set; }
        public string banNo { get; set; }

        public string batNo { get; set; }

        public string mdNo { get; set; }
        public string yzjNo { get; set; }
        public int mtItm { get; set; }
        public DateTime tzDD { get; set; }
    }
}
