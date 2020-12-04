using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{

    /// <summary>
    /// 库存存储 当前仓库所在库存 -仓库维度
    /// </summary>
    public class InventoryStorageModel
    {
        /// <summary>
        /// 仓库
        /// </summary>
        public string WareHouseNo { get; set; }
        /// <summary>
        /// 产品
        /// </summary>
        public string Prod_No { get; set; }


        public decimal Quantity { get; set; }

        public string Unit { get; set; }

        public decimal FrozenQuantity { get; set; }

        //条码库存
        public List<InventoryBarcodeStorageModel> BarcodeStorageList { get; set; }
    }
    /// <summary>
    /// 库存条码存储 
    /// </summary>
    public class InventoryBarcodeStorageModel
    {

        /// <summary>
        /// 库位
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 品号
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        ///  品名
        /// </summary>
        public string Prod_Name { get; set; }


        /// <summary>
        /// 包装、条码
        /// </summary>
        public string PackageNo { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }


    
    }






}
