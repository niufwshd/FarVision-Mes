﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VStorageBarcodeHistory
 : Entity<int>    {
        public string Masterwarehouseno { get; set; }
        public string Masterwarehousename { get; set; }
        public string Location { get; set; }
        public string LocationName { get; set; }
        public string CustNo { get; set; }
        public string SourceNoForm { get; set; }
        public string ProdNo { get; set; }
        public string ProdName { get; set; }
        public string ProdSpc { get; set; }
        public string ProdSnm { get; set; }
        public string PackageNo { get; set; }
        public decimal? BeginningOfPeriod { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Balance { get; set; }
        public string Unit { get; set; }
        public string Iotype { get; set; }
        public string BatchNo { get; set; }
        public string SourceNo { get; set; }
        public DateTime? TradeDate { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        
        public int? Mid { get; set; }
        public string MaterialBatchNo { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public string SupplierSnm { get; set; }
    }
}