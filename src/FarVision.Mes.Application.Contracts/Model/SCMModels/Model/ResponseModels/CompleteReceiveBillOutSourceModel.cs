using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// SCM成品入库接口模型
    /// </summary>
    public class CompleteReceiveBillModel
    {
        public string Authorization { get; set; }
        public List<CompleteReceiveBillHead> Data { get; set; }
    }

    public class CompleteReceiveBillHead
    {
        /// <summary>
        /// 送货单号
        /// </summary>
        public string bih_no { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        public int bib19 { get; set; }

        /// <summary>
        /// 验收数量
        /// </summary>
        public float bib17 { get; set; }

        /// <summary>
        /// 验退数量
        /// </summary>
        public float bib27 { get; set; }

        /// <summary>
        ///厂内检验报废数量
        /// </summary>
        public float bib28 { get; set; }
        /// <summary>
        /// 供应商检验报废数量
        /// </summary>
        public float bib29 { get; set; }
        /// <summary>
        /// 待处置数量
        /// </summary>
        public float bib30 { get; set; }


        /// <summary>
        /// 限制使用数量
        /// </summary>
        public float bib31 { get; set; }

        /// <summary>
        /// 报废数量
        /// </summary>
        public float bib32 { get; set; }

        /// <summary>
        /// 让步接收
        /// </summary>
        public float sgm09 { get;set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string bib37 { get; set; }
    }
}
