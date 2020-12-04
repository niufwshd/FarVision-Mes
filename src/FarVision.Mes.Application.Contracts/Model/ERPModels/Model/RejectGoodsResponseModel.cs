using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class RejectGoodsResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_PURI11";

        public List<RejectGoodsResponseHead> Data { get; set; }
    }

    public class RejectGoodsResponseHead
    {
        public string TI001 { get; set; }

        public string TI002 { get; set; }
        public string TI004 { get; set; }
        public string TI014 { get; set; }
        public string TI003 { get; set; }
        public string TI026 { get; set; }
        public string TI005 { get; set; }
        public string TI012 { get; set; }
        public string TJ016 { get; set; }
        public string TJ017 { get; set; }
        public string TJ018 { get; set; }
        public string TJ011 { get; set; }
        public string TJ004 { get; set; }
        public string TJ012 { get; set; }
        public decimal TJ009 { get; set; }
        public string TJ007 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }


        /// <summary>
        /// 序号
        /// </summary>
        public string TJ003 { get; set; }
    }
}
