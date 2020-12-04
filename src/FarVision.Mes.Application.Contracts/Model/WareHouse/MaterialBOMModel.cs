using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 工单物料BOM
    /// </summary>
    public class MaterialBOMModel
    {
      
        /// <summary>
        ///  物料
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// 需求数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        public string ProcessNo { get; set; }

        /// <summary>
        /// 物料拉动提前期
        /// </summary>
        public decimal RequestAdvance { get; set;}

    }
}
