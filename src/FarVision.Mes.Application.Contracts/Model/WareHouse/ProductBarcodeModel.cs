using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.WareHouse
{

    [Serializable]
    [DataContract]
    /// <summary>
    /// 产品条码
    /// </summary>
    public class ProductBarcodeModel : ICloneable 
    {
        [DataMember]
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        [DataMember]
        /// <summary>
        /// MID
        /// </summary>
        public string MID { get; set; }
        [DataMember]
        /// <summary>
        /// 产品编号
        /// </summary>
        public string Prod_NO { get; set; }
        [DataMember]
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Prod_Name { get; set; }
        [DataMember]
        /// <summary>
        /// 条码（包装号）
        /// </summary>
        public string PackageNo { get; set; }
        [DataMember]
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_No { get; set; }
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
        /// 状态
        /// </summary>
        public string Status { get; set; }

        [DataMember]
        /// <summary>
        /// 状态名称
        /// </summary>
        public string StatusName { get; set; }
        [DataMember]
        /// <summary>
        ///  生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        [DataMember]
        /// <summary>
        /// 目标地点
        /// </summary>
        public string Location { get; set; }

        [DataMember]
        /// <summary>
        /// 目标地点名称
        /// </summary>
        public string LocationName { get; set; }
        [DataMember]
        /// <summary>
        /// 来源地点
        /// </summary>
        public string SourceLocation { get; set; }

        [DataMember]
        /// <summary>
        /// 来源地点名称
        /// </summary>
        public string SourceLocationName { get; set; }

        [DataMember]
        /// <summary>
        /// 锁定原因，下架指导专用，来源于Package 的LockReason 
        /// </summary>
        public string LockReason { get; set; }
        [DataMember]
        /// <summary>
        /// 库存类型 no 无，Package 箱管理，Batch 批次管理
        /// </summary>
        public string StorageType { get; set; }

        [DataMember]
        /// <summary>
        /// 完成数量
        /// </summary>
        public decimal FinishQuantity { get; set; }

        [DataMember]
        /// <summary>
        /// 原料批次
        /// </summary>
        public string MaterialBatch_NO { get; set; }
        [DataMember]
        /// <summary>
        /// 来源仓库编号
        /// </summary>
        public string SourceWareHouseNo { get; set; }
        [DataMember]
        /// <summary>
        /// 来源仓库名称
        /// </summary>
        public string SourceWareHouseName { get; set; }
        [DataMember]
        /// <summary>
        /// 来源单
        /// </summary>
        public string Source_No { get; set; }
        [DataMember]
        /// <summary>
        /// 库位移库地点
        /// </summary>
        public string TargetLocation { get; set; }
        [DataMember]
        /// <summary>
        /// 主仓库编号
        /// </summary>
        public string MasterWareHouseNo { get; set; }

        [DataMember]
        public decimal QTY { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        //[DataMember]
        ///// <summary>
        ///// 强制下架 记录 行项目来源库位
        ///// </summary>
        //public string ItemSourceLocation { get; set; }

        //[DataMember]
        ///// <summary>
        ///// 强制下架 记录 行项目来源主仓库编号
        ///// </summary>
        //public string ItemMasterWareHouseNo { get; set; }

    }
}
