﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MdmFixtureFaultBom
 : Entity<int>    {
        public MdmFixtureFaultBom()
        {
            MdmFixtureFaultBomdetail = new HashSet<MdmFixtureFaultBomdetail>();
        }

        public string Dept { get; set; }
        public string FixtureCode { get; set; }
        
        public bool? IsDelete { get; set; }
        public string Name { get; set; }
        public string ParentCode { get; set; }
        public string PartCode { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsr { get; set; }
        public string UpdUsrName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }

        public virtual ICollection<MdmFixtureFaultBomdetail> MdmFixtureFaultBomdetail { get; set; }
    }
}