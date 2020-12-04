using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_Query_ItemDTO : BaseDTO
    {

        public bf_Query_ItemDTO()
        { }
        public bf_Query_ItemDTO(int _ID, int _MID, string _BusiNo, string _Alias, string _Condition, int _Sort, string _Remark)
        {
            this.ID = _ID;
            this.MID = _MID;
            this.BusiNo = _BusiNo;
            this.Alias = _Alias;
            this.Condition = _Condition;
            this.Sort = _Sort;
            this.Remark = _Remark;
        }
       
        #region 字段属性
        /// <summary>
        /// 记录ID
        /// </summary>
        [DataMember]
        public int ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int MID { get; set; }
        /// <summary>
        ///
        /// </summary>
        [DataMember]
        public string BusiNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Alias { get; set; }
        /// <summary>
        ///
        /// </summary>
        [DataMember]
        public string Condition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int Sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string Remark { get; set; }
        #endregion

    }
}
