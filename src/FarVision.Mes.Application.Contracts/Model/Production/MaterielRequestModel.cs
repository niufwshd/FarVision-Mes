using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Production
{
    /// <summary>
    /// 物料拉动请求
    /// </summary>
    public class MaterielRequestModel
    {
        /// <summary>
        /// 工位
        /// </summary>
        public string Station_No { get; set; }

        /// <summary>
        /// 工作中心
        /// </summary>
        public string Wk_Center_No { get; set; }
        
        /// <summary>
        /// 工序
        /// </summary>
        public string Process_No { get; set; }

        /// <summary>
        /// 物料
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        /// 需求数量
        /// </summary>
        public decimal PlanQuantity { get; set; }

        /// <summary>
        /// 请求数量
        /// </summary>
        public decimal RequestQuantity { get; set; }

        /// <summary>
        /// 发货数量
        /// </summary>
        public decimal SendQuantity { get; set; }

        /// <summary>
        /// 收货数量
        /// </summary>
        public decimal ReceiveQuantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 目标仓库
        /// </summary>
        public string TargetWH { get; set; }

        /// <summary>
        /// 来源仓库
        /// </summary>
        public string SourceWH { get; set; }

        /// <summary>
        /// 来源单号（物料对应工单）
        /// </summary>
        public string SourceNo { get; set; }

        /// <summary>
        /// 移库单号（组单后生成移库单）
        /// </summary>
        public string TransferNo { get; set; }
        
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime RequestDate { get; set; }

        /// <summary>
        /// 最晚送达时间
        /// </summary>
        public DateTime LatestDate { get; set; }

        /// <summary>
        /// 是否拉动计划
        /// </summary>
        public bool IsPlan { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 是否呼叫
        /// </summary>
        public bool IsCall { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public string Supplier { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreateUser { get; set; }
        
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 物料请求类型（催料，补料）
        /// </summary>
        public string Type { get; set; }

        
    }
}
