using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 6.	调入
    /// </summary>
    public class TransferInDTOModel: ResponseBaseModel
    {
        //public BaseResponseModel context { get; set; }

        public List<TransferInDTOHead> transferInDTOList { get; set; }
    }

    public class TransferInDTOHead
    {
        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public DocumentType TransInDocType { get; set; }

        /// <summary>
        /// 调拨类型 默认1 仓库转储
        /// </summary>
        public int TransferType { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Organization Org { get; set; }

        /// <summary>
        /// 单据日期
        /// </summary>
        public string BusinessDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        ///// <summary>
        /////Mes标识
        ///// </summary>
        //public string MesDocNo { get; set; }

        /// <summary>
        /// 行信息集合
        /// </summary>
        public List<TransferInDTOItem> TransInLines { get; set; }
    }

    public class TransferInDTOItem
    {
        /// <summary>
        /// 料品
        /// </summary>
        public Product ItemInfo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public decimal StoreUOMQty { get; set; }

        /// <summary>
        /// 成本数量
        /// </summary>
        public decimal CostUOMQty { get; set; }

        /// <summary>
        /// 存储地点
        /// </summary>
        public WareHouse TransInWh { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public BatchNum LotInfo { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public SupplierMange TransInSuppInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 子行集合
        /// </summary>
        public List<TransferInDTOItemChild> TransInSubLines { get; set; }
    }

    public class TransferInDTOItemChild
    {
        /// <summary>
        /// 存储地点
        /// </summary>
        public WareHouse TransOutWh { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public SupplierMange TransOutSuppInfo { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public BatchNum LotInfo { get; set; }
    }
}
