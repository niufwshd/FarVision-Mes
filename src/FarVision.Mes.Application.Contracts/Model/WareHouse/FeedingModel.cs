using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    //投料实体
    public class FeedingModel
    {
        /// <summary>
        /// 工序
        /// </summary>
        public string Process { get; set; }
        /// <summary>
        /// 工位
        /// </summary>
        public string WorkStation { get; set; }
        /// <summary>
        /// 投料数量
        /// </summary>
        public decimal Quantity { get; set; }


        /// <summary>
        /// 完成数量
        /// </summary>
        public decimal FinishQuantity { get; set; }

        /// <summary>
        /// 退料数量
        /// </summary>
        public decimal ReturnQuantity { get; set; }

        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        /// <summary>
        /// 任务单
        /// </summary>
        public string MO_NO { get; set; }
        /// <summary>
        /// 计划单
        /// </summary>
        public string PLAN_NO { get; set; }
        /// <summary>
        /// 母件产品
        /// </summary>
        public string MPROD_NO { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        public string PROD_NO { get; set; }
        /// <summary>
        /// 包装
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
        /// 进出标识
        /// </summary>
        public string IOType { get; set; }
        /// <summary>
        /// 追溯码
        /// </summary>
        public string TraceNo { get; set; }

        /// <summary>
        /// 领料模式(0:逐批领料，1：自动扣料，2：倒冲领料)
        /// </summary>
        public string FeedType { get; set;}


        /// <summary>
        /// 物料类型
        /// </summary>
        public string materialType { get; set; }


        public bool IsGenerateTraceBarcode { get; set; }


        public decimal Dosage { get; set;}

        public string ShiftNo { get; set; }

        /// <summary>
        /// 投料时间
        /// </summary>
        public DateTime FeedDate { get; set; }
    }
}
