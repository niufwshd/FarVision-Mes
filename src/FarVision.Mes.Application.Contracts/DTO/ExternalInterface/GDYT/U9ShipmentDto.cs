using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.ExternalInterface.GDYT
{
    public class U9ShipmentDto
    {
        /// <summary>
        /// 组织
        /// </summary>
        public string org { get; set; }

        /// <summary>
        /// 物料号
        /// </summary>

        public string materialNo { get; set; }


        /// <summary>
        /// 存放仓库
        /// </summary>
        public string whseNo { get; set; }

        /// <summary>
        /// 出货数量
        /// </summary>
        public decimal qty { get; set; }


        /// <summary>
        /// 批次号
        /// </summary>
        public string batchNo { get; set; }
    }
}
