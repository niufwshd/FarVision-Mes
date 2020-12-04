using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    public class PackageChangeModel
    {
        /// <summary>
        /// 源箱
        /// </summary>
        public string SourcePackageNo { get; set; }
        
        /// <summary>
        /// 目的箱
        /// </summary>
        public string TargetPackageNo { get; set; }


        /// <summary>
        /// 单件序列号
        /// </summary>
        public string ProductSn { get; set; }


        /// <summary>
        /// 变更类型(10装入，20移出，30翻包装)
        /// </summary>
        public string ChangeType { get; set; }


        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

    }
}
