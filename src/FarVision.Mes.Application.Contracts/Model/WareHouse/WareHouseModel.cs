using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 仓库
    /// </summary>
    public class WareHouseModel
    {


        public string ID { get; set; }
        /// <summary>
        /// 仓库编号
        /// </summary>
        public string WAREHOUSENO { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WAREHOUSENAME { get; set; }
        /// <summary>
        /// 仓库上层编号
        /// </summary>
        public string UP { get; set; }
        /// <summary>
        /// 仓库类型
        /// </summary>
        public string WAREHOUSETYPE { get; set; }
        /// <summary>
        /// 工厂编号
        /// </summary>
        public string FACTORYCODE { get; set; }
        /// <summary>
        /// 是否入库批次管理
        /// </summary>
        public string ISENTERBATCH { get; set; }
        /// <summary>
        /// 是否FIFO（先进先出）
        /// </summary>
        public string ISFIFO { get; set; }
        /// <summary>
        /// 是否单件管理
        /// </summary>
        public string ISSN { get; set; }
        /// <summary>
        /// 是否需要上下架管理
        /// </summary>
        public string ISWM { get; set; }
        /// <summary>
        /// 长
        /// </summary>
        public string LONG { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public string WIDTH { get; set; }
        /// <summary>
        /// 高
        /// </summary>
        public string HEIGHT { get; set; }
        /// <summary>
        /// 承重
        /// </summary>
        public string BEARING { get; set; }
        /// <summary>
        /// 所属客户
        /// </summary>
        public string CUSTOMER { get; set; }

        /// <summary>
        /// 所属供应商
        /// </summary>
        public string SUPPLIER { get; set; }
        /// <summary>
        /// 主仓库编号
        /// </summary>
        public string MasterWareHouseNO { get; set; }
        //待检区
        public string InspectArea { get; set; }


        /// <summary>
        /// 出库待检区
        /// </summary>
        public string ShipmentInspectArea { get; set; }

        //可疑品仓
        public string IsSuspected { get; set; }
        //线边仓
        public string IsWaste { get; set; }
        //待检区
        public string IsLine { get; set; }

        //是否启用上架指导规则
        public string IsOnShelfGuideRule { get; set; }

        /// <summary>
        /// 物料暂存库位（临时库位）
        /// </summary>
        public string TempLocation { get; set; }


        /// <summary>
        /// 是否来料待检区
        /// </summary>
        public string IsInspectArea { get; set; }

        /// <summary>
        /// 是否生产领料仓
        /// </summary>
        public string IsProductionFeeding { get; set; }

        /// <summary>
        /// 是否出货仓库
        /// </summary>
        public string IsShipmentWareHouse { get; set; }

        /// <summary>
        /// 领料优先级
        /// </summary>
        public string FeedPriority { get; set; }

        public string IsMakeAnInventory { get; set; }





    }
}
