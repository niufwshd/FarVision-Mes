using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.WareHouse;

namespace WebMES.Model.UNModels.Model.RequestModels
{



    public class OutSoucingModel
    {


        public BaseModel Head { get; set; }
        public List<OutSoucingItem> Items { get; set; }

    }

    /// <summary>
    /// 头
    /// </summary>
    public class OutSoucingItem
    {
        [Description("转移单号")]
        public string No { get; set; }

        [Description("工单号")]
        public string WorkorderNo { get; set; }

        [Description("品号")]
        public string PartNo { get; set; }

        [Description("数量")]
        public decimal Quantity { get; set; }


        [Description("单位")]
        public string Unit { get; set; }

        [Description("来源")]
        public string From { get; set; }

        [Description("目标")]
        public string To { get; set; }

        [Description("转移类型")]
        public string Type { get; set; }

        [Description("备注")]
        public string Remark { get; set; }
        [Description("生产批次")]
        public string BatchNo { get; set; } //生产批次
        [Description("材料批次")]
        public string MaterialBatchNo { get; set; } //材料批次
        [Description("生产日期")]
        public string ProductionDate { get; set; } //生产日期

        //[Description("物料来源工单")]
        //public string MaterialSourceWorkorderNo { get; set; } //物料来源工单

        [Description("处理标识")]
        public string Flag { get; set; }

        public List<WM_OutSoucingPackage> Packages = new List<WM_OutSoucingPackage>();

    }

    ///<summary>
    ///
    /// </summary>       


    public class WM_OutSoucingPackage
    {
        public string PackNo { get; set; } //箱号
        public string PartNo { get; set; } //品号

        public string Quantity { get; set; } //数量
        public string Unit { get; set; } //单位

        public string BatchNo { get; set; } //生产批次
        public string MaterialBatchNo { get; set; } //材料批次
        public string ProductionDate { get; set; } //生产日期

        public string FLAG { get; set; } //标识

    }
}
