﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VZcdefect
 : Entity<int>    {
        public string TzNo { get; set; }
        public string MrpNo { get; set; }
        public string ModNo { get; set; }
        public string ZcNo { get; set; }
        public string SebNo { get; set; }
        public DateTime? WrDd { get; set; }
        public decimal? QtyFin { get; set; }
        public decimal? QtyScrap { get; set; }
        public decimal? QtyLost { get; set; }
        public decimal Qty { get; set; }
        public DateTime? TzDd { get; set; }
        public int? Id { get; set; }
        public string MoNo { get; set; }
        public DateTime? OpnDd { get; set; }
    }
}