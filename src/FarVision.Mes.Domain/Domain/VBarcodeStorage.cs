﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VBarcodeStorage
 : Entity<int>    {
        public string PackageNo { get; set; }
        public string ProdNo { get; set; }
        public decimal? Quantity { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Master { get; set; }
        public string BatchNo { get; set; }
        public string MasterWareHouseNo { get; set; }
        public DateTime? ProductionDate { get; set; }
    }
}