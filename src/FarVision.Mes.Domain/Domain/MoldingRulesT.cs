﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MoldingRulesT
 : Entity<int>    {
        
        public string ParaNo { get; set; }
        public string SebNo { get; set; }
        public string Ptype { get; set; }
        public string PrdNo { get; set; }
        public decimal? UpLimit { get; set; }
        public decimal? LowLimit { get; set; }
        public string DevType { get; set; }
        public decimal Threshold { get; set; }
        public string DevUnit { get; set; }
        public DateTime Sysdate { get; set; }
        public DateTime? Upddate { get; set; }
        public string Usr { get; set; }
        public string ParaName { get; set; }
        public string Lowsybol { get; set; }
        public string Upsybol { get; set; }
        public string ParaUnit { get; set; }
        public string CoolMode { get; set; }
        public string ModNo { get; set; }
        public string PrdType { get; set; }
    }
}