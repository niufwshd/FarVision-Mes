using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 响应状态
    /// </summary>
    public class ResponseModel
    {

        public string Status { get; set; }

        public decimal Quantity { get; set; }

        /// <summary>
        /// 单据编号
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 库存类型
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// 目标仓库
        /// </summary>
        public string TargetWareHouse { get; set; }

        /// <summary>
        /// 目标仓库名称
        /// </summary>
        public string TargetWareHouseName { get; set; }


        /// <summary>
        /// 产品编号
        /// </summary>
        public string PROD_NO { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string PROD_NAME { get; set; }
        /// <summary>
        /// 产品规格
        /// </summary>
        public string PROD_SPC { get; set; }







    }


}
