﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SbRecord
 : Entity<int>    {
        public long Id { get; set; }
        public string SebNo { get; set; }
        public string No { get; set; }
        public string Value { get; set; }
        public DateTime? SysDate { get; set; }
        public int? Itm { get; set; }
        public string Type { get; set; }
        public string Barcode { get; set; }
        public string Inputdate { get; set; }
        public string Minlimit { get; set; }
        public string Maxlimit { get; set; }
        public string CastingBatchNo { get; set; }
        public string StoveNo { get; set; }
    }
}