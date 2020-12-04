using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMES.Model.Quality.QMNew
{
    public class PadInputValueModel
    {
        /// <summary>
        /// 备注
        /// </summary>
        public string Rem { get; set; }

        /// <summary>
        /// 检验单主表ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 送检单号
        /// </summary>
        public string SourceBillNo { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductionNo { get; set; }

        /// <summary>
        /// 检验结果
        /// </summary>
        public int? InspectionResult { get; set; }

        /// <summary>
        /// 合格数量
        /// </summary>
        public decimal QualifiedQty { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        public decimal UnQualifiedQty { get; set; }

        /// <summary>
        /// 检验项值
        /// </summary>
        public List<ValueItems> ValueItems { get; set; }

        /// <summary>
        /// 是否提交单据
        /// </summary>
        public bool IsSubmit { get; set; }
    }

    public class ValueItems
    {
        /// <summary>
        /// 检验值ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public int? Result { get; set; }

        /// <summary>
        /// 检验值
        /// </summary>
        public string Values { get; set; }
    }
}
