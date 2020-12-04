﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class UnacceptedProductionHandle
 : Entity<int>    {
        public UnacceptedProductionHandle()
        {
            UnacceptedProductionHandleSub = new HashSet<UnacceptedProductionHandleSub>();
        }

        public string Attachment { get; set; }
        public string BillNo { get; set; }
        public int? BillStatus { get; set; }
        public string BilType { get; set; }
        public string BilTypeName { get; set; }
        public string BusiNo { get; set; }
        public DateTime? ChkDate { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public string ChkMob { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        
        public bool? IsClose { get; set; }
        public bool? IsPrint { get; set; }
        public string ProcessNo { get; set; }
        public int? Qty { get; set; }
        public string Rem { get; set; }
        public string SourceBillNo { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string WorkCenter { get; set; }

        public virtual ICollection<UnacceptedProductionHandleSub> UnacceptedProductionHandleSub { get; set; }
    }
}