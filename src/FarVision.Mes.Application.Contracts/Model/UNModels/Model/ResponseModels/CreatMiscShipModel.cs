using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// U9杂发单接口模型
    /// </summary>
    public class CreatMiscShipModel
    {
        public BaseResponseModel context { get; set; }

        public List<CreatMiscShipHead> miscShipmentDTOList { get; set; }
    }
    public class CreatMiscShipHead
    {
        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Organization Org { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public DocumentType MiscShipDocType { get; set; }

        /// <summary>
        /// 单据日期
        /// </summary>
        public string BusinessDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        public List<CreatMiscShipItem> MiscShipLs { get; set; }

        /// <summary>
        /// 受益组织
        /// </summary>
        public string BenefitOrgCode { get; set; }

    }

    public class CreatMiscShipItem
    {
        /// <summary>
        /// 料品
        /// </summary>
        public string ItemInfoCode { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public BatchNum LotInfoCode { get; set; }

        /// <summary>
        /// 存储地点
        /// </summary>
        public WareHouse Wh { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public SupplierMange SupplierInfoCode { get; set; }

        /// <summary>
        /// 存储类型 固定传4，可用
        /// </summary>
        public int StoreType { get { return 4; } }

        /// <summary>
        /// 库存数量[杂发数量]
        /// </summary>
        public decimal StoreUOMQty { get; set; }

        /// <summary>
        /// 成本数量[杂发数量]
        /// </summary>
        public decimal CostUOMQty { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal CostMny { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 受益部门
        /// </summary>
        public string BenefitDept { get; set; }

        /// <summary>
        ///生产相关 默认TRUE
        /// </summary>
        public bool IsMFG { get; set; }

        /// <summary>
        /// 生产订单
        /// </summary>
        public string MoDocNo { get; set; }

    }

}
