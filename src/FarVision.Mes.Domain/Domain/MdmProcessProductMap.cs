﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MdmProcessProductMap
 : Entity<int>    {
        
        public string ProcNo { get; set; }
        public string ProdNo { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public string VerNo { get; set; }
        public bool? IsConverted { get; set; }
        public string Bomno { get; set; }
    }
}