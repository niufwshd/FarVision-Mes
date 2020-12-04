using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 投料查询条件
    /// </summary>
    public class FeedingFilter
    {
        //工序号
        public string ProcessNo { get; set; }
        //品号
        public string Prod_No { get; set; }
        //工单
        public string WO_NO { get; set; }
        //开始日期
        public string StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public string EndDate { get; set; }
    }
}
