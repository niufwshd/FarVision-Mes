﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Actualpara
 : Entity<int>    {
        public string ParaNo { get; set; }
        public string ParaName { get; set; }
        public decimal? LowLimit { get; set; }
        public decimal? UpLimit { get; set; }
        public string Para { get; set; }
        public int? Rn { get; set; }
    }
}