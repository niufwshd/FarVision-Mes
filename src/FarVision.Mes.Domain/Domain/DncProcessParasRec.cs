﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class DncProcessParasRec
 : Entity<int>    {
        
        public string SebNo { get; set; }
        public DateTime? Createtime { get; set; }
        public string Machinemode { get; set; }
        public string Machinestatus { get; set; }
        public int? Powerontime { get; set; }
        public int? Runningtime { get; set; }
        public int? Cuttingtime { get; set; }
        public int? Processedcount { get; set; }
        public string Spindleload { get; set; }
        public string Spindlespeed { get; set; }
        public string Feedspeed { get; set; }
        public decimal? Spindleoverride { get; set; }
        public decimal? Feedoverride { get; set; }
        public string Alarmno { get; set; }
        public string Alarmmessage { get; set; }
        public string Toolnum { get; set; }
        public decimal? Xload { get; set; }
        public decimal? Yload { get; set; }
        public decimal? Zload { get; set; }
    }
}