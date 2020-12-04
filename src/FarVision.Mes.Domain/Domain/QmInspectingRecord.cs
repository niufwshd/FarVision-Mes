﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class QmInspectingRecord
 : Entity<int>    {
        
        public string InspectingNo { get; set; }
        public string ItemNo { get; set; }
        public string UpSymbols { get; set; }
        public string LowSymbols { get; set; }
        public decimal? UpValue { get; set; }
        public decimal? LowValue { get; set; }
        public decimal? StandardValue { get; set; }
        public string SolutionNo { get; set; }
        public string PrdNo { get; set; }
        public int? Result { get; set; }
        public int Mid { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }

        public virtual QmInspectingOrder MidNavigation { get; set; }
    }
}