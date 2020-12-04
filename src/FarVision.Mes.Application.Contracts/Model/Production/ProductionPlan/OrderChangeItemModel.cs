using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Production.ProductionPlan
{
    public class OrderChangeItemModel
    {
        public decimal Qty { get; set; }

        public string WorkCenterNo { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public string ProdNo { get; set; }

        /// <summary>
        /// 生产顺序
        /// </summary>
        public decimal WorkOrder { get; set; }

        /// <summary>
        /// 紧急程度
        /// </summary>
        public string AddInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public string WoType { get; set; }

        public string ShiftNo { get; set; }

        public string VerNo { get; set; }

        public string SrcNo { get; set; }

    }
}
