﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmFreezeStorageHistory
 : Entity<int>    {
        public string BatchNo { get; set; }
        public decimal? FreezeQuantity { get; set; }
        public string FreezeReason { get; set; }
        
        public int? Mid { get; set; }
        public string PackageNo { get; set; }
        public string ProdNo { get; set; }
        public string Status { get; set; }
        public DateTime? SysDate { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string WareHouseNo { get; set; }

        public virtual WmFreezeStorage MidNavigation { get; set; }
    }
}