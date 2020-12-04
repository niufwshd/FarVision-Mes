using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class RejectMaterialResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_MOCI04";

        public List<RejectMaterialResponseHead> Data { get; set; }

    }

    public class RejectMaterialResponseHead
    {
        public string TC001 { get; set; }

        public string TC002 { get; set; }
        public string TC003 { get; set; }
        public string TC004 { get; set; }
        public string TC005 { get; set; }
        public string TC006 { get; set; }
        public string TC014 { get; set; }
        public string TC015 { get; set; }
        public string TD005 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TE011 { get; set; }
        public string TE012 { get; set; }
        public string TE004 { get; set; }
        public decimal TE005 { get; set; }
        public string TE006 { get; set; }
        public string TE008 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TE003 { get; set; }

    }
}
