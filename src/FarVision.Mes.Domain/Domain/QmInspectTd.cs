﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QmInspectTd
 : Entity<int>    {
        
        public int Mid { get; set; }
        public string Name { get; set; }
        public string InspectCode { get; set; }
        public string Unit { get; set; }
        public string LowerLimit { get; set; }
        public string UpperLimit { get; set; }
        public string StandardValue { get; set; }
        public int BillIndex { get; set; }
        public bool IsRequiredFields { get; set; }

        public virtual QmInspectT MidNavigation { get; set; }
    }
}