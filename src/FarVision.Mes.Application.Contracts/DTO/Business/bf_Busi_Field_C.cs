using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Business
{
    [DataContract]
    public class bf_Busi_Field_CDTO : BaseDTO
    {
        private int _iD;        
        private string _m_BusiNo;        
        private string _m_Name;        
        private bool _m_ValueControl;        
        private string _m_ValueDefault;        
        private bool _m_History;        
        private bool _gc_Visible;        
        private string _gc_Format;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Busi_Field_CDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_m_BusiNo"></param>
        /// <param name="_m_Name"></param>
        /// <param name="_m_ValueControl"></param>
        /// <param name="_m_ValueDefault"></param>
        /// <param name="_m_History"></param>
        /// <param name="_gc_Visible"></param>
        /// <param name="_gc_Format"></param>
        public bf_Busi_Field_CDTO(int _iD,
                string _m_BusiNo,
                string _m_Name,
                bool _m_ValueControl,
                string _m_ValueDefault,
                bool _m_History,
                bool _gc_Visible,
                string _gc_Format)
        {
            this._iD = _iD;
            this._m_BusiNo = _m_BusiNo;
            this._m_Name = _m_Name;
            this._m_ValueControl = _m_ValueControl;
            this._m_ValueDefault = _m_ValueDefault;
            this._m_History = _m_History;
            this._gc_Visible = _gc_Visible;
            this._gc_Format = _gc_Format;
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
        public string M_BusiNo
        {
            get
            {
                return this._m_BusiNo;
            }
            set
            {
                this._m_BusiNo=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string M_Name
        {
            get
            {
                return this._m_Name;
            }
            set
            {
                this._m_Name=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool M_ValueControl
        {
            get
            {
                return this._m_ValueControl;
            }
            set
            {
                this._m_ValueControl=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string M_ValueDefault
        {
            get
            {
                return this._m_ValueDefault;
            }
            set
            {
                this._m_ValueDefault=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool M_History
        {
            get
            {
                return this._m_History;
            }
            set
            {
                this._m_History=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public bool Gc_Visible
        {
            get
            {
                return this._gc_Visible;
            }
            set
            {
                this._gc_Visible=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string Gc_Format
        {
            get
            {
                return this._gc_Format;
            }
            set
            {
                this._gc_Format=value;
            }
        }
    }
}
