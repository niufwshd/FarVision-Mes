﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfCs
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string CsNo { get; set; }
        public int Itm { get; set; }
        public string ChgId { get; set; }
        public string SoNoOld { get; set; }
        public string MoNo { get; set; }
        public string MrpNo { get; set; }
        public string Unit { get; set; }
        public decimal? QtySo { get; set; }
        public decimal? QtyFin { get; set; }
        public string SoNo { get; set; }
        public decimal? Qty { get; set; }
        public string CusNoOld { get; set; }
        public string CusNo { get; set; }
        public DateTime? EstDdOld { get; set; }
        public DateTime? EstDd { get; set; }
        public string Rem { get; set; }
        public int? EstItmOld { get; set; }
        public int? EstItm { get; set; }
        public string TwId { get; set; }
        public string ComposeIdno { get; set; }
        public string PrdMark { get; set; }
        public string DepOld { get; set; }
        public string Dep { get; set; }
        public DateTime? StaDdOld { get; set; }
        public DateTime? StaDd { get; set; }
        public DateTime? EndDdOld { get; set; }
        public DateTime? EndDd { get; set; }
        public string CasNoOld { get; set; }
        public string CasNo { get; set; }
        public int? TaskIdOld { get; set; }
        public int? TaskId { get; set; }
        public decimal? Up { get; set; }
        public decimal? UpOld { get; set; }
        public string Reason { get; set; }
        public int? PreItm { get; set; }
        public string BilId { get; set; }
        public string CurId { get; set; }
        public string CurIdOld { get; set; }
        public decimal? RtoTax { get; set; }
        public decimal? RtoTaxOld { get; set; }
        public string RemMo { get; set; }
        public string RemMoOld { get; set; }
        public string TaxId { get; set; }
        public string TaxIdOld { get; set; }
        public string Wh { get; set; }
        public string WhOld { get; set; }
        public string BilIdOld { get; set; }
        public string BilNoOld { get; set; }
        public string ZcNo { get; set; }
        public string DepUp { get; set; }
        public string DepDown { get; set; }
        public string CusUp { get; set; }
        public string CusDown { get; set; }
        public string ZcNoUp { get; set; }
        public string ZcNoDn { get; set; }
        public string MdNo { get; set; }
        public string SebNo { get; set; }
        public string SebNoOld { get; set; }
        public string BatNo { get; set; }
        public string MoNoAdd { get; set; }
        public string CusOsNo { get; set; }
        public string CusOsNoOld { get; set; }
        public DateTime? BillDate { get; set; }
        public string BilType { get; set; }
        public decimal? UsedTime { get; set; }
        public decimal? TimeCnt { get; set; }
        public string QcYn { get; set; }
        public string ZcRem { get; set; }
        public string BatNoOld { get; set; }
        public string BatNoNew { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Qty1So { get; set; }
        public DateTime? FinDd { get; set; }
        public string AddInfo { get; set; }
        public string AddInfoOld { get; set; }
        public string WkCenterNo { get; set; }
        public string WkCenterNoOld { get; set; }
        public int? WorkOrder { get; set; }
        public int? WorkOrderOld { get; set; }

        public virtual MfCs MidNavigation { get; set; }
    }
}