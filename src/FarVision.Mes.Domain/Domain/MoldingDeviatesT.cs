﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MoldingDeviatesT
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string SebNo { get; set; }
        public string ParaNo { get; set; }
        public decimal ParaValue { get; set; }
        public string ParaName { get; set; }
        public DateTime? DevTime { get; set; }

        public virtual MoldingDeviateT MidNavigation { get; set; }
    }
}