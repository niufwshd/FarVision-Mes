﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QcRecord
 : Entity<int>    {
        public QcRecord()
        {
            QcRecordvalue = new HashSet<QcRecordvalue>();
        }

        
        public string SourceBillNo { get; set; }
        public string SourceType { get; set; }
        public string ZcNo { get; set; }
        public string PrdNo { get; set; }
        public string PrjType { get; set; }
        public string PrjCategory { get; set; }
        public string PfaNo { get; set; }
        public string QcNo { get; set; }
        public string SyNo { get; set; }
        public string GraphNo { get; set; }
        public string FileNo { get; set; }
        public string DepNo { get; set; }
        public string BanNo { get; set; }
        public string SebNo { get; set; }
        public string Barcode { get; set; }
        public Guid? Photo { get; set; }
        public DateTime? SuDate { get; set; }
        public DateTime? QcDate { get; set; }
        public string FurBatNo { get; set; }
        public decimal? FurNumber { get; set; }
        public decimal? QcQty { get; set; }
        public string QcPosition { get; set; }
        public string ImpBy { get; set; }
        public string ImpStd { get; set; }
        public string QcDev { get; set; }
        public string No { get; set; }
        public DateTime BillDate { get; set; }
        public string Rem { get; set; }
        public string BusiNo { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
        public string QcResult { get; set; }
        public string TzNo { get; set; }
        public int? BillStatus { get; set; }
        public int? InspectTc { get; set; }
        public int? QualifiedQty { get; set; }
        public int? UnqualifiedQty { get; set; }
        public int? SamplingRule { get; set; }
        public string Priority { get; set; }
        public string Attachment { get; set; }
        public string BatchNo { get; set; }
        public string SuppCode { get; set; }
        public decimal? Aql { get; set; }
        public decimal? SampleQty { get; set; }
        public decimal? RecordQty { get; set; }
        public int? SchemeId { get; set; }
        public string InspectionType { get; set; }
        public int? RelationId { get; set; }

        public virtual ICollection<QcRecordvalue> QcRecordvalue { get; set; }
    }
}