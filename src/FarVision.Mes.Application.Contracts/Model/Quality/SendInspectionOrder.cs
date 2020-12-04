using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Quality
{
    /// <summary>
    /// 送检单
    /// </summary>
    public class SendInspectionOrder
    {
        /// <summary>
        /// 是否报工不合格品
        /// </summary>
        public bool IsUnqualified { get; set; } = false;

        /// <summary>
        /// 是否寄售仓
        /// </summary>
        public bool IsConsignment { get; set; }

        /// <summary>
        /// 库位
        /// </summary>
        public string StorageLocation { get; set; }

        /// <summary>
        /// 单据类型，1:进货送检单，2:成品送检单，3:过程送检单
        /// </summary>
        /// <returns></returns>
        public int BillType { get; set; }

        /// <summary>
        /// 业务号
        /// </summary>
        public string BizNo { get; set; }

        /// <summary>
        /// 来源单号
        /// </summary>
        /// <returns></returns>
        public string BillNoSource { get; set; }

        /// <summary>
        /// 来源单行号
        /// </summary>
        /// <returns></returns>
        //public string BillSourceLineNo { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        /// <returns></returns>
        public string BILLSTATUS { get; set; }

        /// <summary>
        /// 客户/厂商编号
        /// </summary>
        /// <returns></returns>
        public string SuppCode { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        /// <returns></returns>
        public string Dept { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        /// <returns></returns>
        public string PRODUCTNO { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public decimal InspectQty { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        /// <returns></returns>
        public string BatchNo { get; set; }

        /// <summary>
        /// 原材料批次
        /// </summary>
        /// <returns></returns>
        public string RawMaterialBatch { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        /// <returns></returns>
        public DateTime? ProducedDate { get; set; }

        /// <summary>
        /// 来源地点
        /// </summary>
        public string SourceLocation { get; set; }

        /// <summary>
        /// 目标地点
        /// </summary>
        public string TargetWareHouse { get; set; }

        /// <summary>
        /// 来源单据ID
        /// </summary>
        public int ItemID { get; set; }

        /// <summary>
        /// 条码信息集合
        /// </summary>
        public List<QMSIOBCI> BarcodeInfo { get; set; }

        /// <summary>
        /// 检验方案ID(PAD端品管检使用)
        /// </summary>
        public int SolutionID { get; set; } = 0;

        /// <summary>
        /// 来源类型(PAD端品管检使用)
        /// </summary>
        public string SourceType { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceNo { get; set; }

        /// <summary>
        /// 工位号
        /// </summary>
        public string WorkStationNo { get; set; }

        /// <summary>
        /// 班次号
        /// </summary>
        public string BAN_NO { get; set; }

        /// <summary>
        /// 工序号
        /// </summary>
        public string ZC_NO { get; set; }

        /// <summary>
        /// 送检单ID
        /// </summary>

        public object InspReqID { get; set; }

    }


    public class TransferOfOrderModel : SendInspectionOrder
    {
        /// <summary>
        /// 合格数量
        /// </summary>
        public decimal QualifiedQty { get; set; }

        /// <summary>
        /// 报废数量
        /// </summary>
        public decimal ScrapQty { get; set; }

        /// <summary>
        /// 退货数量
        /// </summary>
        public decimal ReturnQty { get; set; }

        public string Unit { get; set; }

        public object ID { get; set; }

        public object ParentID { get; set; }
    }
}
