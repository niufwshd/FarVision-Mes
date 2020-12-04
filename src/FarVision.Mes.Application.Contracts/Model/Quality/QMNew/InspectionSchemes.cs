using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Quality.QMNew
{
    /// <summary>
    /// 检验方案主信息
    /// </summary>
    public class InspectionSchemes
    {
        /// <summary>
        /// 同批次免检
        /// </summary>
        public bool? EFI { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 方案编号
        /// </summary>
        public string SolutionNo { get; set; }

        /// <summary>
        /// 方案名称
        /// </summary>
        public string SolutionName { get; set; }

        /// <summary>
        /// 方案类型
        /// </summary>
        public string SolutionType { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public string SuppCode { get; set; }

        /// <summary>
        /// 频次类型
        /// </summary>
        public string FrequencyType { get; set; }

        /// <summary>
        /// 频次
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductionNo { get; set; }

        /// <summary>
        /// 检验类别
        /// </summary>
        public string InspectionType { get; set; }

        /// <summary>
        /// 工序
        /// </summary>
        public string ProcessNo { get; set; }

        /// <summary>
        /// 抽样规则
        /// </summary>
        public string SampleRule { get; set; }

        /// <summary>
        /// 抽样数量
        /// </summary>
        public decimal? SampleQty { get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        public decimal? RecordQty { get; set; }

        /// <summary>
        /// 允收水平
        /// </summary>
        public string AQL { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        public string EffectiveDate { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 检验方式
        /// </summary>
        public string InspectionMode { get; set; }

        /// <summary>
        /// 方案特性
        /// </summary>
        public string SolutionFeature { get; set; }

        public List<InspectionSchemesItem> InspectionSchemesItems { get; set; }
    }
}
