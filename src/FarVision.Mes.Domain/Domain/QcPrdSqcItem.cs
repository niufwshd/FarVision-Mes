﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QcPrdSqcItem
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string QcItm { get; set; }
        public int QcModel { get; set; }
        public string QcEnumBusiNo { get; set; }
        public string QcSpc { get; set; }
        public string QcMth { get; set; }
        public string QcStandard { get; set; }
        public string QcTools { get; set; }
        public int Itm { get; set; }
        public string LowSybol { get; set; }
        public decimal? StandardValue { get; set; }
        public decimal? NumMin { get; set; }
        public string UpSybol { get; set; }
        public decimal? NumMax { get; set; }
        public decimal? NumMinIn { get; set; }
        public decimal? NumMaxIn { get; set; }
        public string SampLevel { get; set; }
        public decimal? QtyAqlcr { get; set; }
        public decimal? QtyAqlmaj { get; set; }
        public decimal? QtyAqlmin { get; set; }
        public string ErfFile { get; set; }
        public string Rem { get; set; }
        public string Unit { get; set; }
        public string UpDesignTolerance { get; set; }
        public string LowDesignTolerance { get; set; }
        public string LowDesignScope { get; set; }
        public string UpDesignScope { get; set; }
        public string LowTechScope { get; set; }
        public string UpTechScope { get; set; }
        public string ParameterType { get; set; }
        public string FrequencyType { get; set; }
        public int? Frequency { get; set; }
        public int? ItemId { get; set; }
    }
}