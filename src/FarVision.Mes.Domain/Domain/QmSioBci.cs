﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QmSioBci
 : Entity<int>    {
        
        public string BarCode { get; set; }
        public int? HandleResult { get; set; }
        public string HandleUser { get; set; }
        public DateTime? HandleDate { get; set; }
        public string ProcessNo { get; set; }
        public decimal? Qty { get; set; }
        public int Mid { get; set; }
        public int? RelationId { get; set; }
        public string Comment { get; set; }

        public virtual QmInspectS MidNavigation { get; set; }
    }
}