﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class EqpDeviceWarning
 : Entity<int>    {
        
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string WarningCode { get; set; }
        public string WarningType { get; set; }
        public string WarningInfo { get; set; }
    }
}