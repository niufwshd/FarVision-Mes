﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Qcinterfacerecordd
 : Entity<int>    {
        public string BatNo { get; set; }
        public DateTime? BillTime { get; set; }
        public DateTime? ChkDate { get; set; }
        public int? ChkTemplate { get; set; }
        public string ChkUser { get; set; }
        public int? DepId { get; set; }
        public DateTime? DInputDate { get; set; }
        
        public byte? IFlag { get; set; }
        public byte? IsPrint { get; set; }
        public string LockUser { get; set; }
        public int? Mid { get; set; }
        public int? PrdId { get; set; }
        public DateTime? PrintDate { get; set; }
        public string PrintUser { get; set; }
        public int? Qty { get; set; }
        public int? QtyLost { get; set; }
        public int? QtyOk { get; set; }
        public string Rem { get; set; }
        public int? Sort { get; set; }
        public string SUserId { get; set; }
    }
}