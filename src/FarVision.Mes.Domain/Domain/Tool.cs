﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Tool
 : Entity<int>    {
        
        public string Toolno { get; set; }
        public string Toolname { get; set; }
        public DateTime Stratdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Tooltype { get; set; }
        public decimal? Toollife { get; set; }
        public decimal? ToolUseNum { get; set; }
        public string Usr { get; set; }
        public string InspectionUnit { get; set; }
        public string InspectionSpec { get; set; }
    }
}