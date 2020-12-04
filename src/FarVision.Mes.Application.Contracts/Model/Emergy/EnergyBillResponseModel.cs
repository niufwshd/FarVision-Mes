using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Emergy
{
    /// <summary>
    /// 能耗输入单实体
    /// </summary>
    public class EnergyBillResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 单号
        /// </summary>
        public string Bill_Guid { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        public string AREA_NAME { get; set; }


        /// <summary>
        /// 区域编号
        /// </summary>
        public string AREA_NO { get; set; }


        /// <summary>
        /// 类别名称
        /// </summary>
        public string EC_NAME { get; set; }


        /// <summary>
        /// 类别编号
        /// </summary>
        public string EC_NO { get; set; }


        /// <summary>
        /// 采集点名称
        /// </summary>
        public string Collection_Name { get; set; }


        /// <summary>
        /// 采集点编号
        /// </summary>
        public string Collection_No { get; set; }

        /// <summary>
        /// 当前值
        /// </summary>
        public decimal CurRecord { get; set; }


        /// <summary>
        /// 上一次值
        /// </summary>
        public decimal LastRecord { get; set; }

        /// <summary>
        /// 实际值
        /// </summary>
        public decimal Record { get; set; }

        /// <summary>
        /// 输入日期
        /// </summary>
        public DateTime SysDate { get; set; }

        /// <summary>
        /// 录单员
        /// </summary>
        public string UsrName { get; set; }

        /// <summary>
        /// 录单员编号
        /// </summary>
        public string Usr{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Rem { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Bill_Date { get; set; }






    }





}
