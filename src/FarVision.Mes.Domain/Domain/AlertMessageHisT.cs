﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class AlertMessageHisT
 : Entity<int>    {
        
        public string Msgid { get; set; }
        public string AlertNotification { get; set; }
        public string Receiver { get; set; }
        public int? UpgradeLevel { get; set; }
        public string Sendresult { get; set; }
        public DateTime? Sendtime { get; set; }
    }
}