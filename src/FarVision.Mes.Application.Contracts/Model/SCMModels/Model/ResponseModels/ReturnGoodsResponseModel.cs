using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.SCMModels.Model.ResponseModels
{
    public class ReturnGoodsResponseModel
    {
        public string Authorization { get; set; }
        public List<ReturnGoodsItem> Data { get; set; }
    }

    public class ReturnGoodsItem
    {
        /// <summary>
        /// 退货单号
        /// </summary>
        public string thd01 { get; set; }
        /// <summary>
        /// 退货行号
        /// </summary>
        public string thd02 { get; set; }

        /// <summary>
        /// 供应商编号
        /// </summary>
        public string thd03 { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public string thd04 { get; set; }
        /// <summary>
        /// 品号
        /// </summary>

        public string thd05 { get; set; }
        /// <summary>
        /// 品名
        /// </summary>
        public string thd06 { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string thd07 { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string thd08 { get; set; }


        /// <summary>
        /// 退货数量
        /// </summary>
        public float thd09 { get; set; }

        /// <summary>
        /// 工单单号 可为空
        /// </summary>
        public string thd10 { get; set; }

        /// <summary>
        /// 送货单号  可为空
        /// </summary>
        public string thd11 { get; set; }


        /// <summary>
        /// 送货单行号  可为空
        /// </summary>
        public string thd12 { get; set; }

        /// <summary> 
        /// 备注  可为空
        /// </summary>
        public string thd13 { get; set; }


        /// <summary>
        /// 类型 传0代表采购退货，传1代表委外退货
        /// </summary>
        public int thd14 { get; set; }


        /// <summary>
        /// 退货日期 格式为"2020-07-17 00:00:00"
        /// </summary>
        public string thd15 { get; set; }

        /// <summary>
        /// 生产批次 可为空
        /// </summary>
        public string thd17 { get; set; }

        /// <summary>
        /// 材料批次 可为空
        /// </summary>
        public string thd18 { get; set; }

        /// <summary>
        /// A为新增，D为撤销
        /// </summary>
        public string FLAG { get; set; }


    }
}
