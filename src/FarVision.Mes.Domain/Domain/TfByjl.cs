﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfByjl
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string ByNo { get; set; }
        public int Itm { get; set; }
        public DateTime? ByDd { get; set; }
        public string BynrNo { get; set; }
        public string BynrName { get; set; }
        public string ByFlag { get; set; }
        public int? PreItm { get; set; }
        public string Rem { get; set; }

        public virtual MfByjl MidNavigation { get; set; }
    }
}