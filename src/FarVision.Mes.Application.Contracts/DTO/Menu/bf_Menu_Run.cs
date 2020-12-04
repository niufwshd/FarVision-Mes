using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Menu
{
    [DataContract]
    public class bf_Menu_RunDTO : BaseDTO
    {
        private int _iD;        
        private string _menuNo;        
        private int _interval;        
        private int _userID;
        private string _WorkSystem;
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Menu_RunDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_menuNo"></param>
        /// <param name="_interval"></param>
        /// <param name="_userID"></param>
        public bf_Menu_RunDTO(int _iD,
                string _menuNo,
                int _interval,
                int _userID)
        {
            this._iD = _iD;
            this._menuNo = _menuNo;
            this._interval = _interval;
            this._userID = _userID;
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
        public int Interval
        {
            get
            {
                return this._interval;
            }
            set
            {
                this._interval=value;
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
        [DataMember]
        public string WorkSystem { get; set; }

       

    }
}
