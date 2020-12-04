using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.Model.WareHouse
{
    [Serializable]
    [DataContract]
    /// <summary>
    /// 包装业务实体
    /// </summary>
    public class PackageEntity
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        /// <summary>
        /// 来源包装
        /// </summary>
        public string SourcePackageNo { get; set; }
        [DataMember]
        /// <summary>
        ///目的包装
        /// </summary>
        public string TargetPackageNo { get; set; }
        [DataMember]
        /// <summary>
        /// 产品
        /// </summary>
        public string Prod_NO { get; set; }
        [DataMember]
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_NO { get; set; }
        [DataMember]
        /// <summary>
        /// 父级包装
        /// </summary>
        public string ParentPackage { get; set; }
        [DataMember]
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        [DataMember]
        /// <summary>
        /// 单件条码集合
        /// </summary>
        public List<string> Barcodes { get; set; }

        [DataMember]
        /// <summary>
        /// 包装类型
        /// </summary>
        public string PackageType { get; set; }

        [DataMember]
        /// <summary>
        /// 单件条码
        /// </summary>
        public string Barcode { get; set; }
        [DataMember]
        /// <summary>
        /// 是否单件
        /// </summary>
        public bool IsSingle{ get; set; }
        [DataMember]
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        [DataMember]
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }

        [DataMember]
        /// <summary>
        /// 供应商
        /// </summary>
        public string Supplier { get; set; }

    }
}
