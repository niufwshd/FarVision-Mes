﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VWmformPackage
 : Entity<int>    {
        
        public string ProdNo { get; set; }
        public string No { get; set; }
        public string ErporderNumber { get; set; }
        public string PackageNo { get; set; }
        public DateTime? AcceptingDate { get; set; }
    }
}