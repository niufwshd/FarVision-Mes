using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using WebMES.Model.WareHouse;

namespace WebMES.Model.Quality
{
    [Serializable]
    [DataContract]
    public class InspectionFilter
    {

        /// <summary>
        /// 送检单生成验收单实体
        /// </summary>
        [DataMember]
        public AcceptanceModel acceptanceModel { get; set; }


        /// <summary>
        /// 送检单批量生成验收单实体
        /// </summary>
        [DataMember]
        public List<AcceptanceModel> acceptanceModelList { get; set; }


        /// <summary>
        /// 检验结果
        /// </summary>
        [DataMember]
        public InspectionRecord inspectionRecord { get; set; }


        /// <summary>
        /// 包装实体 拆箱使用
        /// </summary>
        [DataMember]
        public PackageEntity PackageEntity { get; set; }

        /// <summary>
        /// 业务编号
        /// </summary>
        [DataMember]
        public string BusiNo { get; set; }

        /// <summary>
        /// 送检单条码ID
        /// </summary>
        [DataMember]
        public string InspectionBarcodeID { get; set; }

        /// <summary>
        /// 验收单条码ID
        /// </summary>
        [DataMember]
        public string AcceptanceBarcodeID { get; set; }

        /// <summary>
        /// 送检单号
        /// </summary>
        [DataMember]
        public string InspectionNo { get; set; }



    }

    /// <summary>
    /// 送检单生成验收单实体
    /// </summary>
    public class  AcceptanceModel
    {


        public string busiNo { get; set; }
        /// <summary>
        ///  送检单
        /// </summary>
        public string SourceNo { get; set; }

       /// <summary>
       /// 合格数量
       /// </summary>
        public decimal QualifiedQuantity { get; set; }

        /// <summary>
        /// 不合格实体
        /// </summary>
        public List<UnQualifiedModel> UnQualifiedModes { get; set; }

        /// <summary>
        /// 合格条码
        /// </summary>
        public List<ProductBarcodeModel> QualifiedBarcodeList { get; set; }

        /// <summary>
        /// 是否转单
        /// </summary>
        public bool IsTransferSingle { get; set; }

        /// <summary>
        /// 送检单行项目ID，用来获取验收单条码
        /// </summary>
        public string SubID { get; set; }
    }

    /// <summary>
    /// 不合格实体
    /// </summary>
    public class UnQualifiedModel
    {

      
        /// <summary>
        /// 处理结果
        /// </summary>
        public string HandlingSuggestion { get; set; }
       /// <summary>
       /// 处理结果名称
       /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 不合格条码
        /// </summary>
        public List<ProductBarcodeModel> BarcodeList { get; set; }


    

    }


    
}
