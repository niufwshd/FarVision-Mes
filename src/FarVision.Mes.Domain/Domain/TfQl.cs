﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfQl
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string QlId { get; set; }
        public string QlNo { get; set; }
        public int Itm { get; set; }
        public DateTime? QlDd { get; set; }
        public string QlType { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdMark { get; set; }
        public string Unit { get; set; }
        public string Wh { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Cst { get; set; }
        public string BatNo { get; set; }
        public string MoNo { get; set; }
        public string TzNo { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public string CpySw { get; set; }
        public decimal? CstStd { get; set; }
        public string PrdNoChg { get; set; }
        public string IdNo { get; set; }
        public string PrdNoMo { get; set; }
        public decimal? QtyRtn { get; set; }
        public decimal? QtyRtnUnsh { get; set; }
        public decimal? Qty1Rtn { get; set; }
        public decimal? QtyRk { get; set; }
        public decimal? Qty1Rk { get; set; }
        public decimal? QtyLq { get; set; }
        public decimal? QtyDiff { get; set; }
        public string CnttNo { get; set; }
        public int? PreItm { get; set; }
        public int? EstItm { get; set; }
        public string UseinNo { get; set; }
        public decimal? LosRto { get; set; }
        public decimal? QtyStd { get; set; }
        public string ZcPrd { get; set; }
        public decimal? QtyLeft { get; set; }
        public string ChgRto { get; set; }
        public int? ChgItm { get; set; }
        public decimal? QtyChgRto { get; set; }
        public string ZcNo { get; set; }
        public string Rem { get; set; }
        public int? PrtNum { get; set; }
        public decimal? QtyQl { get; set; }
        public decimal? UpStd { get; set; }
        public string Dep { get; set; }
        public string Reason { get; set; }
        public decimal? QtyQlRtn { get; set; }
        public decimal? QtyRsv { get; set; }
        public decimal? QtyLost { get; set; }

        public virtual MfQl MidNavigation { get; set; }
    }
}