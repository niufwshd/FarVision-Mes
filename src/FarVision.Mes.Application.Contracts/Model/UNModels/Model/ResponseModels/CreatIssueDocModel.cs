using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    ///  领料
    /// </summary>
    public class CreatIssueDocModel
    {
        public BaseResponseModel context { get; set; }

        public List<CreatIssueDocHead> issueDTOs { get; set; }
    }
    public class CreatIssueDocHead
    {
        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Organization IssueOrg { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public DocumentType DocType { get; set; }

        /// <summary>
        /// 生产订单号[集合]
        /// </summary>
        public List<MOManufactureOrderForCode> MOs { get; set; }

        /// <summary>
        /// 业务类型默认47
        /// </summary>
        public int BusinessType { get { return 47; } }

        /// <summary>
        /// 业务时间
        /// </summary>
        public string BusinessDate { get; set; }

        /// <summary>
        /// 行信息集合
        /// </summary>
        public List<CreatIssueDocItem> PickListDTOs { get; set; }
    }

    public class CreatIssueDocItem
    {
        /// <summary>
        /// 料品
        /// </summary>
        public Product Item { get; set; }

        /// <summary>
        /// 存储地点
        /// </summary>
        public WareHouse IssueWh { get; set; }

        /// <summary>
        /// 实发数量
        /// </summary>
        public decimal IssuedQty { get; set; }

        /// <summary>
        /// 批号
        /// </summary>
        public BatchNum Lot { get; set; }

        /// <summary>
        /// 供应商
        /// </summary>
        public SupplierMange Supplier { get; set; }

        /// <summary>
        /// 生产订单
        /// </summary>
        public MOManufactureOrderForCode MO { get; set; }
    }

}