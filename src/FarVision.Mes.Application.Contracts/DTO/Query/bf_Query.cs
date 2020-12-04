using WebMES.DTO.Business;
using WebMES.DTO.Filter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{

    [DataContract]
    public class bf_QueryDTO : BaseDTO
    {
   
        private string _no;        
        private string _remark;        
        private string _condition;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_QueryDTO()
        {
            this.BusiNos = new List<string>();
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_remark"></param>
        /// <param name="_condition"></param>
        public bf_QueryDTO(
                string _no,
                string _remark,
                string _condition)
        {

            this._no = _no;
            this._remark = _remark;
            this._condition = _condition;
            this.BusiNos = new List<string>();
        }        
        

        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string No
        {
            get
            {
                return this._no;
            }
            set
            {
                this._no=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string Condition
        {
            get
            {
                return this._condition;
            }
            set
            {
                this._condition=value;
            }
        }

        [DataMember]
        public string Caption { get; set; }

        [DataMember]
        public List<bf_FilterFields> FilterFieldsList { get; set; }

         [DataMember]
        public List<bf_FilterDTO> FiltersList { get; set; }

        /// <summary>
        /// 布局数据
        /// </summary>
        [DataMember]
        public List<FilterCustomDTO> FilterCustom { get; set; }

        [DataMember]
        public List<string> BusiNos { get; set; }
    }
}
