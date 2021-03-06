﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VPackageAndStorage
 : Entity<int>    {
        
        public string No { get; set; }
        public string ParentPackageId { get; set; }
        public string EnterFormDetailId { get; set; }
        public string Material { get; set; }
        public decimal? Quantity { get; set; }
        public string Unit { get; set; }
        public bool? IsLock { get; set; }
        public string PackageType { get; set; }
        public bool? IsSnp { get; set; }
        public decimal? Capacity { get; set; }
        public string ProBatchNo { get; set; }
        public DateTime? SbProductionDate { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public decimal? Sort { get; set; }
        public string Storage { get; set; }
        public string AsnItemId { get; set; }
        public bool? IsUnfinishedProduct { get; set; }
        public string LockFormNo { get; set; }
        public string TransferFormItem { get; set; }
        public string Rem { get; set; }
        public string BusiNo { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
        public int? SbId { get; set; }
        public string Location { get; set; }
        public string LocationName { get; set; }
        public decimal? SbQuantity { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string SourceNo { get; set; }
        public string Name { get; set; }
        public string Spc { get; set; }
        public string Snm { get; set; }
        public string MasterWareHouseNo { get; set; }
        public string MasterWareHouseName { get; set; }
        public string WareHouseType { get; set; }
        public string StorageType { get; set; }
        public decimal LockQuantity { get; set; }
        public decimal FreezeQuantity { get; set; }
    }
}