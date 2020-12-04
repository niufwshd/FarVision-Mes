using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Business
{
    [DataContract]
    public class bf_Busi_UniqueDTO : BaseDTO
    {
         private int _iD;        
        private int _mID;        
        private string _groupNo;        
        private string _fieldName;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Busi_UniqueDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_groupNo"></param>
        /// <param name="_fieldName"></param>
        public bf_Busi_UniqueDTO(int _iD,
                int _mID,
                string _groupNo,
                string _fieldName)
        {
            this._iD = _iD;
            this._mID = _mID;
            this._groupNo = _groupNo;
            this._fieldName = _fieldName;
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
        public string GroupNo
        {
            get
            {
                return this._groupNo;
            }
            set
            {
                this._groupNo=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string FieldName
        {
            get
            {
                return this._fieldName;
            }
            set
            {
                this._fieldName=value;
            }
        }
    }
}
