﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class SysInterfaceLog
 : Entity<int>    {
        
        public bool IsIn { get; set; }
        public DateTime LogTime { get; set; }
        public string SerialNo { get; set; }
        public string InterfaceCode { get; set; }
        public string InterfaceName { get; set; }
        public string FunctionName { get; set; }
        public string RequestBody { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseBody { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Uc01 { get; set; }
        public string Uc02 { get; set; }
        public string Uc03 { get; set; }
        public string Uc04 { get; set; }
        public string Uc05 { get; set; }
    }
}