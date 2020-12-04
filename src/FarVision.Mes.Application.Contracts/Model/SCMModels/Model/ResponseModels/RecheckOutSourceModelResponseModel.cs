using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.SCMModels.Model.ResponseModels
{

    /// <summary>
    /// 委外NCR接口实体
    /// </summary>
    public class RecheckOutSourceModelResponseModel
    {
        public string Authorization { get; set; }
        public List<RecheckOutSourceModelResponseItem> Data { get; set; }
    }

    public class RecheckOutSourceModelResponseItem
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
        /// 待处置数量
        /// </summary>
        public int trab13 { get; set; }
        /// <summary>
        /// 合格数量
        /// </summary>
        public int trab14 { get; set; }
        /// <summary>
        /// 让步接收数量
        /// </summary>
        public int trab15 { get; set; }
        /// <summary>
        /// 限制使用数量
        /// </summary>
        public int trab16 { get; set; }
        /// <summary>
        /// 报废数量
        /// </summary>
        public int trab17 { get; set; }
        /// <summary>
        /// 退货数量
        /// </summary>
        public int trab18 { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string trab32 { get; set; }
    }
}
