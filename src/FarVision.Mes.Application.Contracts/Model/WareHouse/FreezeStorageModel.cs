using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 冻结库存实体
    /// </summary>
    public class FreezeStorageModel
    {
        /// <summary>
        /// 库存ID
        /// </summary>
        public string ID { get; set; }

        public string MID { get; set; }

        public string WareHouseNo { get; set; }

        public string WareHouseName { get; set; }


        public string PROD_NO { get; set;}

        public string PROD_NAME { get; set; }


        public string PROD_SNM { get; set; }
       
        public string PROD_SPC { get; set; }


        public string PackageNo { get; set; }

        public string BATCH_NO { get; set; }

        public decimal Quantity { get; set; }

        public decimal ActualQuantity { get; set;}
        public decimal FreezeQuantity { get; set; }

        public string FreezeTime { get; set; }


        public string LiftTime { get; set; }


        public string FreezeReason { get; set; }


        public string UNIT { get; set; }


        public string Status { get; set; }

        public string Usr { get; set; }

        public string UsrName { get; set; }


    }
}
