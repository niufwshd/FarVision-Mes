using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Menu
{
           [DataContract]
    public class bf_Menu_OftenDTO : BaseDTO
    {
         private int _iD;        
        private string _menuNo;        
        private int _userID;        
        private int _sort;        
        private bool _beginGroup;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Menu_OftenDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_menuNo"></param>
        /// <param name="_userID"></param>
        /// <param name="_sort"></param>
        /// <param name="_beginGroup"></param>
        public bf_Menu_OftenDTO(int _iD,
                string _menuNo,
                int _userID,
                int _sort,
                bool _beginGroup)
        {
            this._iD = _iD;
            this._menuNo = _menuNo;
            this._userID = _userID;
            this._sort = _sort;
            this._beginGroup = _beginGroup;
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
        /// 菜单编号
        /// </summary>
        [DataMember]
        public string MenuNo
        {
            get
            {
                return this._menuNo;
            }
            set
            {
                this._menuNo=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public int UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                this._userID=value;
            }
        }

        /// <summary>
        /// 顺序
        /// </summary>
        [DataMember]
        public int Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this._sort=value;
            }
        }

        /// <summary>
        /// 显示分组横线
        /// </summary>
        [DataMember]
        public bool BeginGroup
        {
            get
            {
                return this._beginGroup;
            }
            set
            {
                this._beginGroup=value;
            }
        }
    }
}
