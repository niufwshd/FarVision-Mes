﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QmInspectBill
 : Entity<int>    {
        public QmInspectBill()
        {
            QmInspectS = new HashSet<QmInspectS>();
        }

        
        /// <summary>
        /// 检验计划ID
        /// </summary>
        public int? Pid { get; set; }
        /// <summary>
        /// 检验单模板ID
        /// </summary>
        public int? Tid { get; set; }
        /// <summary>
        /// 检验单据号
        /// </summary>
        public string BillNo { get; set; }
        /// <summary>
        /// 工序代码
        /// </summary>
        public string ProcedureCode { get; set; }
        public string BanNo { get; set; }
        /// <summary>
        /// 送检人
        /// </summary>
        public string InspectUser { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string BillStatus { get; set; }
        public string Result { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Usr { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime SysDate { get; set; }
        /// <summary>
        /// 样本送检时间
        /// </summary>
        public DateTime? InspectDate { get; set; }
        public DateTime? PlanDate { get; set; }
        /// <summary>
        /// 送检数量
        /// </summary>
        public decimal? InspectNum { get; set; }
        public string ManualSubmitUser { get; set; }
        public DateTime? ManualsubmitTime { get; set; }
        public DateTime? SamplingTime { get; set; }
        public int? BillType { get; set; }
        public string SourceBillNo { get; set; }
        public string Dept { get; set; }
        public string SuppCode { get; set; }
        public int? InspectTc { get; set; }
        public string Comment { get; set; }
        public string SourceType { get; set; }
        public string InspectionMode { get; set; }
        public string Attachment { get; set; }

        public virtual ICollection<QmInspectS> QmInspectS { get; set; }
    }
}