using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_ComboxDTO : BaseDTO
    {
         private int _iD;        
        private string _no;        
        private bool _allowInput;        
        private int _valuesType;        
        private string _remark;        
        private int _sizeSmall;        
        private int _sizeLarge;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_ComboxDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_allowInput"></param>
        /// <param name="_valuesType"></param>
        /// <param name="_remark"></param>
        /// <param name="_sizeSmall"></param>
        /// <param name="_sizeLarge"></param>
        public bf_ComboxDTO(int _iD,
                string _no,
                bool _allowInput,
                int _valuesType,
                string _remark,
                int _sizeSmall,
                int _sizeLarge)
        {
            this._iD = _iD;
            this._no = _no;
            this._allowInput = _allowInput;
            this._valuesType = _valuesType;
            this._remark = _remark;
            this._sizeSmall = _sizeSmall;
            this._sizeLarge = _sizeLarge;
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        //[DataMember]
        //public int ID
        //{
        //    get
        //    {
        //        return this._iD;
        //    }
        //    set
        //    {
        //        this._iD=value;
        //    }
        //}        
        
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
        public int ValuesType
        {
            get
            {
                return this._valuesType;
            }
            set
            {
                this._valuesType=value;
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
        
        ///// <summary>
        ///// 获取或设置.
        ///// </summary>
        //[DataMember]
        //public int SizeSmall
        //{
        //    get
        //    {
        //        return this._sizeSmall;
        //    }
        //    set
        //    {
        //        this._sizeSmall=value;
        //    }
        //}        
        
        ///// <summary>
        ///// 获取或设置.
        ///// </summary>
        //[DataMember]
        //public int SizeLarge
        //{
        //    get
        //    {
        //        return this._sizeLarge;
        //    }
        //    set
        //    {
        //        this._sizeLarge=value;
        //    }
        //}
        [DataMember]
        public bf_ComboxItemDTO[] ComboxItems
        { get; set; }



    }
}
