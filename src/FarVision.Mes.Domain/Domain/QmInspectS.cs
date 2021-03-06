﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QmInspectS
 : Entity<int>    {
        public QmInspectS()
        {
            QmSioBci = new HashSet<QmSioBci>();
        }

        
        public int Mid { get; set; }
        /// <summary>
        /// 样本号
        /// </summary>
        public string SampleNo { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceNo { get; set; }
        public string InspectDevice { get; set; }
        /// <summary>
        /// 产品编码
        /// </summary>
        public string ProductNo { get; set; }
        public string InspectType { get; set; }
        /// <summary>
        /// 是否合格
        /// </summary>
        public string Result { get; set; }
        public string TraceNo { get; set; }
        public string TzNo { get; set; }
        public string AdvanceSampleNo { get; set; }
        public string DeptNo { get; set; }
        public decimal? ReworkQty { get; set; }
        public decimal? AcceptOnDeviationQty { get; set; }
        public decimal? ReturnQty { get; set; }
        public decimal? QualifiedQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public string BatchNo { get; set; }
        public string RawMaterialBatch { get; set; }
        public DateTime? ProducedDate { get; set; }
        public bool? IsSample { get; set; }
        public string SourceBillNo { get; set; }
        public int? EnterFormItemId { get; set; }
        public DateTime? Inspectdate { get; set; }
        public decimal? InspectQty { get; set; }
        public string HandlingSuggestion { get; set; }
        public string SourceLocation { get; set; }
        public string TargetWareHouse { get; set; }
        public decimal? ReturnedQty { get; set; }
        public decimal? TfedQty { get; set; }
        public string Comment { get; set; }
        public decimal? ScrapedQty { get; set; }
        public decimal? ReceiveQty { get; set; }
        public decimal? ScrapQtySupp { get; set; }
        public decimal? UndisposedQty { get; set; }

        public virtual QmInspectBill MidNavigation { get; set; }
        public virtual ICollection<QmSioBci> QmSioBci { get; set; }
    }
}