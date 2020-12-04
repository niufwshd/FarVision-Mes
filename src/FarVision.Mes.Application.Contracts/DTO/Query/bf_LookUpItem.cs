using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Query
{
    [DataContract]
    public class bf_LookUpItemDTO : BaseDTO
    {
        private int _iD;        
        private int _mID;        
        private string _name;        
        private string _caption;        
        private int _sort;        
        private int _width;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_LookUpItemDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_name"></param>
        /// <param name="_caption"></param>
        /// <param name="_sort"></param>
        /// <param name="_width"></param>
        public bf_LookUpItemDTO(int _iD,
                int _mID,
                string _name,
                string _caption,
                int _sort,
                int _width)
        {
            this._iD = _iD;
            this._mID = _mID;
            this._name = _name;
            this._caption = _caption;
            this._sort = _sort;
            this._width = _width;
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
        public string Caption
        {
            get
            {
                return this._caption;
            }
            set
            {
                this._caption=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
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
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width=value;
            }
        }
    }
}
