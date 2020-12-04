using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 委外验收接口实体
    /// </summary>
    public class CompleteReceiveBillOutSourceModel
    {
        public string Authorization { get; set; }
        public List<CompleteReceiveBillOutSourceHead> Data { get; set; }
    }

    public class CompleteReceiveBillOutSourceHead
    {
        /// <summary>
        /// 送货单号
        /// </summary>
        public string tra_no { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        public int trab20 { get; set; }

        /// <summary>
        /// 验收数量
        /// </summary>
        public float trab09 { get; set; }

        /// <summary>
        /// 验退数量
        /// </summary>
        public float trab10 { get; set; }

        /// <summary>
        ///厂内检验报废数量
        /// </summary>
        public float trab11 { get; set; }
        /// <summary>
        /// 供应商检验报废数量
        /// </summary>
        public float trab12 { get; set; }
        /// <summary>
        /// 待处置数量
        /// </summary>
        public float trab13 { get; set; }

        /// <summary>
        /// 让步接收数量
        /// </summary>
        public float trab15 { get; set; }

        /// <summary>
        /// 限制使用数量
        /// </summary>
        public float trab16 { get; set; }

        /// <summary>
        /// 报废数量
        /// </summary>
        public float trab17 { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string trab31 { get; set; }
    }
}
