﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SbParaRecord
 : Entity<int>    {
        
        public string No { get; set; }
        public string PaNo { get; set; }
        public string PaName { get; set; }
        public string SebNo { get; set; }
        public string SebName { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string BatNo { get; set; }
        public string TzNo { get; set; }
        public string ParaNo { get; set; }
        public string ParaName { get; set; }
        public string ParaValue { get; set; }
        public string Ptype { get; set; }
        public string Ut { get; set; }
        public decimal? UpLimit { get; set; }
        public decimal? LowLimit { get; set; }
        public string LowSybol { get; set; }
        public string UpSybol { get; set; }
        public decimal? Standard { get; set; }
        public string Rem { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public DateTime? UpdDate { get; set; }
        public bool? IsPrint { get; set; }
        public string ZcNo { get; set; }
        public string MoNo { get; set; }
        public string BanNo { get; set; }
        public int? ClId { get; set; }
        public string ClTb { get; set; }
    }
}