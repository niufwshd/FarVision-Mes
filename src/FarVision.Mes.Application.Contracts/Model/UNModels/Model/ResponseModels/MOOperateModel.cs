using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.UNModels.Model.ResponseModels
{
    /// <summary>
    /// 开工MO
    /// </summary>
    public class MOOperateModel: ResponseBaseModel
    {
        //public BaseResponseModel context { get; set; }

        public List<MOOperateHead> mOOperateParamDTOs { get; set; }

    }


    public class MOOperateHead
    {
        /// <summary>
        /// 接口交易ID
        /// </summary>
        public string ZGUID { get; set; }

        /// <summary>
        /// 组织
        /// </summary>
        public Organization Org { get; set; }

        /// <summary>
        /// 生产单号
        /// </summary>
        public string MODocNo { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        public string OperateOn { get; set; }

        /// <summary>
        /// 操作数量
        /// </summary>
        public decimal OperateQty { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public bool OperateType { get; set; } 

    }

}
