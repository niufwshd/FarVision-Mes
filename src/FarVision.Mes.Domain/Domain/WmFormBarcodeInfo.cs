﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmFormBarcodeInfo
 : Entity<int>    {
        
        public int? Mid { get; set; }
        public string ProdNo { get; set; }
        public string BatchNo { get; set; }
        public string PackageNo { get; set; }
        public decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string SourceLocation { get; set; }
        public decimal? ReturnQuantity { get; set; }
        public string MaterialBatchNo { get; set; }

        public virtual WmFormItem MidNavigation { get; set; }
    }
}