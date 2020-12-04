using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_ListDTO : BaseDTO
    {
         private int _iD;        
        private string _no;        
        private bool _allowInput;        
        private string _remark;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_ListDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_allowInput"></param>
        /// <param name="_remark"></param>
        public bf_ListDTO(int _iD,
                string _no,
                bool _allowInput,
                string _remark)
        {
            this._iD = _iD;
            this._no = _no;
            this._allowInput = _allowInput;
            this._remark = _remark;
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public int ID
        {
            get
            {
                return this._iD;
            }
            set
            {
                this._iD=value;
            }
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
        public bool AllowInput
        {
            get
            {
                return this._allowInput;
            }
            set
            {
                this._allowInput=value;
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

      
    }
}
