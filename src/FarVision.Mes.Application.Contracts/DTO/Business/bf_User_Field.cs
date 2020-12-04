using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Business
{
    [DataContract]
    public class bf_User_FieldDTO : BaseDTO
    {
        private int _iD;        
        private string _no;        
        private int _type;        
        private string _m_Name;        
        private string _m_Caption;        
        private string _m_Remark;        
        private int _edit_Type;        
        private string _edit_No;        
        private int _gc_Sort;        
        private string _gc_Format;        
        private string _ft_Busi;        
        private bool _dc_Real;        
        private int _dc_DataType;        
        private int _dc_DataLength;        
        private int _dc_Kind;        
        private string _dc_SQL;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_User_FieldDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_type"></param>
        /// <param name="_m_Name"></param>
        /// <param name="_m_Caption"></param>
        /// <param name="_m_Remark"></param>
        /// <param name="_edit_Type"></param>
        /// <param name="_edit_No"></param>
        /// <param name="_gc_Sort"></param>
        /// <param name="_gc_Format"></param>
        /// <param name="_ft_Busi"></param>
        /// <param name="_dc_Real"></param>
        /// <param name="_dc_DataType"></param>
        /// <param name="_dc_DataLength"></param>
        /// <param name="_dc_Kind"></param>
        /// <param name="_dc_SQL"></param>
        public bf_User_FieldDTO(int _iD,
                string _no,
                int _type,
                string _m_Name,
                string _m_Caption,
                string _m_Remark,
                int _edit_Type,
                string _edit_No,
                int _gc_Sort,
                string _gc_Format,
                string _ft_Busi,
                bool _dc_Real,
                int _dc_DataType,
                int _dc_DataLength,
                int _dc_Kind,
                string _dc_SQL)
        {
            this._iD = _iD;
            this._no = _no;
            this._type = _type;
            this._m_Name = _m_Name;
            this._m_Caption = _m_Caption;
            this._m_Remark = _m_Remark;
            this._edit_Type = _edit_Type;
            this._edit_No = _edit_No;
            this._gc_Sort = _gc_Sort;
            this._gc_Format = _gc_Format;
            this._ft_Busi = _ft_Busi;
            this._dc_Real = _dc_Real;
            this._dc_DataType = _dc_DataType;
            this._dc_DataLength = _dc_DataLength;
            this._dc_Kind = _dc_Kind;
            this._dc_SQL = _dc_SQL;
        }

        /// <summary>
        /// 记录ID
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
        /// 框架对象编号
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
        /// 字段名称
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
        /// 英文
        /// </summary>
        [DataMember]
        public string M_Caption
        {
            get
            {
                return this._m_Caption;
            }
            set
            {
                this._m_Caption=value;
            }
        }

        /// <summary>
        /// 备注
        /// </summary>
        [DataMember]
        public string M_Remark
        {
            get
            {
                return this._m_Remark;
            }
            set
            {
                this._m_Remark=value;
            }
        }

        /// <summary>
        /// 编辑器类型
        /// </summary>
        [DataMember]
        public int Edit_Type
        {
            get
            {
                return this._edit_Type;
            }
            set
            {
                this._edit_Type=value;
            }
        }

        /// <summary>
        /// combox,lookup,lookform,query配置号
        /// </summary>
        [DataMember]
        public string Edit_No
        {
            get
            {
                return this._edit_No;
            }
            set
            {
                this._edit_No=value;
            }
        }

        /// <summary>
        /// 顺序
        /// </summary>
        [DataMember]
        public int Gc_Sort
        {
            get
            {
                return this._gc_Sort;
            }
            set
            {
                this._gc_Sort=value;
            }
        }

        /// <summary>
        /// 格式化语句
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

        /// <summary>
        /// 外表表名
        /// </summary>
        [DataMember]
        public string Ft_Busi
        {
            get
            {
                return this._ft_Busi;
            }
            set
            {
                this._ft_Busi=value;
            }
        }

        /// <summary>
        /// 真实的存储列
        /// </summary>
        [DataMember]
        public bool Dc_Real
        {
            get
            {
                return this._dc_Real;
            }
            set
            {
                this._dc_Real=value;
            }
        }

        /// <summary>
        /// 数据类型
        /// </summary>
        [DataMember]
        public int Dc_DataType
        {
            get
            {
                return this._dc_DataType;
            }
            set
            {
                this._dc_DataType=value;
            }
        }

        /// <summary>
        /// 数据长度
        /// </summary>
        [DataMember]
        public int Dc_DataLength
        {
            get
            {
                return this._dc_DataLength;
            }
            set
            {
                this._dc_DataLength=value;
            }
        }

        /// <summary>
        /// <para>虚拟列类别</para>
        /// <para>0 无</para>
        /// <para>1 计算列</para>
        /// <para>2 SQL列</para>
        /// </summary>
        [DataMember]
        public int Dc_Kind
        {
            get
            {
                return this._dc_Kind;
            }
            set
            {
                this._dc_Kind=value;
            }
        }

        /// <summary>
        /// 自定义SQL
        /// </summary>
        [DataMember]
        public string Dc_SQL
        {
            get
            {
                return this._dc_SQL;
            }
            set
            {
                this._dc_SQL=value;
            }
        }
    }
}
