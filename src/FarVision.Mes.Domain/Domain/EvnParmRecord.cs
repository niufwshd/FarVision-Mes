﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class EvnParmRecord
 : Entity<int>    {
        
        public string Workshop { get; set; }
        public string Name { get; set; }
        public string EvnNo { get; set; }
        public string EvnName { get; set; }
        public DateTime? BgnDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? JhDate { get; set; }
        public string SalNo { get; set; }
        public string SalDep { get; set; }
        public int? QtyCycle { get; set; }
        public string CycleUnit { get; set; }
        public string ExecDate { get; set; }
        public int? ExecHour { get; set; }
        public int? ExecMinute { get; set; }
        public string Rem { get; set; }
        public string BusiNo { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }
    }
}