﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysAccountCloseItem
 : Entity<int>    {
        public string BillType { get; set; }
        public DateTime? CloseDate { get; set; }
        
        public bool? IsValid { get; set; }
        public int Mid { get; set; }
        public string Rem { get; set; }

        public virtual SysAccountClose MidNavigation { get; set; }
    }
}