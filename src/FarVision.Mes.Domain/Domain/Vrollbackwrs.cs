﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Vrollbackwrs
 : Entity<int>    {
        public long? Idx { get; set; }
        public string Barcode { get; set; }
        public int? Mid { get; set; }
        public int? Itm { get; set; }
        public string Unit { get; set; }
        public string BilId { get; set; }
        
        public string BilNo { get; set; }
        public DateTime? BilDd { get; set; }
        public string BanNo { get; set; }
        public string TzNo { get; set; }
        public string PrdNo { get; set; }
        public string YgNo { get; set; }
        public string ZcNo { get; set; }
        public string BanGroupNo { get; set; }
        public string SebNo { get; set; }
        public string PrdName { get; set; }
        public string ZcName { get; set; }
        public string SebName { get; set; }
        public string IdNo { get; set; }
        public string PrdSpc { get; set; }
        public bool? ChkNum { get; set; }
        public string BilNoG { get; set; }
        public decimal? Qty { get; set; }
        public decimal? QtyLost { get; set; }
        public decimal? QtyScrap { get; set; }
    }
}