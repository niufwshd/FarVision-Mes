﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysBarcodeRule
 : Entity<int>    {
        public string RuleId { get; set; }
        public int? RuleOrder { get; set; }
        public string CombiId { get; set; }
        public string CombiType { get; set; }
        public int? CombiOrder { get; set; }
        public string ItemType { get; set; }
        public string FixChar { get; set; }
        public int? ItemLen { get; set; }
        public string Format { get; set; }
        public string Align { get; set; }
        public string CoverChar { get; set; }
        public string UpdateTime { get; set; }
    }
}