using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    //工序bom属性实体
    public class ProcessBomAttributeModel
    {
        /// <summary>
        /// 领料模式(0:逐批领料，1：自动扣料，2：倒冲领料)
        /// </summary>
        public string FeedType { get; set;}
        /// <summary>
        /// 物料类型
        /// </summary>
        public string materialType { get; set; }

        /// <summary>
        /// 是否产生追溯码
        /// </summary>
        public bool IsGenerateTraceBarcode { get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        public decimal Qty { get; set; }
    }
}
