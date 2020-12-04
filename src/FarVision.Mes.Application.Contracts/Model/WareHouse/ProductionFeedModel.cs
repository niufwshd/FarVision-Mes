using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    /// <summary>
    /// 投料实体
    /// </summary>
    public class ProductionFeedModel
    {
        /// <summary>
        /// 条码
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        ///  是否批次校验
        /// </summary>
        public bool BatchCheck { get; set; }

        /// <summary>
        /// 品号
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        /// 母件品号
        /// </summary>
        public string MProd_No { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 主包装 （限条码是单件条码时，master 为包装号）
        /// </summary>
        public string Master { get; set; }

        /// <summary>
        ///  条码类型  Barcode - 单件条码 Package 包装
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 来源  库位 （线边库）
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 目的  工位
        /// </summary>
        public string WorkPosition { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        public string ZC_NO { get; set; }

        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        ///任务单
        /// </summary>
        public string MO_NO { get; set; }

        /// <summary>
        /// 计划单
        /// </summary>
        public string PLAN_NO { get; set; }

        /// <summary>
        ///  生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        /// <summary>
        /// 领料模式(0:逐批领料，1：自动扣料，2：倒冲领料)
        /// </summary>
        public string FeedType { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        public string materialType { get; set; }

        /// <summary>
        /// 产生追溯码
        /// </summary>
        public bool IsGenerateTraceBarcode { get; set; }

        /// <summary>
        /// BOM标准用量
        /// </summary>
        public decimal Dosage { get; set; }

        /// <summary>
        /// 追溯码
        /// </summary>
        public string TraceNo { get; set; }


        /// <summary>
        /// 班次
        /// </summary>
        public string ShiftNo { get; set; }
    }
}
