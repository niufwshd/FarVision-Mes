using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace WebMES.Model.Quality
{
    /// <summary>
    /// 不合格品处理实体
    /// </summary>
    public class UnAcceptedHandleModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        public string BillNo { get; set; }

        /// <summary>
        /// 工作中心
        /// </summary>
        public string WorkCenter { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        public string SourceBillNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        public string BillStatus { get; set; }

        /// <summary>
        /// 不合格品处理报告
        /// </summary>
        public string Attachment { get; set; }

        /// <summary>
        /// 工序号
        /// </summary>
        public string ProcessNo { get; set; }


        /// <summary>
        /// 不合格处理行项目
        /// </summary>
        public List<UnAcceptedHandleSub> SubList { get; set; }

    }


    /// <summary>
    /// 不合格处理行项目
    /// </summary>
    public class UnAcceptedHandleSub
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// MID
        /// </summary>
        public string MID { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string BatchNoOrBarcode { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductionNo { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string PROD_NAME { get; set; }


        /// <summary>
        /// 产品规格
        /// </summary>
        public string PROD_SPC { get; set; }
        /// <summary>
        /// 缺陷号码
        /// </summary>
        public string DefectNo { get; set; }

        /// <summary>
        /// 缺陷现象
        /// </summary>
        public string DefectPhenomenon { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal Qty { get; set; }

        /// <summary>
        /// 处理方式
        /// </summary>
        public string HandleMode { get; set; }


    }


}
