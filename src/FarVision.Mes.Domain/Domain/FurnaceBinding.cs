﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class FurnaceBinding
 : Entity<int>    {
        
        public string BatNo { get; set; }
        public string GpbatNo { get; set; }
        public string SebNo { get; set; }
        public string ZcNo { get; set; }
        public string BanNo { get; set; }
        public string Usr { get; set; }
        public DateTime Sysdate { get; set; }
        public string Updusr { get; set; }
        public DateTime? Upddate { get; set; }
        public string InspectionResult { get; set; }
    }
}