﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfJh
 : Entity<int>    {
        public MfJh()
        {
            TfJh = new HashSet<TfJh>();
        }

        
        public string JhNo { get; set; }
        public DateTime? JhDd { get; set; }
        public string JhId { get; set; }
        public string Dep { get; set; }
        public string SalNo { get; set; }
        public string BatNo { get; set; }
        public string Rem { get; set; }
        public DateTime? EstDd { get; set; }
        public string SoNo { get; set; }
        public string CusNo { get; set; }
        public bool? ClsIdSc { get; set; }
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

        public virtual ICollection<TfJh> TfJh { get; set; }
    }
}