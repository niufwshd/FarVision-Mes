using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Menu
{
       [DataContract]
       [ProtoContract]
    public class bf_MenuDTO : BaseDTO
    {
        private int _iD;        
        private int _parentID;        
        private string _no;        
        private string _regNo;        
        private string _regKey;        
        private int _sort;        
        private string _busiNo;        
        private string _assemblyName;        
        private string _className;        
        private string _bSUrl;        
        private int _executeType;        
        private int _toolBarSort;        
        private bool _toolBarGroup;        
        private bool _enabled;        
        private bool _isFrame;
        private Image _image1;
        private Image _bSImage;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_MenuDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_parentID"></param>
        /// <param name="_no"></param>
        /// <param name="_regNo"></param>
        /// <param name="_regKey"></param>
        /// <param name="_sort"></param>
        /// <param name="_busiNo"></param>
        /// <param name="_assemblyName"></param>
        /// <param name="_className"></param>
        /// <param name="_bSUrl"></param>
        /// <param name="_executeType"></param>
        /// <param name="_toolBarSort"></param>
        /// <param name="_toolBarGroup"></param>
        /// <param name="_enabled"></param>
        /// <param name="_isFrame"></param>
        /// <param name="_image1"></param>
        /// <param name="_bSImage"></param>
        public bf_MenuDTO(int _iD,
                int _parentID,
                string _no,
                string _regNo,
                string _regKey,
                int _sort,
                string _busiNo,
                string _assemblyName,
                string _className,
                string _bSUrl,
                int _executeType,
                int _toolBarSort,
                bool _toolBarGroup,
                bool _enabled,
                bool _isFrame,
                Image _image1,
                Image _bSImage)
        {
            this._iD = _iD;
            this._parentID = _parentID;
            this._no = _no;
            this._regNo = _regNo;
            this._regKey = _regKey;
            this._sort = _sort;
            this._busiNo = _busiNo;
            this._assemblyName = _assemblyName;
            this._className = _className;
            this._bSUrl = _bSUrl;
            this._executeType = _executeType;
            this._toolBarSort = _toolBarSort;
            this._toolBarGroup = _toolBarGroup;
            this._enabled = _enabled;
            this._isFrame = _isFrame;
            this._image1 = _image1;
            this._bSImage = _bSImage;
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        [ProtoMember(1)]
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
        /// 父项ID
        /// </summary>
        [DataMember]
        [ProtoMember(2)]
        public int ParentID
        {
            get
            {
                return this._parentID;
            }
            set
            {
                this._parentID=value;
            }
        }

        /// <summary>
        /// 菜单编号
        /// </summary>
        [DataMember]
        [ProtoMember(3)]
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


        [DataMember]
        public string RegNo
        {
            get
            {
                return this._regNo;
            }
            set
            {
                this._regNo=value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string RegKey
        {
            get
            {
                return this._regKey;
            }
            set
            {
                this._regKey=value;
            }
        }        
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [ProtoMember(4)]
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
        /// 业务编号
        /// </summary>
        [DataMember]
        [ProtoMember(5)]
        public string BusiNo
        {
            get
            {
                return this._busiNo;
            }
            set
            {
                this._busiNo=value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [ProtoMember(6)]
        public string AssemblyName
        {
            get
            {
                return this._assemblyName;
            }
            set
            {
                this._assemblyName=value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [ProtoMember(7)]
        public string ClassName
        {
            get
            {
                return this._className;
            }
            set
            {
                this._className=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string BSUrl
        {
            get
            {
                return this._bSUrl;
            }
            set
            {
                this._bSUrl=value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [ProtoMember(8)]
        public int ExecuteType
        {
            get
            {
                return this._executeType;
            }
            set
            {
                this._executeType=value;
            }
        }

        /// <summary>
        /// 显示在Toolbar中的顺序(-1表示不显示)
        /// </summary>
        [DataMember]
        public int ToolBarSort
        {
            get
            {
                return this._toolBarSort;
            }
            set
            {
                this._toolBarSort=value;
            }
        }

        /// <summary>
        /// 显示在Toolbar中是否分组
        /// </summary>
        [DataMember]
        public bool ToolBarGroup
        {
            get
            {
                return this._toolBarGroup;
            }
            set
            {
                this._toolBarGroup=value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        [ProtoMember(9)]
        public bool Enabled
        {
            get
            {
                return this._enabled;
            }
            set
            {
                this._enabled=value;
            }
        }

        /// <summary>
        /// 框架菜单
        /// </summary>
        [DataMember]
        public bool IsFrame
        {
            get
            {
                return this._isFrame;
            }
            set
            {
                this._isFrame=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
   
        public Image Image1
        {
            get
            {
                return this._image1;
            }
            set
            {
                this._image1=value;
            }
        }

        [ProtoMember(10)]
        public byte[] Image1Bits
        {
            get;
            set;

        }
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public Image BSImage
        {
            get
            {
                return this._bSImage;
            }
            set
            {
                this._bSImage=value;
            }
        }
        [DataMember]
        [ProtoMember(11)]
        public string Caption { get; set; }
        [DataMember]
        [ProtoMember(12)]
        public string WorkSystem { get; set; }

        [DataMember]
        [ProtoMember(13)]
        public string CUS_NO { get; set; }
        public object Addin { get; set; }

        public string BSImg { get; set; }

        
    }
}
