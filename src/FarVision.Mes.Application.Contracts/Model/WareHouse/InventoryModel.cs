using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{

    /// <summary>
    /// 盘点计划实体
    /// </summary>
    public class InventoryModel
    {
        public string ID { get; set; }
        /// <summary>
        /// 单号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string WareHouse { get; set; }


        public string WareHouseName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }


        public string StatusName { get; set; }
        /// <summary>
        /// 盘点方式  仓库、仓库+产品
        /// </summary>
        public string InventoryWay { get; set; }

        public string InventoryWayName { get; set; }
        /// <summary>
        ///  产品
        /// </summary>
        public string Prod_NO { get; set; }


        public string Prod_Name { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 行项目
        /// </summary>
        public List<InventoryItemModel> ItemList { get; set; }
    }
    /// <summary>
    /// 盘点计划行项目
    /// </summary>
    public class InventoryItemModel
    {
        public string ID { get; set; }

        public string MID { get; set; }

        /// <summary>
        /// 品号
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        ///  品名
        /// </summary>
        public string Prod_Name { get; set; }

        /// <summary>
        /// 账务数量
        /// </summary>
        public decimal AccountQuantity { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        public decimal ActualQuantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }


        /// <summary>
        /// 盘盈数量
        /// </summary>
        public decimal MuchQuantity { get; set; }

        /// <summary>
        /// 盘亏数量
        /// </summary>
        public decimal LackQuantity { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string Remark { get; set; }
     
        /// <summary>
        /// 条码
        /// </summary>
        public List<InventoryBarcodeModel> BarcodeList { get; set; }


    }
    /// <summary>
    /// 盘点计划条码
    /// </summary>
    public class InventoryBarcodeModel
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string ID { get; set; }



        public string MID { get; set; }

        /// <summary>
        /// 主仓库编号
        /// </summary>
        public string MasterWareHouseNo { get; set; }


        /// <summary>
        /// 条码
        /// </summary>
        public string PackageNo { get; set; }


        /// <summary>
        /// 品号
        /// </summary>
        public string Prod_No { get; set; }
        /// <summary>
        /// 品名
        /// </summary>

        public string Prod_Name { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }
        
        /// <summary>
        /// 目标地点
        /// </summary>
        public string Location { get; set; }


        public string LocationName { get; set; }

        /// <summary>
        ///  数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        public decimal ActualQuantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        public string StatusName { get; set;}

    }





}
