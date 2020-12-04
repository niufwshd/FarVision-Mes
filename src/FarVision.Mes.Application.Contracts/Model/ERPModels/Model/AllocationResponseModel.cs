using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class AllocationResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_INVI08";

        public List<AllocationResponseHead> Data { get; set; }

    }

    public class AllocationResponseHead
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
        public decimal UDF51 { get; set; }
        public decimal TB007 { get; set; }
        public string TB008 { get; set; }
        public string TB012 { get; set; }
        public string TB013 { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public string TB003 { get; set; }
    }
}
