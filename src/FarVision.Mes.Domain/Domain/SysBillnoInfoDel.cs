﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysBillnoInfoDel
 : Entity<int>    {
        public string BillId { get; set; }
        public string BillNo { get; set; }
        public string Usr { get; set; }
        public DateTime Deldate { get; set; }
    }
}