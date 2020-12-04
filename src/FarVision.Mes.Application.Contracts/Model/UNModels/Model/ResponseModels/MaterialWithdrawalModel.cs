using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 5.	U9退料接口模型
    /// </summary>
    public class MaterialWithdrawalModel : ResponseBaseModel
    {
        //public BaseResponseModel context { get; set; }
        //public List<MaterialWithdrawalHead> RecedeItemAndSnDTOList { get; set; }

        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string zGUID { get; set; }

        /// <summary>
        /// 退料单集合
        /// </summary>
        public List<MaterialWithdrawalItem> recedeItemAndSnDTOList { get; set; }

        /// <summary>
        /// 是否自动发料
        /// </summary>
        public bool IsAutoIssued { get; set; }

        /// <summary>
        /// 出货确认日期
        /// </summary>
        public string ShipConfirmDate { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public DocumentType doctypes { get; set; }
    }

    public class MaterialWithdrawalHead
    {
       
    }

    public class MaterialWithdrawalItem
    {
        ///// <summary>
        ///// 领料单号
        ///// </summary>
        //public string IssueDoc { get; set; }


        /// <summary>
        /// 生产订单号(MES计划单号)
        /// </summary>
        public string MODoc { get; set; }

        ///// <summary>
        ///// 领料单号行号
        ///// </summary>
        //public int IssueDocLineNo { get; set; }

        /// <summary>
        /// 料品
        /// </summary>
        public string ItemMasterCode { get; set; }

        /// <summary>
        /// 退料数量
        /// </summary>
        public decimal RecedeQty { get; set; }

        /// <summary>
        /// 退料原因
        /// </summary>
        public int RecedeReason { get; set; }
    }
}