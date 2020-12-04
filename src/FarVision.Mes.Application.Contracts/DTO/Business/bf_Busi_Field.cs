using WebMES.DTO.Query;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Collections.Concurrent;

namespace WebMES.DTO.Business
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class bf_Busi_FieldDTO : BaseDTO
    {
        private int _iD;
        private int _mID;
        private string _m_Name;
        private int _m_DataKind;
        private int _m_ValueControl;
        private string _m_ValueDefault;
        private bool _m_CopyAble;
        private bool _m_Concurrent;
        private bool _m_History;
        private string _m_Remark;
        private int _gc_VisibleType;
        private int _gc_VisibleIndex;
        private int _gc_Width;
        private string _gc_Format;
        private int _gc_FooterType;
        private string _gcv_Band;
        private bool _edit_Able;
        private int _edit_Type;
        private string _edit_No;
        private string _edit_Field;
        private string _edit_Condition;
        private string _edit_Associate;
        private string _edit_DisplayField;
        private bool _edit_Visible;
        //private bool _filter_Able;        
        //private string _filter_Contain;        
        //private bool _filter_Popup;        
        //private string _ft_Busi;        
        //private string _ft_Alias;        
        //private string _ft_Field;        
        //private string _ft_Condition;        
        //private string _ft_MenuNo;        
        //private string _ft_WriteBack;        
        //private int _dc_Kind;        
        //private string _dc_SQL;        
        //private int _gt_Kind;        

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Busi_FieldDTO()
        {
        }

        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_m_Name"></param>
        /// <param name="_m_DataKind"></param>
        /// <param name="_m_ValueControl"></param>
        /// <param name="_m_ValueDefault"></param>
        /// <param name="_m_CopyAble"></param>
        /// <param name="_m_Concurrent"></param>
        /// <param name="_m_History"></param>
        /// <param name="_m_Remark"></param>
        /// <param name="_gc_VisibleType"></param>
        /// <param name="_gc_VisibleIndex"></param>
        /// <param name="_gc_Width"></param>
        /// <param name="_gc_Format"></param>
        /// <param name="_gc_FooterType"></param>
        /// <param name="_gcv_Band"></param>
        /// <param name="_edit_Able"></param>
        /// <param name="_edit_Type"></param>
        /// <param name="_edit_No"></param>
        /// <param name="_edit_Field"></param>
        /// <param name="_edit_Condition"></param>
        /// <param name="_edit_Associate"></param>
        /// <param name="_edit_DisplayField"></param>
        /// <param name="_edit_Visible"></param>
        /// <param name="_filter_Able"></param>
        /// <param name="_filter_Contain"></param>
        /// <param name="_filter_Popup"></param>
        /// <param name="_ft_Busi"></param>
        /// <param name="_ft_Alias"></param>
        /// <param name="_ft_Field"></param>
        /// <param name="_ft_Condition"></param>
        /// <param name="_ft_MenuNo"></param>
        /// <param name="_ft_WriteBack"></param>
        /// <param name="_dc_Kind"></param>
        /// <param name="_dc_SQL"></param>
        /// <param name="_gt_Kind"></param>
        public bf_Busi_FieldDTO(int _iD,
                int _mID,
                string _m_Name,
                int _m_DataKind,
                int _m_ValueControl,
                string _m_ValueDefault,
                bool _m_CopyAble,
                bool _m_Concurrent,
                bool _m_History,
                string _m_Remark,
                int _gc_VisibleType,
                int _gc_VisibleIndex,
                int _gc_Width,
                string _gc_Format,
                int _gc_FooterType,
                string _gcv_Band,
                bool _edit_Able,
                int _edit_Type,
                string _edit_No,
                string _edit_Field,
                string _edit_Condition,
                string _edit_Associate,
                string _edit_DisplayField,
                bool _edit_Visible)
        //bool _filter_Able,
        //string _filter_Contain,
        //bool _filter_Popup,
        //string _ft_Busi,
        //string _ft_Alias,
        //string _ft_Field,
        //string _ft_Condition,
        //string _ft_MenuNo,
        //string _ft_WriteBack,
        //int _dc_Kind,
        //string _dc_SQL,
        //int _gt_Kind)
        {
            this._iD = _iD;
            this._mID = _mID;
            this._m_Name = _m_Name;
            this._m_DataKind = _m_DataKind;
            this._m_ValueControl = _m_ValueControl;
            this._m_ValueDefault = _m_ValueDefault;
            this._m_CopyAble = _m_CopyAble;
            this._m_Concurrent = _m_Concurrent;
            this._m_History = _m_History;
            this._m_Remark = _m_Remark;
            this._gc_VisibleType = _gc_VisibleType;
            this._gc_VisibleIndex = _gc_VisibleIndex;
            this._gc_Width = _gc_Width;
            this._gc_Format = _gc_Format;
            this._gc_FooterType = _gc_FooterType;
            this._gcv_Band = _gcv_Band;
            this._edit_Able = _edit_Able;
            this._edit_Type = _edit_Type;
            this._edit_No = _edit_No;
            this._edit_Field = _edit_Field;
            this._edit_Condition = _edit_Condition;
            this._edit_Associate = _edit_Associate;
            this._edit_DisplayField = _edit_DisplayField;
            this._edit_Visible = _edit_Visible;
            //this._filter_Able = _filter_Able;
            //this._filter_Contain = _filter_Contain;
            //this._filter_Popup = _filter_Popup;
            //this._ft_Busi = _ft_Busi;
            //this._ft_Alias = _ft_Alias;
            //this._ft_Field = _ft_Field;
            //this._ft_Condition = _ft_Condition;
            //this._ft_MenuNo = _ft_MenuNo;
            //this._ft_WriteBack = _ft_WriteBack;
            //this._dc_Kind = _dc_Kind;
            //this._dc_SQL = _dc_SQL;
            //this._gt_Kind = _gt_Kind;
        }

        /// <summary>
        /// 记录ID
        /// </summary>
        //[DataMember]
        //[ProtoMember(1)]
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

        /// <summary>
        /// 记录父ID
        /// </summary>
        //[DataMember]
        //[ProtoMember(2)]
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
        /// 字段名称
        /// </summary>
        [DataMember]
        [ProtoMember(3)]
        public string m_Name
        {
            get
            {
                return this._m_Name;
            }
            set
            {
                this._m_Name = value;
            }
        }

        /// <summary>
        /// <para>0 普通数据</para>
        /// <para>1 价格</para>
        /// <para>2 数量</para>
        /// <para>3 金额</para>
        /// </summary>
        [DataMember]
        [ProtoMember(4)]
        public int m_DataKind
        {
            get
            {
                return this._m_DataKind;
            }
            set
            {
                this._m_DataKind = value;
            }
        }

        /// <summary>
        /// <para>0 允许空(0)</para>
        /// <para>10 不允许空(0)</para>
        /// <para>20 大于0</para>
        /// <para>30 大于等于0</para>
        /// <para>40 小于0</para>
        /// <para>50 小于等于0</para>
        /// </summary>
        [DataMember]
        [ProtoMember(5)]
        public int m_ValueControl
        {
            get
            {
                return this._m_ValueControl;
            }
            set
            {
                this._m_ValueControl = value;
            }
        }

        /// <summary>
        /// 默认值
        /// </summary>
        [DataMember]
        public string m_ValueDefault
        {
            get
            {
                return this._m_ValueDefault;
            }
            set
            {
                this._m_ValueDefault = value;
            }
        }

        /// <summary>
        /// 可复制
        /// </summary>
        [DataMember]
        public bool m_CopyAble
        {
            get
            {
                return this._m_CopyAble;
            }
            set
            {
                this._m_CopyAble = value;
            }
        }

        ///// <summary>
        ///// 并发控制
        ///// </summary>
        //[DataMember]public bool m_Concurrent
        //{
        //    get
        //    {
        //        return this._m_Concurrent;
        //    }
        //    set
        //    {
        //        this._m_Concurrent=value;
        //    }
        //}

        ///// <summary>
        ///// 是否保存数据修改记录
        ///// </summary>
        //[DataMember]public bool m_History
        //{
        //    get
        //    {
        //        return this._m_History;
        //    }
        //    set
        //    {
        //        this._m_History=value;
        //    }
        //}        

        /// <summary>
        /// 获取或设置.
        /// </summary>
        //[DataMember]
        //public string m_Remark
        //{
        //    get
        //    {
        //        return this._m_Remark;
        //    }
        //    set
        //    {
        //        this._m_Remark = value;
        //    }
        //}

        /// <summary>
        /// <para>0 不可见</para>
        /// <para>1 可见</para>
        /// <para>2 置于列选择器中</para>
        /// </summary>
        //[ProtoMember(6)]
        //[DataMember]
        //public int gc_VisibleType
        //{
        //    get
        //    {
        //        return this._gc_VisibleType;
        //    }
        //    set
        //    {
        //        this._gc_VisibleType = value;
        //    }
        //}

        /// <summary>
        /// 列顺序
        /// </summary>
        [DataMember]
        [ProtoMember(7)]
        public int gc_VisibleIndex
        {
            get
            {
                return this._gc_VisibleIndex;
            }
            set
            {
                this._gc_VisibleIndex = value;
            }
        }

        /// <summary>
        /// 列宽度
        /// </summary>
        [DataMember]
        [ProtoMember(8)]
        public int gc_Width
        {
            get
            {
                return this._gc_Width;
            }
            set
            {
                this._gc_Width = value;
            }
        }

        /// <summary>
        /// 格式化语句
        /// </summary>
        [DataMember]
        [ProtoMember(9)]
        public string gc_Format
        {
            get
            {
                return this._gc_Format;
            }
            set
            {
                this._gc_Format = value;
            }
        }

        /// <summary>
        /// <para>页脚:</para>
        /// <para>0	无</para>
        /// <para>1	求和</para>
        /// <para>2	计数</para>
        /// <para>3	平均值</para>
        /// <para>4	最大值</para>
        /// <para>5	最小值</para>
        /// </summary>
        [DataMember]
        public int gc_FooterType
        {
            get
            {
                return this._gc_FooterType;
            }
            set
            {
                this._gc_FooterType = value;
            }
        }

        /// <summary>
        /// Band
        /// </summary>
        [DataMember]
        public string gcv_Band
        {
            get
            {
                return this._gcv_Band;
            }
            set
            {
                this._gcv_Band = value;
            }
        }

        ///// <summary>
        ///// 可编辑
        ///// </summary>
        //[DataMember]
        //[ProtoMember(10)]
        //public bool edit_Able
        //{
        //    get
        //    {
        //        return this._edit_Able;
        //    }
        //    set
        //    {
        //        this._edit_Able = value;
        //    }
        //}

      


        /// <summary>
        /// 编辑器类型
        /// </summary>
        [DataMember]
        public int edit_Type
        {
            get
            {
                return this._edit_Type;
            }
            set
            {
                this._edit_Type = value;
            }
        }

        /// <summary>
        /// combox,lookup,lookform,query配置号
        /// </summary>
        [DataMember]
        public string edit_No
        {
            get
            {
                return this._edit_No;
            }
            set
            {
                this._edit_No = value;
            }
        }

        /// <summary>
        /// 配置字段名称
        /// </summary>
        [DataMember]
        public string edit_Field
        {
            get
            {
                return this._edit_Field;
            }
            set
            {
                this._edit_Field = value;
            }
        }

        /// <summary>
        /// lookup,lookform,query的条件语句
        /// </summary>
        [DataMember]
        public string edit_Condition
        {
            get
            {
                return this._edit_Condition;
            }
            set
            {
                this._edit_Condition = value;
            }
        }

        /// <summary>
        /// 编辑相关字段信息
        /// </summary>
        [DataMember]
        public string edit_Associate
        {
            get
            {
                return this._edit_Associate;
            }
            set
            {
                this._edit_Associate = value;
            }
        }

        /// <summary>
        ///  lookup,lookform的显示字段
        /// </summary>
        [DataMember]
        public string edit_DisplayField
        {
            get
            {
                return this._edit_DisplayField;
            }
            set
            {
                this._edit_DisplayField = value;
            }
        }

        ///// <summary>
        ///// 显示在下拉列表列中
        ///// </summary>
        //[DataMember]
        //public bool edit_Visible
        //{
        //    get
        //    {
        //        return this._edit_Visible;
        //    }
        //    set
        //    {
        //        this._edit_Visible = value;
        //    }
        //}

        ///// <summary>
        ///// 显示在过滤搜索界面中
        ///// </summary>
        //[DataMember]public bool filter_Able
        //{
        //    get
        //    {
        //        return this._filter_Able;
        //    }
        //    set
        //    {
        //        this._filter_Able=value;
        //    }
        //}

        ///// <summary>
        ///// 含所属sql语句
        ///// </summary>
        //[DataMember]public string filter_Contain
        //{
        //    get
        //    {
        //        return this._filter_Contain;
        //    }
        //    set
        //    {
        //        this._filter_Contain=value;
        //    }
        //}

        ///// <summary>
        ///// 过滤界面中值是否可以选取
        ///// </summary>
        //[DataMember]public bool filter_Popup
        //{
        //    get
        //    {
        //        return this._filter_Popup;
        //    }
        //    set
        //    {
        //        this._filter_Popup=value;
        //    }
        //}

        /// <summary>
        /// 外表业务编号
        /// </summary>
        [DataMember]
        public string ft_Busi { get; set; }
       

        ///// <summary>
        ///// 外表别名
        ///// </summary>
        //[DataMember]public string ft_Alias
        //{
        //    get
        //    {
        //        return this._ft_Alias;
        //    }
        //    set
        //    {
        //        this._ft_Alias=value;
        //    }
        //}

        ///// <summary>
        ///// 外表列名
        ///// </summary>
        //[DataMember]public string ft_Field
        //{
        //    get
        //    {
        //        return this._ft_Field;
        //    }
        //    set
        //    {
        //        this._ft_Field=value;
        //    }
        //}

        ///// <summary>
        ///// 外表条件
        ///// </summary>
        //[DataMember]public string ft_Condition
        //{
        //    get
        //    {
        //        return this._ft_Condition;
        //    }
        //    set
        //    {
        //        this._ft_Condition=value;
        //    }
        //}

        /// <summary>
        /// 穿透查询菜单号
        /// </summary>
        [DataMember]
        public string ft_MenuNo { get; set; }


        ///// <summary>
        ///// 回写字段配置
        ///// </summary>
        //[DataMember]public string ft_WriteBack
        //{
        //    get
        //    {
        //        return this._ft_WriteBack;
        //    }
        //    set
        //    {
        //        this._ft_WriteBack=value;
        //    }
        //}

        /// <summary>
        /// <para>虚拟列类别</para>
        /// <para>0 无</para>
        /// <para>1 计算列</para>
        /// <para>2 SQL列</para>
        /// </summary>
        [DataMember]
        public int dc_Kind { get; set; }


        ///// <summary>
        ///// 自定义SQL
        ///// </summary>
        //[DataMember]public string dc_SQL
        //{
        //    get
        //    {
        //        return this._dc_SQL;
        //    }
        //    set
        //    {
        //        this._dc_SQL=value;
        //    }
        //}        

        ///// <summary>
        ///// 获取或设置.
        ///// </summary>
        //[DataMember]public int gt_Kind
        //{
        //    get
        //    {
        //        return this._gt_Kind;
        //    }
        //    set
        //    {
        //        this._gt_Kind=value;
        //    }
        //}

        /// <summary>
        /// 用户设置的可见性
        /// </summary>
        [DataMember]
        public int VisibleCustom { get; set; }

        /// <summary>
        /// <para>0 不可见</para>
        /// <para>1 可见</para>
        /// <para>2 置于列选择器中</para>
        [DataMember]
        [ProtoMember(12)]
        public int VisibleType { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [DataMember]
        //[ProtoMember(13, DynamicType = true)]
        [ProtoMember(13)]
        public object DefaultValue { get; set; }

        /// <summary>
        /// 显示格式
        /// </summary>
        [DataMember]
        [ProtoMember(14)]
        public string Format { get; set; }

        // /// <summary>
        ///// 用户设置的格式
        ///// </summary>
        //[DataMember]
        //public string FormatCustom { get; set; }
        [DataMember]
        [ProtoMember(15)]
        public bool Editable { get; set; }

        ///// <summary>
        ///// 是否为重要字段
        ///// </summary>
        //[DataMember]
        //[ProtoMember(16)]
        //public bool bImportant { get; set; }

        [DataMember]
        [ProtoMember(17)]
        public string Caption { get; set; }


        [DataMember]
        public FieldEditorType Editor { get { return (FieldEditorType)this.edit_Type; } set { this.edit_Type = (int)value; } }
        [DataMember]
        [ProtoMember(18)]
        public DbType DbType { get; set; }
        [DataMember]
        public string billNoID { get; set; }

        [DataMember]
        public bool edit_Multiselect { get; set; }

        [DataMember]
        public bool filter_Able { get; set; }

        [DataMember]
        public string edit_MutiselDeal { get; set; }

         [DataMember]
        public string oriFieldName { get; set; }

        private ConcurrentDictionary<string, string> m_LookupConditions;

        [DataMember]
        public ConcurrentDictionary<string, string> LookupConditions { get; set; }

        private ConcurrentDictionary<string, string> m_LookupAssociates;
        /// <summary>
        /// 相关字段赋值信息
        /// </summary>
        [DataMember]
        public ConcurrentDictionary<string, string> LookupAssociates { get; set; }
        [DataMember]
        public bf_ComboxItemDTO[] comboxItems { get; set; }
    }
}
