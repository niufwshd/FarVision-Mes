using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.WareHouse
{

    [Serializable]
    [DataContract]
    /// <summary>
    /// 上下架指导条件
    /// </summary>
    public class ShelfGuideFilter
    {
        [DataMember]
        /// <summary>
        /// 下架指导单号
        /// </summary>
        public string No { get; set; }
        [DataMember]
        /// <summary>
        /// 来源仓库
        /// </summary>
        public string SourceWareHouse { get; set; }
        [DataMember]

        public string SourceWareHouseName { get; set; }

        [DataMember]

        public string TargetWareHouse { get; set; }
        [DataMember]
        public string TargetWareHouseName { get; set; }
        [DataMember]
        /// <summary>
        /// 来源单号
        /// </summary>
        public string Source_NO { get; set; }
        [DataMember]
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        [DataMember]
        public string StatusName { get; set; }
        [DataMember]
        /// <summary>
        /// 部门
        /// </summary>
        public string Dept { get; set; }
        [DataMember]
        /// <summary>
        ///  类型
        /// </summary>
        public string Type { get; set; }

        [DataMember]
        /// <summary>
        ///  下架库位
        /// </summary>

        public string ShelfGuideLocation { get; set; }


        [DataMember]
        public List<ShelfGuideProduct> ProductList { get; set; }
    }

    [Serializable]
    [DataContract]
    //上下架 物料，数量
    public class ShelfGuideProduct
    {
        [DataMember]
        public string  ID { get; set;}
        [DataMember]
        /// <summary>
        /// 产品
        /// </summary>
        public string PROD_NO { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [DataMember]
        public string PROD_NAME { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [DataMember]
        public string PROD_SPC { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        [DataMember]
        public string PROD_SNM { get; set; }

        [DataMember]
        /// <summary>
        /// 计划数量
        /// </summary>
        public decimal PlanQuantity { get; set; }
        [DataMember]
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        [DataMember]
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        [DataMember]
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }
        [DataMember]
        /// <summary>
        /// 来源库位
        /// </summary>
        public string SourceLocation { get; set; }
        [DataMember]
        /// <summary>
        /// 来源库位名称
        /// </summary>
        public string SourceLocationName { get; set; }
        [DataMember]
        /// <summary>
        /// 目标库位
        /// </summary>
        public string TargetLocation { get; set; }
        [DataMember]
        /// <summary>
        /// 目标库位名称
        /// </summary>
        public string TargetLocationName { get; set; }
        [DataMember]
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        [DataMember]
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
        [DataMember]
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        [DataMember]
        public string StatusName { get; set; }

        [DataMember]
        /// <summary>
        /// 库存类型
        /// </summary>
        public string StorageType { get; set; }


        [DataMember]
        /// <summary>
        /// 来源编号-主仓库编号
        /// </summary>
        public string MasterWareHouseNo { get; set; }
        [DataMember]
        /// <summary>
        /// 是否强制下架
        /// </summary>
        public bool IsForcedOffShelves { get; set; }
        [DataMember]
        /// <summary>
        /// 条码
        /// </summary>
        public List<ProductBarcodeModel> productBarCodeList { get; set; }

    }

}
