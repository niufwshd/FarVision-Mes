using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Lang
{
    [DataContract]
    public class bf_LangDTO : BaseDTO
    {
        private int _iD;        
        private string _no;        
        private string _engName;        
        private string _name;        
        private string _langField;        
        private bool _design;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_LangDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_engName"></param>
        /// <param name="_name"></param>
        /// <param name="_langField"></param>
        /// <param name="_design"></param>
        public bf_LangDTO(int _iD,
                string _no,
                string _engName,
                string _name,
                string _langField,
                bool _design)
        {
            this._iD = _iD;
            this._no = _no;
            this._engName = _engName;
            this._name = _name;
            this._langField = _langField;
            this._design = _design;
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
        public string EngName
        {
            get
            {
                return this._engName;
            }
            set
            {
                this._engName=value;
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
        public string LangField
        {
            get
            {
                return this._langField;
            }
            set
            {
                this._langField=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool Design
        {
            get
            {
                return this._design;
            }
            set
            {
                this._design=value;
            }
        }
    }
}
