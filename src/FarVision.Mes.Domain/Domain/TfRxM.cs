﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfRxM
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string RxId { get; set; }
        public string RxNo { get; set; }
        public int Itm { get; set; }
        public DateTime? RxDd { get; set; }
        public string ModNo { get; set; }
        public int? ItmMj { get; set; }
        public string Wh { get; set; }
        public string Rem { get; set; }
        public decimal? AmtnNet { get; set; }
        public decimal? TaxRto { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Amt { get; set; }
        public string ExpNo { get; set; }
        public string EpNo { get; set; }
        public string RxStatus { get; set; }
        public string Spc { get; set; }
        public string InvNo { get; set; }
        public decimal? AddYear { get; set; }
        public decimal? AddTime { get; set; }
        public decimal? AddCrop { get; set; }
        public string InvBilId { get; set; }
        public string InvBilNo { get; set; }
        public string RsNo { get; set; }
        public string RsDesp { get; set; }

        public virtual MfRxM MidNavigation { get; set; }
    }
}