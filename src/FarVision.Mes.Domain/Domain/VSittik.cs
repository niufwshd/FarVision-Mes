﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class VSittik
 : Entity<int>    {
        public string ProductionName { get; set; }
        public string BillStatus { get; set; }
        public string Priority { get; set; }
        public string InspectionType { get; set; }
        public DateTime? InspectionDate { get; set; }
        public string DeptNo { get; set; }
        public decimal? InspectQty { get; set; }
        public string SendInspectionUser { get; set; }
        public DateTime? SendInspectionDate { get; set; }
        public string BillNo { get; set; }
        public string InspectionUser { get; set; }
        public string ProcessNo { get; set; }
    }
}