﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class Vml
 : Entity<int>    {
        public int Mlid { get; set; }
        public string SebNo { get; set; }
        public string ZcNo { get; set; }
        public string RlTz { get; set; }
        public int? Tid { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string Unit { get; set; }
        public string BatNo { get; set; }
        public decimal? Qty { get; set; }
    }
}