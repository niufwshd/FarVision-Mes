using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_ComboxItemDTO : BaseDTO
    {
        private int _iD;        
        private int _mID;        
        private string _valueText;        
        private int _sort;
        private Image _image1;        
        private string _remark;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_ComboxItemDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_valueText"></param>
        /// <param name="_sort"></param>
        /// <param name="_image1"></param>
        /// <param name="_remark"></param>
        public bf_ComboxItemDTO(int _iD,
                int _mID,
                string _valueText,
                int _sort,
                Image _image1,
                string _remark)
        {
            this._iD = _iD;
            this._mID = _mID;
            this._valueText = _valueText;
            this._sort = _sort;
            this._image1 = _image1;
            this._remark = _remark;
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
        
        ///// <summary>
        ///// 获取或设置.
        ///// </summary>
        //[DataMember]
        //public int MID
        //{
        //    get
        //    {
        //        return this._mID;
        //    }
        //    set
        //    {
        //        this._mID=value;
        //    }
        //}        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        //[DataMember]
        //public string ValueText
        //{
        //    get
        //    {
        //        return this._valueText;
        //    }
        //    set
        //    {
        //        this._valueText=value;
        //    }
        //}
        [DataMember]
        public object Value { get; set; }
      
    
        /// <summary>
        /// 获取或设置.
        ///// </summary>
        //[DataMember]
        //public int Sort
        //{
        //    get
        //    {
        //        return this._sort;
        //    }
        //    set
        //    {
        //        this._sort=value;
        //    }
        //}        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        //[DataMember]
        //public Image Image1
        //{
        //    get
        //    {
        //        return this._image1;
        //    }
        //    set
        //    {
        //        this._image1=value;
        //    }
        //}        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        //[DataMember]
        //public string Remark
        //{
        //    get
        //    {
        //        return this._remark;
        //    }
        //    set
        //    {
        //        this._remark=value;
        //    }
        //}
        [DataMember]
        public string Caption { get; set; }

        
    }
}
