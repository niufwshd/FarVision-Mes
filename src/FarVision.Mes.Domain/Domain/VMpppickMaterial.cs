﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VMpppickMaterial
 : Entity<int>    {
        public int? Mid { get; set; }
        public string PickMaterialNo { get; set; }
        public string WoNo { get; set; }
        public string WkCenterNo { get; set; }
        public string WkCenterName { get; set; }
        public DateTime? StartDate { get; set; }
        public int? WorkOrder { get; set; }
        public string ProdNo { get; set; }
        public string ProdName { get; set; }
        public string ProdSpc { get; set; }
        public decimal? PlanQuantity { get; set; }
        public decimal? ConfirmQuantity { get; set; }
        public string SourceWareHouse { get; set; }
        public string SourceWareHouseName { get; set; }
        public string TargetWareHouse { get; set; }
        public string TargetWareHouseName { get; set; }
    }
}