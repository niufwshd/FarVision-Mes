﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

using Volo.Abp.Domain.Entities;

namespace FarVision.Mes
{
    public partial class MfCk
 : Entity<int>    {
        public MfCk()
        {
            TfCk = new HashSet<TfCk>();
        }

        
        public string CkId { get; set; }
        public string CkNo { get; set; }
        public DateTime? CkDd { get; set; }
        public DateTime? PayDd { get; set; }
        public string TradMth { get; set; }
        public string BatNo { get; set; }
        public string CusNo { get; set; }
        public string Dep { get; set; }
        public string OsId { get; set; }
        public string OsNo { get; set; }
        public string CurId { get; set; }
        public decimal? ExcRto { get; set; }
        public string SalNo { get; set; }
        public string PayMth { get; set; }
        public short? PayDays { get; set; }
        public short? ChkDays { get; set; }
        public short? IntDays { get; set; }
        public string PayRem { get; set; }
        public string PrtSw { get; set; }
        public string CpySw { get; set; }
        public string Contract { get; set; }
        public decimal? Amt { get; set; }
        public decimal? AmtnNet { get; set; }
        public decimal? Tax { get; set; }
        public string TaxId { get; set; }
        public string SendMth { get; set; }
        public string SendWh { get; set; }
        public string Adr { get; set; }
        public decimal? DisCnt { get; set; }
        public string PsNo { get; set; }
        public decimal? AmtCls { get; set; }
        public decimal? AmtnNetCls { get; set; }
        public decimal? TaxCls { get; set; }
        public string ClsRem { get; set; }
        public DateTime? ClsDate { get; set; }
        public string ZhangId { get; set; }
        public bool? SaClsId { get; set; }
        public bool? LzClsId { get; set; }
        public string Clssa { get; set; }
        public string Clslz { get; set; }
        public string YdId { get; set; }
        public string BilType { get; set; }
        public string CusOsNo { get; set; }
        public string MobId { get; set; }
        public string LockMan { get; set; }
        public DateTime? LockDate { get; set; }
        public string CasNo { get; set; }
        public int? TaskId { get; set; }
        public string TurnId { get; set; }
        public string PrtUsr { get; set; }
        public decimal? QtyCls { get; set; }
        public string Zgfx { get; set; }
        public string SofhId { get; set; }
        public string CancelId { get; set; }
        public decimal? RtoFqsk { get; set; }
        public string DateflagFqsk { get; set; }
        public DateTime? DateFqsk { get; set; }
        public int? QsFqsk { get; set; }
        public string CusNoPos { get; set; }
        public string InstTeam { get; set; }
        public decimal? AmtnDs { get; set; }
        public string CardNo { get; set; }
        public DateTime? PrtDate { get; set; }
        public decimal? Qty1Cls { get; set; }
        public string TtTypeSet { get; set; }
        public DateTime? TtYmB { get; set; }
        public short? AmtPoi { get; set; }
        public DateTime? LzClsDd { get; set; }
        public string CntMan1 { get; set; }
        public string ChkPicking { get; set; }
        public string ScanUsr { get; set; }
        public DateTime? ScanDate { get; set; }
        public string CusFh { get; set; }
        public string DepFh { get; set; }
        public string CusFx { get; set; }
        public string ChkCache { get; set; }
        public string ChkPkche { get; set; }
        public string ChkFullPay { get; set; }
        public string Rem { get; set; }
        public string BusiNo { get; set; }
        public string BilType1 { get; set; }
        public string BilTypeName { get; set; }
        public string Usr { get; set; }
        public string UsrName { get; set; }
        public DateTime? SysDate { get; set; }
        public DateTime? UpdDate { get; set; }
        public string UpdUsrName { get; set; }
        public string UpdUsr { get; set; }
        public string ChkMan { get; set; }
        public string ChkManName { get; set; }
        public DateTime? ChkDate { get; set; }
        public bool? IsClose { get; set; }
        public DateTime? ClsDate1 { get; set; }
        public string ClsUsr { get; set; }
        public string ClsUsrName { get; set; }
        public string ChkMob { get; set; }
        public bool? IsPrint { get; set; }

        public virtual ICollection<TfCk> TfCk { get; set; }
    }
}