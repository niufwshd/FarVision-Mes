﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VStorageDull
 : Entity<int>    {
        
        public string WareHouseNo { get; set; }
        public string WareHouseName { get; set; }
        public string ProdNo { get; set; }
        public string ProdName { get; set; }
        public string ProdSnm { get; set; }
        public string ProdSpc { get; set; }
        public string Unit { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? LateStorageDate { get; set; }
        public int? PutInDull { get; set; }
        public DateTime? LateDeliveryDate { get; set; }
        public int? OutDull { get; set; }
        public decimal? Quantity { get; set; }
    }
}