﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class FaultCause
 : Entity<int>    {
        
        public string No { get; set; }
        public string Name { get; set; }
        public string Calltypeno { get; set; }
        public string ZcNo { get; set; }
        public int? Sort { get; set; }
        public string Busino { get; set; }
        public DateTime Sysdate { get; set; }
        public string Usr { get; set; }
        public DateTime? Upddate { get; set; }
        public string Updusr { get; set; }
        public string Usrname { get; set; }
        public string Updusrname { get; set; }
    }
}