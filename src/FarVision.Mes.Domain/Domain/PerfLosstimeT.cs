﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PerfLosstimeT
 : Entity<int>    {
        
        public DateTime SysDate { get; set; }
        public string BanNo { get; set; }
        public string BanGroup { get; set; }
        public string Workshop { get; set; }
        public string ZcNo { get; set; }
        public string SebNo { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public int? Losstime { get; set; }
        public string Lossreason { get; set; }
        public string Losstype { get; set; }
        public string Lossproperty { get; set; }
        public int? Handletype { get; set; }
        public string Workshopname { get; set; }
        public int? Hgs { get; set; }
        public int? Bhgs { get; set; }
        public int? Fps { get; set; }
        public string Fpworkshop { get; set; }
        public int? Bcjfgs { get; set; }
        public int? Fbcjfgs { get; set; }
        public string Fgworkshop { get; set; }
        public DateTime? Createtime { get; set; }
        public string Fgcjname { get; set; }
        public string Zcname { get; set; }
        public string Sebname { get; set; }
        public string Spec { get; set; }
        public string ModNo { get; set; }
        public DateTime? StaDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SourceId { get; set; }
    }
}