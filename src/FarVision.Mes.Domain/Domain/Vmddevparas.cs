﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Vmddevparas
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string Itm { get; set; }
        public string ParaNo { get; set; }
        public string ParaName { get; set; }
        public string Ut { get; set; }
        public string Lowsybol { get; set; }
        public decimal? LowLimit { get; set; }
        public string Upsybol { get; set; }
        public decimal? UpLimit { get; set; }
        public string Ptype { get; set; }
        public string Manner { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string SebNo { get; set; }
        public string SebName { get; set; }
        public string CoolMode { get; set; }
        public string ModNo { get; set; }
    }
}