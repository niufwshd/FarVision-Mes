﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MoldMtOrder
 : Entity<int>    {
        public MoldMtOrder()
        {
            MoldMtorderInfo = new HashSet<MoldMtorderInfo>();
        }

        
        public string No { get; set; }
        public string Name { get; set; }
        public DateTime JhDd { get; set; }
        public string SalNo { get; set; }
        public string ModNo { get; set; }
        public string Status { get; set; }
        public DateTime? EndDd { get; set; }
        public string Rem { get; set; }
        public DateTime BillDate { get; set; }
        public string BusiNo { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public DateTime? UpdDate { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMob { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public int? IsPrint { get; set; }
        public string BilNo { get; set; }
        public string SpecNo { get; set; }
        public string StationNo { get; set; }
        public decimal? Standard { get; set; }
        public string GdSource { get; set; }

        public virtual ICollection<MoldMtorderInfo> MoldMtorderInfo { get; set; }
    }
}