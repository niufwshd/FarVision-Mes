/**********************************************
** Class_Kind:      DotNet Entity Class
** Creater:         Entity Class Generator
** Create Date:     2016-06-08 17:27:31
** Description:     Entity Class
** Version:         Entity Class Generator 1.0.0
**********************************************/
using System;
using System.Data;
using System.Configuration;
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace WebMES.DTO.Business
{
    [Serializable]
    [DataContract]
    /// <summary>
    ///
    /// </summary>
    public class bf_BusiDTO : BaseDTO
    {

        private int _iD;
        private int _parentID;
        private int _type;
        private bool _frame;
        private string _no;
        private string _noBase;
        private string _kind;
        private string _tableName;
        private string _condition;
        private string _sortString;
        private int _rowCount;
        private string _queryNo;
        private DateTime _inputDate;
        private string _dBType;

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_BusiDTO()
        {
           
        }
       
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_parentID"></param>
        /// <param name="_type"></param>
        /// <param name="_frame"></param>
        /// <param name="_no"></param>
        /// <param name="_noBase"></param>
        /// <param name="_kind"></param>
        /// <param name="_tableName"></param>
        /// <param name="_condition"></param>
        /// <param name="_sortString"></param>
        /// <param name="_rowCount"></param>
        /// <param name="_queryNo"></param>
        /// <param name="_inputDate"></param>
        /// <param name="_dBType"></param>
        public bf_BusiDTO(int _iD,
                int _parentID,
                int _type,
                bool _frame,
                string _no,
                string _noBase,
                string _kind,
                string _tableName,
                string _condition,
                string _sortString,
                int _rowCount,
                string _queryNo,
                DateTime _inputDate,
                string _dBType)
        {
            this._iD = _iD;
            this._parentID = _parentID;
            this._type = _type;
            this._frame = _frame;
            this._no = _no;
            this._noBase = _noBase;
            this._kind = _kind;
            this._tableName = _tableName;
            this._condition = _condition;
            this._sortString = _sortString;
            this._rowCount = _rowCount;
            this._queryNo = _queryNo;
            this._inputDate = _inputDate;
            this._dBType = _dBType;
           
        }

        /// <summary>
        /// 记录ID
        /// </summary>
        //[DataMember] 
        //public int ID
        //{
        //    get
        //    {
        //        return this._iD;
        //    }
        //    set
        //    {
        //        this._iD = value;
        //    }
        //}

        /// <summary>
        /// 父ID
        /// </summary>
       [DataMember] 
        public int ParentID
        {
            get
            {
                return this._parentID;
            }
            set
            {
                this._parentID = value;
            }
        }

        //[DataMember] 
        //public int Type
        //{
        //    get
        //    {
        //        return this._type;
        //    }
        //    set
        //    {
        //        this._type = value;
        //    }
        //}
        ///// <summary>
        ///// 是否为框架数据表
        ///// </summary>
        //[DataMember] 
        //public bool Frame
        //{
        //    get
        //    {
        //        return this._frame;
        //    }
        //    set
        //    {
        //        this._frame = value;
        //    }
        //}

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
                this._no = value;
            }
        }
        /// <summary>
        /// 来源业务编号
        /// </summary>
       [DataMember] 
        public string NoBase
        {
            get
            {
                return this._noBase;
            }
            set
            {
                this._noBase = value;
            }
        }
       ///// <summary>
       ///// 类型
       ///// </summary>
       // [DataMember] 
       // public string Kind
       // {
       //     get
       //     {
       //         return this._kind;
       //     }
       //     set
       //     {
       //         this._kind = value;
       //     }
       // }
        /// <summary>
        /// 不含数据前缀的表名称
        /// </summary>
       [DataMember] 
        public string TableName
        {
            get
            {
                return this._tableName;
            }
            set
            {
                this._tableName = value;
            }
        }
       ///// <summary>
       ///// 默认条件语句
       ///// </summary>
       // [DataMember] 
       // public string Condition
       // {
       //     get
       //     {
       //         return this._condition;
       //     }
       //     set
       //     {
       //         this._condition = value;
       //     }
       // }
        ///// <summary>
        ///// 排序字段值
        ///// </summary>
        //[DataMember] 
        //public string SortString
        //{
        //    get
        //    {
        //        return this._sortString;
        //    }
        //    set
        //    {
        //        this._sortString = value;
        //    }
        //}
        /// <summary>
        /// 默认查询行数
        /// </summary>
       [DataMember] 
        public int RowCount
        {
            get
            {
                return this._rowCount;
            }
            set
            {
                this._rowCount = value;
            }
        }
       /// <summary>
       /// 查询编号
       /// </summary>
        [DataMember] 
        public string QueryNo
        {
            get
            {
                return this._queryNo;
            }
            set
            {
                this._queryNo = value;
            }
        }

        //[DataMember] 
        //public DateTime InputDate
        //{
        //    get
        //    {
        //        return this._inputDate;
        //    }
        //    set
        //    {
        //        this._inputDate = value;
        //    }
        //}

        //[DataMember] 
        //public string DBType
        //{
        //    get
        //    {
        //        return this._dBType;
        //    }
        //    set
        //    {
        //        this._dBType = value;
        //    }
        //}
        [DataMember]
        public string Caption { get; set; }
        //[DataMember]
        //public List<string> CopyFieldNames { get; set; }

        /// <summary>
        /// 视图sql语句
        /// </summary>
       // [DataMember]
       // public string ViewSqlString { get; set; }
    }
}