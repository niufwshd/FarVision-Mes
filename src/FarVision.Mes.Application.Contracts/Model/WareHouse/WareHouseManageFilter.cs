using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace WebMES.Model.WareHouse
{
    [Serializable]
    [DataContract]
    public class WareHouseManageFilter
    {
        /// <summary>
        /// 下架指导
        /// </summary>
        [DataMember]
        public ShelfGuideFilter ShelfGuideModel { get; set; }

        [DataMember]
        /// <summary>
        /// 单据号码（出入移单据，来源单据，上下架单据）
        /// </summary>
        public string FormNo { get; set; }
        [DataMember]
        /// <summary>
        /// 来源单据
        /// </summary>
        public string Source_NO { get; set; }
        [DataMember]
        /// <summary>
        /// 工单
        /// </summary>
        public string WO_NO { get; set; }

        [DataMember]
        /// <summary>
        /// 条码集合
        /// </summary>
        public List<ProductBarcodeModel> ProductBarcodeList { get; set; }


        [DataMember]
        /// <summary>
        /// asn单实体
        /// </summary>
        public AsnModel Asn { get; set; }


        [DataMember]
        /// <summary>
        /// 单据种类
        /// </summary>
        public string Class { get; set; }


        [DataMember]
        /// <summary>
        /// 入库单实体
        /// </summary>
        public EnterFormModel EnterForm { get; set; }

        [DataMember]
        /// <summary>
        /// 移库单实体
        /// </summary>
        public TransferFormModel TransferForm { get; set; }


        [DataMember]
        /// <summary>
        /// 出库单实体
        /// </summary>
        public OutFormModel OutForm { get; set; }
        [DataMember]
        /// <summary>
        /// 投料实体
        /// </summary>
        public List<ProductionFeedModel> ProductionFeedList { get; set; }



       

        [DataMember]
        /// <summary>
        /// 条码是否新增
        /// </summary>
        public bool BarcodeIsNew { get; set; }

        [DataMember]
        /// <summary>
        /// 投料 查询条件
        /// </summary>
        public FeedingFilter feedingFilter { get; set; }
        [DataMember]
        /// <summary>
        /// 盘点计划实体
        /// </summary>
        public InventoryModel InventoryModel { get; set; }
        [DataMember]
        /// <summary>
        /// 盘点计划条码实体
        /// </summary>
        public InventoryBarcodeModel InventoryBarcodeModel { get; set; }
        [DataMember]
        /// <summary>
        /// 盘点计划条码集合
        /// </summary>
        public List<InventoryBarcodeModel> InventoryBarcodeList { get; set; }

        [DataMember]
        /// <summary>
        /// 退料实体
        /// </summary>
        public RejectedMaterialModel RejectedMaterialModel { get; set; }

        [DataMember]
        /// <summary>
        /// 备料计划转单实体
        /// </summary>
        public List<MaterialPreparaPlanTurnModel> MaterialTurnList { get; set; }

        [DataMember]
        /// <summary>
        /// 备料计划实体
        /// </summary>
        public MaterialPreparaPlanModel MPPModel { get; set; }

        [DataMember]
        /// <summary>
        /// 工单号集合
        /// </summary>
        public List<string> OrderNoList { get; set; }

        [DataMember]
        /// <summary>
        /// 待确认的备料计划号
        /// </summary>
        public List<string> MaterialPreparaPlanNoList { get; set; }

        [DataMember]
        /// <summary>
        /// 出库申请单号集合
        /// </summary>
        public List<string> OutFormApplyNoList { get; set; }

        [DataMember]
        /// <summary>
        /// 收料实体  2020-11-09废弃
        /// </summary>
        public ReceivingMaterialModel ReceivingMaterialModel { get; set; }

        [DataMember]
        /// <summary>
        /// 收料实体
        /// </summary>
    
        public ReceivingMaterialBarcode ReceiveMaterialBarcodeModel { get; set; }


        /// <summary>
        /// 条码实体
        /// </summary>
        [DataMember]
        public ProductBarcodeModel BarcodeModel { get; set; }
        [DataMember]
        /// <summary>
        /// 拣料解锁实体
        /// </summary>
        public UnlockPickMaterialModel UnlockPMModel { get; set; }

        /// <summary>
        /// 冻结库存集合（锁定）
        /// </summary>
        [DataMember]
        public List<FreezeStorageModel> FreezeStorageList { get; set; }
        [DataMember]
        /// <summary>
        /// 操作类型
        /// </summary>
        public string ActionType { get; set; }

        [DataMember]
        /// <summary>
        /// 收料历史查询条件
        /// </summary>
        public ReceivingMaterialHistoryFilter rmHistoryFilter { get; set; }



        

    }
}
