using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class InoutWareHouseResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_INVI11";

        public List<InoutWareHouseResponseHead> Data { get; set; }

    }

    public class InoutWareHouseResponseHead
    {
        public string TF001 { get; set; }

        public string TF002 { get; set; }
        public string TF003 { get; set; }
        public string TF004 { get; set; }
        public string TF005 { get; set; }
        public string TF008 { get; set; }
        public string TF009 { get; set; }
        public string TF011 { get; set; }

        public string TF012 { get; set; }

        public string TF013 { get; set; }
        public string TF024 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TG004 { get; set; }
        public decimal UDF51 { get; set; }
        public decimal TG009 { get; set; }
        public string TG010 { get; set; }
        public string TG007 { get; set; }
        public string TG008 { get; set; }
        public string TG014 { get; set; }
        public string TG015 { get; set; }
        public string TG016 { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string TG003 { get; set; }

    }
}

