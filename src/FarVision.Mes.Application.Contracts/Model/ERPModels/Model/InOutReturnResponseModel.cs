using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class InOutReturnResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_INVI12";

        public List<InOutReturnResponseHead> Data { get; set; }
    }

    public class InOutReturnResponseHead
    {
        public string TH001 { get; set; }

        public string TH002 { get; set; }
        public string TH003 { get; set; }
        public string TH004 { get; set; }
        public string TH005 { get; set; }
        public string TH008 { get; set; }
        public string TH009 { get; set; }
        public string TH011 { get; set; }
        public string TH023 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TI004 { get; set; }
        public decimal UDF51 { get; set; }
        public decimal TI009 { get; set; }
        public string TI010 { get; set; }
        public string TI007 { get; set; }
        public string TI008 { get; set; }
        public string TI014 { get; set; }
        public string TI015 { get; set; }
        public string TI016 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TI003 { get; set; }

    }
}
