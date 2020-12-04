using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.WareHouse;

namespace WebMES.Model.UNModels.Model.RequestModels
{
    /// <summary>
    /// 供应商主数据
    /// </summary>
    public class WM_ASNModel
    {
        public BaseModel HEAD { get; set; }
        public ASNModel ITEM { get; set; }
    }

    /// <summary>
    /// BOM主数据
    /// </summary>
    public class ASNModel
    {

        public ASNHead HeadData { get; set; }

        public List<Item> ItemData { get; set; }

        //public List<BOMItem> ChildData { get; set; }

    }

    /// <summary>
    /// 头
    /// </summary>
    public class ASNHead : BaseModel
    {
        [Description("到货单号")]
        public string AsnCode { get; set; }

        [Description("供应商代码")]
        public string SupplierCode { get; set; }

        [Description("送货日期")]
        public string DeliveryDate { get; set; }


        [Description("送货单类型")]
        public string AsnType { get; set; }

        [Description("处理标识")]
        public string Flag { get; set; }

    }

    ///<summary>
    ///
    /// </summary>         
    public class Item
    {

        public string AsnItem { get; set; }
        public string MaterialCode { get; set; }
        public string OrderNo { get; set; } //订单号
        public string OrderItem { get; set; } //订单行
        public string POCode { get; set; } //采购单号
        public string POItem { get; set; } //采购行项目
        public string LocationPoint { get; set; } //入库仓库
        public string Quantity { get; set; } //送货数量
        public string Unit { get; set; } //送货单位
        public string BatchNo { get; set; } //生产批次
        public string MaterialBatchNo { get; set; } //材料批次
        public string ProductionDate { get; set; } //生产日期

        public string TransferType { get; set; } //移库类型
        public string Flag { get; set; } //标识

        public List<Package> Packages = new List<Package>();

    }

    public class Package
    {
        public string PackNo { get; set; } //箱号
        public string PackId { get; set; } //顺序码
        public string MaterialCode { get; set; } //物料编码
        public string Quantity { get; set; } //数量
        public string Unit { get; set; } //单位
        public string ParentNo { get; set; } //外层包装
        public string PalletNo { get; set; } //托盘号
        public string FLAG { get; set; } //标识

    }
}
