using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    /// <summary>
    /// 委外退货erp接口实体
    /// </summary>
    public class SaleSendGoodsResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_COPI08";

        public List<SaleSendGoodsResponseHead> Data { get; set; }
    }

    public class SaleSendGoodsResponseHead
    {
        public string TG001 { get; set; }
        public string TG002 { get; set; }
        public string TG003 { get; set; }
        public string TG006 { get; set; }
        public string TG004 { get; set; }
        public string TG010 { get; set; }
        public string TG042 { get; set; }
        public string TH004 { get; set; }
        public decimal UDF62 { get; set; }
        public decimal TH008 { get; set; }
        public string TH007 { get; set; }
        public string TH009 { get; set; }
        public string TH014 { get; set; }
        public string TH015 { get; set; }
        public string TH016 { get; set; }
        public string TH032 { get; set; }
        public string TH033 { get; set; }
        public string TH034 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TH003 { get; set; }
    }
}
