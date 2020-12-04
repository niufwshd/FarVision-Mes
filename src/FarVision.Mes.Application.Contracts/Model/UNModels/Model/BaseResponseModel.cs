using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model
{
    public class BaseResponseModel
    {
        
        /// <summary>
        ///U9要求传输  zh-CN
        /// </summary>
        public string CultureName { get { return "zh-CN"; } }

        /// <summary>
        /// 企业编码 测试库是 001
        /// </summary>
        public string EntCode { get { return "001"; } }

        /// <summary>
        /// 组织编码测试库是 007
        /// </summary>
        public string OrgCode { get { return "007"; } }

        /// <summary>
        /// 用户
        /// </summary>
        public string UserCode { get; set; }
    }

    /// <summary>
    /// 组织
    /// </summary>
    public class Organization
    { 
        public string Code { get; set; }
 
    }

    /// <summary>
    /// 单据类型
    /// </summary>
    public class DocumentType
    {
        public string Code { get; set; }

    }

    /// <summary>
    /// 生产订单[DocNo]
    /// </summary>
    public class MOManufactureOrder
    {
        /// <summary>
        /// 生产订单单号
        /// </summary>
        public string DocNo { get; set; }

    }

    /// <summary>
    /// 生产订单[code]
    /// </summary>
    public class MOManufactureOrderForCode
    {
        /// <summary>
        /// 生产订单单号
        /// </summary>
        public string Code { get; set; }

    }

    /// <summary>
    /// 仓库
    /// </summary>
    public class WareHouse
    {        
        public string Code { get; set; }

    }

    /// <summary>
    /// 料品
    /// </summary>
    public class Product
    {
        public string Code { get; set; }

    }

    /// <summary>
    /// 批号
    /// </summary>
    public class BatchNum
    {
        public string Code { get; set; }

    }

    /// <summary>
    /// 供应商
    /// </summary>
    public class SupplierMange
    {
        public string Code { get; set; }

    }
}
