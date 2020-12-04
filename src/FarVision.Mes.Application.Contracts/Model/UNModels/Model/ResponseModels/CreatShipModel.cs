using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 7.	出货
    /// </summary>
    public class CreatShipModel
    {
        public BaseResponseModel context { get; set; }

        public List<CreatIssueDocHead> ShipDTOs { get; set; }
    }
    public class CreatShipHead
    {
        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        public string BusinessDate { get; set; }

        /// <summary>
        /// 订货客户
        /// </summary>
        public SupplierMange OrderBy { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Organization IssueOrg { get; set; }

        /// <summary>
        /// 出货单行
        /// </summary>
        public List<CreatShipItem> ShipLines { get; set; }

        /// <summary>
        /// 出货确认日期
        /// </summary>
        public DateTime ShipConfirmDate { get; set; }

    }

    public class CreatShipItem
    {
        /// <summary>
        /// 料品
        /// </summary>
        public Product ItemInfo { get; set; }

        /// <summary>
        /// 存储地点
        /// </summary>
        public WareHouse WH { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public SupplierMange Supplier { get; set; }

        /// <summary>
        /// 实际出货数量
        /// </summary>
        public decimal QtyPriceAmount { get; set; }

        /// <summary>
        /// 定价
        /// </summary>
        public decimal OrderPriceTC { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public BatchNum LotInfo { get; set; }

        /// <summary>
        /// 最终价
        /// </summary>
        public decimal FinallyPriceTC { get; set; }
    }
}