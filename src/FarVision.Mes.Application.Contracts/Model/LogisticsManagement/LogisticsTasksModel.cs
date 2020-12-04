using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.LogisticsManagement
{
    [Serializable]
    [DataContract]
    /// <summary>
    /// 物流任务单
    /// </summary>
    public class LogisticsTasksModel
    {

        [DataMember]
        public string ID { get; set; }


        [DataMember]

        /// <summary>
        /// 物流任务单号
        /// </summary>
        public string No { get; set; }
        [DataMember]

        /// <summary>
        /// 单号规则编号
        /// </summary>
        public string RuleCode { get; set; }
        [DataMember]

        /// <summary>
        ///运送起点
        /// </summary>
        public string StartingPoint { get; set; }
        [DataMember]

        /// <summary>
        /// 运送目的地
        /// </summary>
        public string EndPoint { get; set; }
        [DataMember]

        /// <summary>
        ///最晚送达时间
        /// </summary>
        public DateTime DeadlineDate { get; set; }
        [DataMember]

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        [DataMember]

        /// <summary>
        /// 任务分配时间
        /// </summary>
        public DateTime DistributionDate { get; set; }
        [DataMember]

        /// <summary>
        /// 承运人
        /// </summary>
        public string CarrierUSER { get; set; }
        [DataMember]

        /// <summary>
        ///完成时间
        /// </summary>
        public DateTime FinishDate { get; set; }
        [DataMember]


        /// <summary>
        /// 完成人
        /// </summary>
        public string FinishUSER { get; set; }
        [DataMember]


        /// <summary>
        /// 运送类别
        /// </summary>
        public string ShippingCategory { get; set; }
        [DataMember]

        /// <summary>
        /// 最低车型要求
        /// </summary>
        public string VehicleRequirements { get; set; }

        [DataMember]
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        [DataMember]
        /// <summary>
        /// 生产顺序
        /// </summary>
        public int ProductionOrder { get; set; }

        [DataMember]
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        [DataMember]

        /// <summary>
        /// 单据子表 （任务明细）
        /// </summary>
        public List<LogisticsTasksItemModel> LogisticsTasksItemList { get; set; }
    }

    /// <summary>
    /// 物流任务明细
    /// </summary>
    public class LogisticsTasksItemModel
    {
        public string ID { get; set; }

        public string MID { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_No { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_Name { get; set; }

        /// <summary>
        /// 产品规格
        /// </summary>
        public string PROD_SPC { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_No { get; set; }

        /// <summary>
        /// 来源库位
        /// </summary>
        public string SourceLocation { get; set; }

        /// <summary>
        /// 来源库位名称
        /// </summary>
        public string SourceLocationName { get; set; }

        /// <summary>
        /// 送达库位
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public int Source_ID { get; set; }


        /// <summary>
        /// 来源单类型
        /// </summary>
        public string Source_Type { get; set; }
        /// <summary>
        /// 批次号
        /// </summary>
        public string Batch_No { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 计划运送数量
        /// </summary>
        public decimal PlanQuantity { get; set; }

        /// <summary>
        /// 完成数量
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }


        /// <summary>
        ///最晚送达时间
        /// </summary>
        public DateTime DeadlineDate { get; set; }

        /// <summary>
        /// 送达扫描条码集合
        /// </summary>
        public List<LogisticsTasksBarcode> Barcodes { get; set; }


    }
    /// <summary>
    /// 物流任务送达扫描的条码实体
    /// </summary>
    public class LogisticsTasksBarcode
    {
        public string ID { get; set; }
        public string MID { get; set; }
        public string PackageNo { get; set; }

        public string Prod_No { get; set; }

        public decimal Quantity { get; set; }

        public string SourceLocation { get; set; }

        public string Location { get; set; }

        public string Batch_No { get; set; }

        public string ProductionDate { get; set; }

        public string Status { get; set; }
    }
}
