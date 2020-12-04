using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    //修改包装filter
    public class UpdatePackageFilter
    {
        /// <summary>
        /// 包装
        /// </summary>
       public string PackageNo { get; set; }

        /// <summary>
        ///  产品
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        ///  生成批次
        /// </summary>
        public string Batch_No { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal  Quantity { get; set; }

        /// <summary>
        /// 增减标识（+，-）
        /// </summary>
        public string Type { get; set; }

    }
}
