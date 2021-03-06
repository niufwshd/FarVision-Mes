﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfTi
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string RBusiNo { get; set; }
        public int? RMid { get; set; }
        public int? RSid { get; set; }
        public string TiNo { get; set; }
        public int Itm { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdMark { get; set; }
        public string Wh { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public string PrjType { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public string BatNo { get; set; }
        public string ChkResult { get; set; }
        public string Rem { get; set; }
        public decimal? QtyRtn { get; set; }
        public decimal? QtyRtnUnsh { get; set; }
        public bool? CpySw { get; set; }
        public int? EstItm { get; set; }
        public decimal? QtyRk { get; set; }
        public string IdNo { get; set; }
        public string ZcNo { get; set; }
        public string CusNo { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? Qty1Rtn { get; set; }
        public decimal? Qty1RtnUnsh { get; set; }
        public bool? FreeId { get; set; }
        public int? CkItm { get; set; }
        public string SupPrdNo { get; set; }
        public string ComposeIdno { get; set; }
        public DateTime? BDd { get; set; }
        public DateTime? EDd { get; set; }
        public string SlNo { get; set; }
        public string MmNo { get; set; }
        public string CusOsNo { get; set; }
        public DateTime? ValidDd { get; set; }
        public int? PreItm { get; set; }
        public string ShNoCus { get; set; }
        public decimal? QtyPs { get; set; }
        public decimal? QtyPsUnsh { get; set; }
        public string CasNo { get; set; }
        public int? TaskId { get; set; }
        public decimal? UsedTime { get; set; }
        public int? SlItm { get; set; }
        public string GfNo { get; set; }
        public decimal? QtyCus { get; set; }
        public DateTime? RkDd { get; set; }
        public string DepRk { get; set; }
        public bool ChktyId { get; set; }
        public string CnttNo { get; set; }
        public DateTime? ProduDd { get; set; }
        public decimal? QtyRck { get; set; }
        public decimal? QtyRckUnsh { get; set; }
        public string TrdId { get; set; }
        public string TrdNo { get; set; }
        public bool? NewmatFlag { get; set; }
        public bool? XrfQcflag { get; set; }
        public bool? XrfSample { get; set; }
        public string SupPrdMark { get; set; }
        public string FxNo { get; set; }
        public string FxName { get; set; }
        public string FxKnd { get; set; }
        public string FxSpc { get; set; }
        public string FxUnit { get; set; }
        public string YhNo { get; set; }
        public bool? IsSp { get; set; }
        public string BarCode { get; set; }

        public virtual MfTi MidNavigation { get; set; }
    }
}