﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TrayBarcodebinding
 : Entity<int>    {
        
        public string BarcodeNoCpx { get; set; }
        public string BarcodeNoLzx { get; set; }
        public string Usr { get; set; }
        public DateTime? SysDate { get; set; }
        public decimal? Qty { get; set; }
    }
}