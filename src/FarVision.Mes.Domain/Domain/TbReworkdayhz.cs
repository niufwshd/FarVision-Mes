﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class TbReworkdayhz
 : Entity<int>    {
        
        public string Inputdate { get; set; }
        public string PrdNo { get; set; }
        public string PrdName { get; set; }
        public string PrdSpc { get; set; }
        public string Responshop { get; set; }
        public string Defecttype { get; set; }
        public int? Ljreworknumber { get; set; }
    }
}