using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO
{
    [Serializable]
    [DataContract]
    public class ProcessDTO
    {
        /// <summary>
        /// 二维码
        /// </summary>
        [DataMember]
        public string BARCODE { get; set; }
        /// <summary>
        /// 工序
        /// </summary>
        [DataMember]
        public string PROCESS { get; set; }
        /// <summary>
        /// 设备
        /// </summary>
        [DataMember]
        public string EQUIPMENT { get; set; }
        /// <summary>
        /// 人员
        /// </summary>
        public string PERSON { get; set; }
        /// <summary>
        /// 班次
        /// </summary>
        [DataMember]
        public string SHIFT { get; set; }
        /// <summary>
        /// 是否合格
        /// </summary>
        [DataMember]
        public string SFHG { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [DataMember]
        public string DEPARTMENT { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [DataMember]
        public string STARTTIME { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [DataMember]
        public string ENDTIME { get; set; }
        /// <summary>
        /// 产品号
        /// </summary>
        [DataMember]
        public string PRDNO { get; set; }
        /// <summary>
        /// 工序号
        /// </summary>
        [DataMember]
        public string ZC_NO { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        [DataMember]
        public string SEB_NO { get; set; }
        /// <summary>
        /// 人员编号
        /// </summary>
        [DataMember]
        public string SAL_NO { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        [DataMember]
        public string DEP_NO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int ZC_NUM { get; set; }
        /// <summary>
        /// 工单编号
        /// </summary>
        [DataMember]
        public string TZ_NO { get; set; }
    }
}
