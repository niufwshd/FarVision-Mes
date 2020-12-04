using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.WareHouse;

namespace WebMES.Model.UNModels.Model.RequestModels
{



    public class WM_QueryStorageModel
    {


        public BaseModel Head { get; set; }
        public QueryStorageItem ITEMS { get; set; }

    }

    /// <summary>
    /// 头
    /// </summary>
    public class QueryStorageItem
    {
        public string Supplier { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialSpc { get; set; }

    }

    public class StorageRespModel
    {
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string MaterialSpc { get; set; }
        public string LotNo { get; set; }
        public string Quantity { get; set; }

        public string Unit { get; set; }


        public string SupplierCode { get; set; }

        public string SupplierName { get; set; }

        public string ErrorText { get; set; }



    }



}
