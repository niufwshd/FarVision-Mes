using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// U9成品入库接口模型
    /// </summary>
    public class CompleteDocInfoModel:ResponseBaseModel
    {
        //public BaseResponseModel context { get; set; }
        public List<CompleteDocInfoHead> completeDocInfoDTOList { get; set; }
    }

    public class CompleteDocInfoHead
    {
        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        public DocumentType DocType { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public  Organization Org { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        public string BusinessDate { get; set; }

        /// <summary>
        /// 入库单行List
        /// </summary>
        public List<CompleteDocInfoItem> CompleteList { get; set; }
    }

    public class CompleteDocInfoItem
    {
        

        /// <summary>
        /// 生产订单单号
        /// </summary>
        public MOManufactureOrder MOKey { get; set; }   

        public WareHouse Wh { get; set; }

        /// <summary>
        /// 存储类型 默认传4,  可用
        /// </summary>
        public int StorageType { get; set; }

        /// <summary>
        /// 入库数量
        /// </summary>
        public decimal CompleteQty { get; set; }

        /// <summary>
        /// 料品
        /// </summary>
        public Product Item { get; set; }

        /// <summary>
        /// 入库批号 -铸件批次号
        /// </summary>
        public string LotNo { get; set; }
        
    }
}
