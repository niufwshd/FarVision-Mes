﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PpProductionOrders
 : Entity<int>    {
        
        public int Mid { get; set; }
        public int? Item { get; set; }
        public string ProdNo { get; set; }
        public string ProdName { get; set; }
        public string ProdMark { get; set; }
        public string ProdSpec { get; set; }
        public string Unit { get; set; }
        public string ProcessNo { get; set; }
        public string ProcessName { get; set; }
        public string WhseNo { get; set; }
        public decimal Qty { get; set; }
        public decimal? QtyStd { get; set; }
        public decimal? QtyBase { get; set; }
        public string BatchNo { get; set; }
        public string Rem { get; set; }
        public bool? IsOutSourcing { get; set; }
        public string VerNo { get; set; }
        public int? SrcItemId { get; set; }

        public virtual PpProductionOrder MidNavigation { get; set; }
    }
}