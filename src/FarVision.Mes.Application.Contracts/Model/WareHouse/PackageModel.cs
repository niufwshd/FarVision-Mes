using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    public class PackageModel
    {

        /// <summary>
        /// 包装号
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// 上级包装ID
        /// </summary>
        public string ParentPackageID { get; set; }
        /// <summary>
        /// 入库单明细ID
        /// </summary>

        public string EnterFormDetailID { get; set; }
        /// <summary>
        /// 物料
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 锁定
        /// </summary>
        public bool IsLock { get; set; }

        /// <summary>
        /// 包装类型
        /// </summary>
        public string PackageType { get; set; }
        /// <summary>
        /// 是否最小包装
        /// </summary>
        public bool IsSnp { get; set; }
        /// <summary>
        /// 容量
        /// </summary>
        public decimal Capacity { get; set; }
        /// <summary>
        /// 生产批次
        /// </summary>
        public string ProBatch_No { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        public string Supplier { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public decimal Sort { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// 库存
        /// </summary>
        public string Storage { get; set; }
        /// <summary>
        /// 提前发运单明细
        /// </summary>
        public string AsnItemID { get; set; }
        /// <summary>
        /// 是否未完成尾箱
        /// </summary>
        public bool IsUnfinishedProduct { get; set; }
        /// <summary>
        /// 锁定单据号
        /// </summary>
        public string LockFormNo { get; set; }

        /// <summary>
        /// 包装对应的移库单
        /// </summary>

        public string TransferFormItem { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 客户标签
        /// </summary>
        public string CustomerTag { get; set; }


        /// <summary>
        /// 库存类型
        /// </summary>
        public string StorageType { get; set;}


        /// <summary>
        /// 合格/不合格
        /// </summary>
        public string QualityStatus { get; set; }

        /// <summary>
        /// 备注(分档产品)
        /// </summary>
        public string Rem { get; set; }

    }
}
