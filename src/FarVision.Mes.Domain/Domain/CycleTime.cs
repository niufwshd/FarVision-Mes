﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class CycleTime
 : Entity<int>    {
        
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string SebNo { get; set; }
        public string SebName { get; set; }
        public string ZcNo { get; set; }
        public string ZcName { get; set; }
        public decimal? CycleTime1 { get; set; }
        public string CtUnit { get; set; }
        public int? Qty { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
        public string Model { get; set; }
    }
}