﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MdmBomdetail
 : Entity<int>    {
        public string Seq { get; set; }
        public string MaterialNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? ParentBaseQty { get; set; }
        public string MeasuringUnit { get; set; }
        public string MeasuringUnitName { get; set; }
        public string FeedingMode { get; set; }
        public string StorageLocation { get; set; }
        public string StorageLocationCode { get; set; }
        public string VirtualId { get; set; }
        public string Remark { get; set; }
        public string IsEffective { get; set; }
        public string EffectiveDate { get; set; }
        public string ExpirationDate { get; set; }
        
        public int Mid { get; set; }
        public string IsDelete { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}