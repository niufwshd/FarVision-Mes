using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Lang
{
    [DataContract]
    [Serializable]
    public class bf_Lang_UIDTO : BaseDTO
    {
        private long _iD;        
        private string _keyNo;        
        private string _l0;        
        private string _l1;        
        private string _l2;        
        private string _l3;        
        private string _korean;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Lang_UIDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_keyNo"></param>
        /// <param name="_l0"></param>
        /// <param name="_l1"></param>
        /// <param name="_l2"></param>
        /// <param name="_l3"></param>
        /// <param name="_korean"></param>
        public bf_Lang_UIDTO(int _iD,
                string _keyNo,
                string _l0,
                string _l1,
                string _l2,
                string _l3,
                string _korean)
        {
            this._iD = _iD;
            this._keyNo = _keyNo;
            this._l0 = _l0;
            this._l1 = _l1;
            this._l2 = _l2;
            this._l3 = _l3;
            this._korean = _korean;
        }        
        
        ///// <summary>
        ///// 获取或设置.
        ///// </summary>
        //[DataMember]
        //public long ID
        //{
        //    get
        //    {
        //        return this._iD;
        //    }
        //    set
        //    {
        //        this._iD = value;
        //    }
        //}        
        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string KeyNo
        {
            get
            {
                return this._keyNo;
            }
            set
            {
                this._keyNo=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string L0
        {
            get
            {
                return this._l0;
            }
            set
            {
                this._l0=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string L1
        {
            get
            {
                return this._l1;
            }
            set
            {
                this._l1=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string L2
        {
            get
            {
                return this._l2;
            }
            set
            {
                this._l2=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string L3
        {
            get
            {
                return this._l3;
            }
            set
            {
                this._l3=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string Korean
        {
            get
            {
                return this._korean;
            }
            set
            {
                this._korean=value;
            }
        }
    }
}
