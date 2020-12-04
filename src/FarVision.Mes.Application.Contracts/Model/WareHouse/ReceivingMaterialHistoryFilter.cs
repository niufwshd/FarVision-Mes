using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 收料历史查询条件
    /// </summary>
    public class ReceivingMaterialHistoryFilter
    {
        public string WO_NO { get; set; }

        public string MPROD_NO { get; set; }

        public string MPROD_SPC { get; set; }


        public string BATCH_NO { get; set; }

        public string beginDate { get; set; }

        public string endDate { get; set; }

        public string TargetWareHouse { get; set; }


        public string PROD_NO { get;set; }

        public string PROD_SPC { get; set; }


    }
}
