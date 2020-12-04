using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 销售出货接口数据模型
    /// </summary>
    public class ExWareHouse : ResponseBaseModel
    {
        public List<ExWareHouseHead> shipDTOs { get; set; }
    }

    public class ExWareHouseHead
    {
        /// <summary>
        /// 单据类型  07SM1
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        public string BusinessDate { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public SupplierMange OrderBy { get; set; }

        ///// <summary>
        ///// 业务员(写死K001)
        ///// </summary>
        //public SupplierMange Seller { get; set; }


        /// <summary>
        /// 组织
        /// </summary>
        public Organization Org { get; set; }

        /// <summary>
        /// 出货单行
        /// </summary>
        public List<ExWareHouseItem> ShipLines { get; set; }

        /// <summary>
        ///出货确认日期
        /// </summary>
        public string ShipConfirmDate { get; set; }
    }

    public class ExWareHouseItem
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
        /// 实际出货数量
        /// </summary>
        public decimal QtyPriceAmount { get; set; }

        /// <summary>
        /// 批号信息 -铸件批次号
        /// </summary>
        public BatchNum LotInfo { get; set; }

    }
}
