﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfUnqcprdhl
 : Entity<int>    {
        public MfUnqcprdhl()
        {
            TfUnqcprdhl = new HashSet<TfUnqcprdhl>();
        }

        
        public string BilId { get; set; }
        public string BilNo { get; set; }
        public string SalNo { get; set; }
        public string CusNo { get; set; }
        public string ZcNo { get; set; }
        public string PrdNo { get; set; }
        public string OpCusNo { get; set; }
        public DateTime? OpDd { get; set; }
        public string MoNo { get; set; }
        public string TzNo { get; set; }
        public string No { get; set; }
        public DateTime? BillDate { get; set; }
        public string Rem { get; set; }
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
        public bool? IsPrint { get; set; }
        public string IdNo { get; set; }

        public virtual ICollection<TfUnqcprdhl> TfUnqcprdhl { get; set; }
    }
}