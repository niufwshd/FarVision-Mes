﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfSq
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string SqNo { get; set; }
        public int Itm { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string Unit { get; set; }
        public string UnitName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Up { get; set; }
        public decimal? Amtn { get; set; }
        public DateTime? EstDd { get; set; }
        public string Rem { get; set; }
        public string ChkMan { get; set; }
        public string CusNo { get; set; }
        public string CurId { get; set; }
        public decimal? ExcRto { get; set; }
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public int? BilItm { get; set; }
        public string IdxNo { get; set; }
        public decimal? Qty1 { get; set; }
        public decimal? UpQty1 { get; set; }
        public decimal? QtyPo { get; set; }
        public decimal? QtyPoUnsh { get; set; }
        public decimal? QtyQs { get; set; }
        public decimal? QtyQsUnsh { get; set; }
        public int? EstItm { get; set; }
        public string PrdMark { get; set; }
        public string BatNo { get; set; }
        public string Remark { get; set; }
        public decimal? Amt { get; set; }
        public string ComposeIdno { get; set; }
        public string SoNo { get; set; }
        public decimal? QtyId { get; set; }
        public string Wh { get; set; }
        public string IdNo { get; set; }
        public string SupPrdNo { get; set; }
        public int? EstItmSo { get; set; }
        public string SoId { get; set; }
        public string Ischeck { get; set; }
        public string IsSend { get; set; }
        public string Usr { get; set; }
        public decimal? QtyHz { get; set; }
        public decimal? QtyHzUnsh { get; set; }
        public string Dep { get; set; }
        public string MoNo { get; set; }
        public string MoId { get; set; }
        public string LyId { get; set; }
        public string LyNo { get; set; }
        public int? LyItm { get; set; }
        public string PrdNoChg { get; set; }
        public string SupPrdMark { get; set; }
        public string CusOsNo { get; set; }
        public bool? IsSp { get; set; }
        public string MrpNos { get; set; }

        public virtual MfSq MidNavigation { get; set; }
    }
}