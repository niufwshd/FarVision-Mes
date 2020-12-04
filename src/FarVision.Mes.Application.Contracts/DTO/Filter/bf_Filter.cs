using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Filter
{
    [DataContract]
    public class bf_FilterDTO : BaseDTO
    {
        private int _iD;        
        private string _no;        
        private int _type;        
        private string _category;        
        private bool _isDefault;        
        private int _iUserID;        
    
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_FilterDTO()
        {


        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_type"></param>
        /// <param name="_category"></param>
        /// <param name="_isDefault"></param>
        /// <param name="_iUserID"></param>
        /// <param name="_viewData"></param>
        public bf_FilterDTO(int _iD,
                string _no,
                int _type,
                string _category,
                bool _isDefault,
                int _iUserID)
        {
            this._iD = _iD;
            this._no = _no;
            this._type = _type;
            this._category = _category;
            this._isDefault = _isDefault;
            this._iUserID = _iUserID;

        }

         ///<summary>
         ///记录ID
         ///</summary>
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
        /// 业务编号
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
        /// 0单据, 1查询, 2报表
        /// </summary>
        [DataMember]
        public int Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type=value;
            }
        }

        /// <summary>
        /// 分类
        /// </summary>
        [DataMember]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool IsDefault
        {
            get
            {
                return this._isDefault;
            }
            set
            {
                this._isDefault=value;
            }
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        [DataMember]
        public int UserID
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

        
    }
}
