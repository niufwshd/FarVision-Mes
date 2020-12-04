using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace WebMES.Model.Quality.QMNew
{
    /// <summary>
    /// 检验方案子项
    /// </summary>
    public class InspectionSchemesItem
    {
        
        public int ID { get; set; }

        /// <summary>
        /// 主表ID
        /// </summary>
        public int MID { get; set; }

        /// <summary>
        /// 检验项目ID
        /// </summary>
        public int? ItemID { get; set; }

        /// <summary>
        /// 顺序号
        /// </summary>
        public int? ITM { get; set; }

        /// <summary>
        /// 检验项目号
        /// </summary>
        public string QC_ITM { get; set; }

        /// <summary>
        /// 检验项目名
        /// </summary>
        public string QC_ITM_NAME { get; set; }

        /// <summary>
        /// 检验项分类标识
        /// </summary>
        public string ParameterType { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        public int? QC_MODEL { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public string UNIT { get; set; }

        /// <summary>
        /// 下限
        /// </summary>
        public decimal? NUM_MIN { get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        public decimal? NUM_MAX { get; set; }

        /// <summary>
        /// 标准值
        /// </summary>
        public decimal? StandardValue { get; set; }

        /// <summary>
        /// 上限符号
        /// </summary>
        public string UpSybol { get; set; }

        /// <summary>
        /// 下限符号
        /// </summary>
        public string LowSybol { get; set; }

        /// <summary>
        /// 枚举配置
        /// </summary>
        public string QC_Enum_BusiNo { get; set; }

        /// <summary>
        /// 检验标准
        /// </summary>
        public string QC_SPC { get; set; }

        /// <summary>
        /// 检验方法
        /// </summary>
        public string QC_MTH { get; set; }

        /// <summary>
        /// 品号
        /// </summary>
        public string ProductionNo { get; set; }

        /// <summary>
        /// 检验部门
        /// </summary>
        public string InspectionDept { get; set; }

        /// <summary>
        /// 检验数量
        /// </summary>
        public int? InspectionQty { get; set; }

    }
}
