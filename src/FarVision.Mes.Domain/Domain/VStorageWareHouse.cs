﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VStorageWareHouse
 : Entity<int>    {
        public long? Id { get; set; }
        public string WareHouseNo { get; set; }
        public string WarehouseName { get; set; }
        public string MasterWareHouseNo { get; set; }
    }
}