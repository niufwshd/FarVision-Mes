﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmWareHouseProduct
 : Entity<int>    {
        
        public string ProductCode { get; set; }
        public string WareHouseCode { get; set; }
        public decimal? MinQuantity { get; set; }
        public decimal? MaxQuantity { get; set; }
        public decimal? MinRequestQuantity { get; set; }
        public bool? Isdelete { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool? IsBarcodeMng { get; set; }
        public bool? IsBatchMng { get; set; }
        public bool? IsPieceMng { get; set; }
        public bool? IsForcedOffShelves { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string Usr { get; set; }
        public bool? IsOnly { get; set; }
        public decimal? InventoryReplenishment { get; set; }
    }
}