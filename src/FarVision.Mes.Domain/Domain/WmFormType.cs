﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class WmFormType
 : Entity<int>    {
        
        public string No { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public bool? IsDelete { get; set; }
        public string Scene { get; set; }
        public bool? IsHandover { get; set; }
        public string Erpno { get; set; }
        public bool? IsEffective { get; set; }
        public string Remark { get; set; }
        public string InspectionType { get; set; }
        public bool? IsCompleteConfirmInspection { get; set; }
    }
}