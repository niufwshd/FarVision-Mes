﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SbRunRecordInfo
 : Entity<int>    {
        
        public int Mid { get; set; }
        public int Itm { get; set; }
        public string PartNo { get; set; }
        public string BilNo { get; set; }
        public string OrdNo { get; set; }
        public string OilsName { get; set; }
        public string Content { get; set; }
        public string Standard { get; set; }
        public decimal? StandardAddAmount { get; set; }
        public decimal? ActualAddAmount { get; set; }
        public string Method { get; set; }
        public Guid? SpecImage { get; set; }
    }
}