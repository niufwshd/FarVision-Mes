﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class AlertRulesT
 : Entity<int>    {
        
        public string AlertType { get; set; }
        public string AlertStation { get; set; }
        public string AlertLevel { get; set; }
        public bool IsTrackstatus { get; set; }
        public int UpgradeTime { get; set; }
        public string AlertNotification { get; set; }
        public string Receiver { get; set; }
        public int UpgradeLevel { get; set; }
        public bool Isenable { get; set; }
        public DateTime Sysdate { get; set; }
    }
}