using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    /// <summary>
    /// 委外退货erp接口实体
    /// </summary>
    public class SaleReturnGoodsResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_COPI09";

        public List<SaleReturnGoodsResponseHead> Data { get; set; }
    }

    public class SaleReturnGoodsResponseHead
    {
        /// <summary>
        /// erp单别
        /// </summary>
        public string TI001 { get; set; }

        /// <summary>
        /// erp单号
        /// </summary>
        public string TI002 { get; set; }
        /// <summary>
        /// 销退日
        /// </summary>
        public string TI003 { get; set; }
        public string TI004 { get; set; }
        public string TI007 { get; set; }
        public string TI034 { get; set; }
        public string TI035 { get; set; }
        public string TJ003 { get; set; }
        public string TJ004 { get; set; }
        public decimal TJ007 { get; set; }
        public string TJ008 { get; set; }
        public string TJ013 { get; set; }
        public string TJ015 { get; set; }
        public string TJ016 { get; set; }
        public string TJ017 { get; set; }
        public string UDF05 { get; set; }
        public int UDF06 { get; set; }

    }
}
