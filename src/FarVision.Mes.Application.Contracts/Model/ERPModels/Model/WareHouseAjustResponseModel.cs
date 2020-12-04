using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class WareHouseAjustResponseModel
    {

        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_INVI05";

        public List<WareHouseAjustResponseHead> Data { get; set; }
    }

    public class WareHouseAjustResponseHead
    {
        public string TA001 { get; set; }
        public string TA002 { get; set; }
        public string TA003 { get; set; }
        public string TA008 { get; set; }
        public string TA014 { get; set; }
        public string TA015 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TB004 { get; set; }
        public decimal TB007 { get; set; }
        public string TB017 { get; set; }
        public string TB008 { get; set; }
        public string TB012 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TB003 { get; set; }

    }
}
