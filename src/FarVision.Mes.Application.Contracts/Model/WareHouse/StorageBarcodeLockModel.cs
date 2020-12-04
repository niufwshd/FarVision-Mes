using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.WareHouse
{
    //条码库存锁定
    public class StorageBarcodeLockModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string WareHouseNo { get; set; }
        /// <summary>
        /// 产品
        /// </summary>

        public string PROD_NO { get; set; }
        /// <summary>
        /// 批次
        /// </summary>
        public string Batch_NO { get; set; }
        /// <summary>
        /// 锁定数量
        /// </summary>
        public decimal LockQuantity { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public string SourceNo { get; set; }
        /// <summary>
        /// 条码（包装）
        /// </summary>
        public string PackageNo { get; set; }

        public string Unit { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string SysDate { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Usr { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        public string UsrName { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public string ProductionDate { get; set; }


    }
}
