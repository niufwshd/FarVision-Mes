using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_ListItemDTO : BaseDTO
    {
           private int _iD;        
        private int _mID;        
        private string _valueText;        
        private bool _stop;        
        private int _parentID;        
        private string _remark;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_ListItemDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_valueText"></param>
        /// <param name="_stop"></param>
        /// <param name="_parentID"></param>
        /// <param name="_remark"></param>
        public bf_ListItemDTO(int _iD,
                int _mID,
                string _valueText,
                bool _stop,
                int _parentID,
                string _remark)
        {
            this._iD = _iD;
            this._mID = _mID;
            this._valueText = _valueText;
            this._stop = _stop;
            this._parentID = _parentID;
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
        public int MID
        {
            get
            {
                return this._mID;
            }
            set
            {
                this._mID=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string ValueText
        {
            get
            {
                return this._valueText;
            }
            set
            {
                this._valueText=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool Stop
        {
            get
            {
                return this._stop;
            }
            set
            {
                this._stop=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public int ParentID
        {
            get
            {
                return this._parentID;
            }
            set
            {
                this._parentID=value;
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
