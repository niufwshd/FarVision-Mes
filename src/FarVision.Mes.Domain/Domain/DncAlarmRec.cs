﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class DncAlarmRec
 : Entity<int>    {
        
        public string SebNo { get; set; }
        public string AlarmNo { get; set; }
        public DateTime? AlarmDd { get; set; }
        public DateTime Sysdate { get; set; }
    }
}