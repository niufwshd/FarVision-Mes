﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class PcTransfer
 : Entity<int>    {
        public string DevNo { get; set; }
        public string HeaterNo { get; set; }
        
        public string ProcessNo { get; set; }
        public string RecNo { get; set; }
        public string ShiftNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime SysDate { get; set; }
        public string TranNo { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string WoNo { get; set; }
    }
}