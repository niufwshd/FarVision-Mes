﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VRptTemplet
 : Entity<int>    {
        
        public string No { get; set; }
        public string BusiNo { get; set; }
        public string BusiKind { get; set; }
        public string Name { get; set; }
        public byte[] ViewData { get; set; }
        public int? IsDefault { get; set; }
        public string Memo { get; set; }
        public string Userno { get; set; }
        public DateTime InputDate { get; set; }
        public int? Flag { get; set; }
        public string IsSystem { get; set; }
    }
}