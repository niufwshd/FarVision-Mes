﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TfVhid
 : Entity<int>    {
        public string BilId { get; set; }
        public string VohId { get; set; }
        public int Itm { get; set; }
        public string Dc { get; set; }
        public string AccNo { get; set; }
        public string Dsr { get; set; }
        public string AccExp { get; set; }
        public string RemId { get; set; }
        public string GetHeadrem { get; set; }
        public string RemFrom { get; set; }
        public int? PreItm { get; set; }
        public string RemSel { get; set; }
    }
}