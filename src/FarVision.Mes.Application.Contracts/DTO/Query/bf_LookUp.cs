using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_LookUpDTO : BaseDTO
    {
         private int _iD;        
        private string _no;        
        private string _name;        
        private bool _cache;        
        private string _sQL;        
        private string _remark;        
        private int _iUserID;        
        private DateTime _dInputDate;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_LookUpDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_name"></param>
        /// <param name="_cache"></param>
        /// <param name="_sQL"></param>
        /// <param name="_remark"></param>
        /// <param name="_iUserID"></param>
        /// <param name="_dInputDate"></param>
        public bf_LookUpDTO(int _iD,
                string _no,
                string _name,
                bool _cache,
                string _sQL,
                string _remark,
                int _iUserID,
                DateTime _dInputDate)
        {
            this._iD = _iD;
            this._no = _no;
            this._name = _name;
            this._cache = _cache;
            this._sQL = _sQL;
            this._remark = _remark;
            this._iUserID = _iUserID;
            this._dInputDate = _dInputDate;
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
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool Cache
        {
            get
            {
                return this._cache;
            }
            set
            {
                this._cache=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string SQL
        {
            get
            {
                return this._sQL;
            }
            set
            {
                this._sQL=value;
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
        public int IUserID
        {
            get
            {
                return this._iUserID;
            }
            set
            {
                this._iUserID=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public DateTime DInputDate
        {
            get
            {
                return this._dInputDate;
            }
            set
            {
                this._dInputDate=value;
            }
        }
    }
}
