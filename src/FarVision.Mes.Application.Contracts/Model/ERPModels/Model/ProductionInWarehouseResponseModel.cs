using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.ERPModels.Model
{
    public class ProductionInWarehouseResponseModel
    {
        public string STD_IN_Origin { get; set; }

        public string Service_Name { get; set; }

        public string User { get; set; }
        public string Factory { get; set; }

        public string Operate { get; set; } = "ADJUST";

        public string ObjectID { get; set; } = "SET_MOCI05";

        public List<ProductionInWarehouseResponseHead> Data { get; set; }
    }

    public class ProductionInWarehouseResponseHead
    {
        public string TF001 { get; set; }

        public string TF002 { get; set; }
        public string TF003 { get; set; }
        public string TF004 { get; set; }
        public string TF011 { get; set; }
        public string TF012 { get; set; }
        public string TF013 { get; set; }
        public string TG004 { get; set; }
        public decimal TG011 { get; set; }
        public decimal TG013 { get; set; }
        public string TG010 { get; set; }
        public string TG007 { get; set; }
        public string UDF05 { get; set; }
        public string UDF06 { get; set; }
        public string TG014 { get; set; }
        public string TG015 { get; set; }
        public string TG003 { get; set; }

    }
}
