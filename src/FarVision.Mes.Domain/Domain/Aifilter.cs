﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Aifilter
 : Entity<int>    {
        public string BillNo { get; set; }
        public string SourceBillNo { get; set; }
        public string BillStatus { get; set; }
        public string SuppCode { get; set; }
        public string DeptNo { get; set; }
        public string InspectorId { get; set; }
        public string ProductionNo { get; set; }
        public string ProductionName { get; set; }
        public string Spc { get; set; }
        public string Snm { get; set; }
        public string StorageLocation { get; set; }
        public decimal? QtyChk { get; set; }
        public decimal? QtyChkOk { get; set; }
        public decimal? QtyChkLost { get; set; }
        public string BatchNo { get; set; }
        public string SpcNo { get; set; }
        public string PrcId { get; set; }
        public DateTime? InspectionDate { get; set; }
        public decimal? QtyRtn { get; set; }
        public decimal? QtyOkRtn { get; set; }
        public decimal? QtyLostRtn { get; set; }
        
        public string BusiNo { get; set; }
        public int? WhId { get; set; }
        public string ViewDetail { get; set; }
        public string SuppName { get; set; }
        public int? SubId { get; set; }
    }
}