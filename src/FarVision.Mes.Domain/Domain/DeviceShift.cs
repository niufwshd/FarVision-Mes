﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class DeviceShift
 : Entity<int>    {
        
        public string ShiftNo { get; set; }
        public string ShiftName { get; set; }
        public string SebNo { get; set; }
        public string SebName { get; set; }
        public int? TimeLen { get; set; }
        public string BeginTime { get; set; }
        public int? BeginTimeType { get; set; }
        public string EndTime { get; set; }
        public int? EndTimeType { get; set; }
        public string Usr { get; set; }
        public string Usrname { get; set; }
        public DateTime Sysdate { get; set; }
    }
}