﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SebWr
 : Entity<int>    {
        
        public string SebNo { get; set; }
        public int? Itm { get; set; }
        public DateTime WorkDd { get; set; }
        public DateTime? TimeBeg { get; set; }
        public DateTime? TimeEnd { get; set; }
        public decimal? QtyTimeCnt { get; set; }
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
    }
}