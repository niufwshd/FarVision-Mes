﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfCk
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string CkId { get; set; }
        public string CkNo { get; set; }
        public int Itm { get; set; }
        public DateTime? CkDd { get; set; }
        public string Wh { get; set; }
        public string BatNo { get; set; }
        public string OsId { get; set; }
        public string OsNo { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdMark { get; set; }
        public string Unit { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? CstnSal { get; set; }
        public decimal? Up { get; set; }
        public decimal? AmtnNet { get; set; }
        public decimal? Amt { get; set; }
        public decimal? Tax { get; set; }
        public decimal? DisCnt { get; set; }
        public DateTime? ValidDd { get; set; }
        public string Rem { get; set; }
        public DateTime? EstDd { get; set; }
        public decimal? TaxRto { get; set; }
        public decimal? CstStd { get; set; }
        public decimal? UpQty1 { get; set; }
        public int? EstItm { get; set; }
        public decimal? QtyPs { get; set; }
        public decimal? QtyPsUnsh { get; set; }
        public string IdNo { get; set; }
        public string FreeId { get; set; }
        public decimal? QtyRk { get; set; }
        public decimal? QtyRkUnsh { get; set; }
        public decimal? AmtFp { get; set; }
        public decimal? AmtnNetFp { get; set; }
        public decimal? TaxFp { get; set; }
        public string PriceId { get; set; }
        public int? OthItm { get; set; }
        public string PakUnit { get; set; }
        public decimal? PakExc { get; set; }
        public decimal? PakNw { get; set; }
        public string PakWeightUnit { get; set; }
        public decimal? PakGw { get; set; }
        public decimal? PakMeast { get; set; }
        public string PakMeastUnit { get; set; }
        public int? PreItm { get; set; }
        public string ZhangId { get; set; }
        public string ChkTax { get; set; }
        public string SupPrdNo { get; set; }
        public string ComposeIdno { get; set; }
        public string CusOsNo { get; set; }
        public string Rem2 { get; set; }
        public decimal? QtyFp { get; set; }
        public string FhNo { get; set; }
        public decimal? QtyArk { get; set; }
        public decimal? QtyPre { get; set; }
        public decimal? QtyPreUnsh { get; set; }
        public decimal? Qty1Pre { get; set; }
        public decimal? Qty1PreUnsh { get; set; }
        public DateTime? RkDd { get; set; }
        public string DepRk { get; set; }
        public int? PwItm { get; set; }
        public string CnttNo { get; set; }
        public string BzKnd { get; set; }
        public string WhSend { get; set; }
        public decimal? AmtDisCnt { get; set; }
        public string FreeIdDef { get; set; }
        public decimal? UpStd { get; set; }
        public string SupPrdMark { get; set; }
        public decimal? Qty1Fp { get; set; }
        public string CfId { get; set; }
        public int? TtRng { get; set; }
        public string TtTypeIfrs { get; set; }
        public DateTime? TtYmE { get; set; }
        public decimal? QtyOs { get; set; }
        public string XpmNo { get; set; }
        public string XpmNo1 { get; set; }
        public int? XpprdItm { get; set; }
        public int? XpprdItm1 { get; set; }
        public string YhNo { get; set; }
        public int? YhItm { get; set; }
        public string PrmNo { get; set; }
        public string MaiNo { get; set; }

        public virtual MfCk MidNavigation { get; set; }
    }
}