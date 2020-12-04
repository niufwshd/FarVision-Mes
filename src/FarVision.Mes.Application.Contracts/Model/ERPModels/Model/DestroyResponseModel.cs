using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class DestroyResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_INVI24";

        public List<DestroyResponseHead> Data { get; set; }
    }

    /// <summary>
    /// 销毁单
    /// </summary>
    public class DestroyResponseHead
    {
        public string TN001 { get; set; }
        public string TN002 { get; set; }
        public string TN003 { get; set; }
        public string TN004 { get; set; }
        public string TN005 { get; set; }
        public string TN006 { get; set; }
        public string TN007 { get; set; }
        public string TN008 { get; set; }
        public string TN013 { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public string TO003 { get; set; }
        public string TO004 { get; set; }
        public decimal TO007 { get; set; }
        public string TO008 { get; set; }
        public string TO009 { get; set; }
        public string TO010 { get; set; }
        public string TO011 { get; set; }
        public string TO015 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }


    }
}
