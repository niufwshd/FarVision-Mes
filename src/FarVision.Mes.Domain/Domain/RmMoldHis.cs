﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class RmMoldHis
 : Entity<int>    {
        
        public string ModNo { get; set; }
        public string ModSn { get; set; }
        public int? SrcItemId { get; set; }
        public string SrcNo { get; set; }
        public string Status { get; set; }
        public string StatusNew { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
    }
}