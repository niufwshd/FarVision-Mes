﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TbWastetime
 : Entity<int>    {
        public DateTime? Inputdate { get; set; }
        public string Ban { get; set; }
        public string Bangroup { get; set; }
        public string Workshop { get; set; }
        public string Process { get; set; }
        public string Productcode { get; set; }
        public string Productname { get; set; }
        public string Equipment { get; set; }
        public int? Planstop { get; set; }
        public int? Switchstop { get; set; }
        public int? Faultstop { get; set; }
        public int? Otherstop { get; set; }
        public string Creator { get; set; }
        public DateTime? Createdate { get; set; }
        public string Modifyuser { get; set; }
        public DateTime? Modifydate { get; set; }
        
    }
}