﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmPackageBarcodeHistory
 : Entity<int>    {
        public string Barcode { get; set; }
        
        public string Iotype { get; set; }
        public bool? IsDelete { get; set; }
        public string PackageNo { get; set; }
        public string SourceNo { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public bool? IsReturn { get; set; }
    }
}