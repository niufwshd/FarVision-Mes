using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;

namespace WebMES.Model.SystemModel.Filter
{
    [Serializable]
    /// <summary>
    /// 数据权限
    /// </summary>
    public class FilterRule
    {
        //public FilterRule()
        //{
        //    fieldInfo = new List<FilterFields>();
        //}
        //public List<FilterFields> fieldInfo { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        
        public string Caption { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        
        public string FieldName { get; set; }

        /// <summary>
        /// 是数据库字段
        /// </summary>
        
        public bool IsDataTableField { get; set; }

        /// <summary>
        /// 拥有者别名
        /// </summary>
        
        public string OwnerAlias { get; set; }

        
        public string FieldName_Key
        {
            get
            {
                if (IsDataTableField && !string.IsNullOrEmpty(OwnerAlias))
                {
                    return $"{OwnerAlias}_{FieldName}";
                }
                return FieldName;
            }
        }

        /// <summary>
        /// 逻辑符号(0[And];1[Or])
        /// </summary>
        
        public int LogicID { get; set; }

        /// <summary>
        /// 运算符
        /// (0[=];1[≠];2[介于];10[＞];11[≥];12[＜];13[≤])
        /// (20[like %x%];21[like x%];22[like %x])
        /// (30[in];31[not in];32[Contain])
        /// (40[本周];41[上周];42[本月];43[上月];44[本年];45[上年];46[前n周];47[前n月];48[前n年])
        /// </summary>
        public int OperateID { get; set; }

        /// 值
        /// </summary>
        
        public object Value { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        
        public object Value2 { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        
        public int Sort { get; set; }


        /// <summary>
        /// 启用
        /// </summary>
        
        public bool Enabled { get; set; }

        
        public DbType DbType { get; set; }

        
        public string DateFormat { get; set; }

    }
    [Serializable]
    public class FilterFields
    {
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public DbType DbType { get; set; }
        public string DateFormat { get; set; }
        public string Format { get; set; }
        public int edit_Type { get; set; }
        public string edit_No { get; set; }
        public string edit_Field { get; set; }
        public string edit_Condition { get; set; }
        public string edit_Multiselect { get; set; }
        public string edit_DisplayField { get; set; }
    }
}
