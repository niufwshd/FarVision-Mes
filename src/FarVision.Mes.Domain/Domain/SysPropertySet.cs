﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysPropertySet
 : Entity<int>    {
        
        public int PropertyId { get; set; }
        public int IUserId { get; set; }
        public string Value { get; set; }
        public string Usr { get; set; }
        public string UpdUsr { get; set; }
        public DateTime? UpdDate { get; set; }
         
    }
}