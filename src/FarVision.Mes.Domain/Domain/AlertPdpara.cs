﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class AlertPdpara
 : Entity<int>    {
        
        public string Menutype { get; set; }
        public string PrdNo { get; set; }
        public string ZcNo { get; set; }
        public string ZcName { get; set; }
        public string ParaChange { get; set; }
        public string Issend { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}