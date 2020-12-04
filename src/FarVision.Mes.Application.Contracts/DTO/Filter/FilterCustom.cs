using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Filter
{
    [DataContract]
    public class filterConditions
    {
        [DataMember]
        public List<FilterCustomDTO> filterCustom { get; set; }
         [DataMember]
        public string custParams { get; set; }

       
    }


    [DataContract]
    public class FilterCustomDTO : BaseDTO,ICloneable
    {
        public FilterCustomDTO()
        { }

        public FilterCustomDTO(string caption,
            string fieldName,
            string ownerAlias,
            int logicID,
            int operateID,
            object value,
            object value2,
            int sort,
            bool bracketLeft,
            bool bracketRight,
            bool enabled
            )
        
        {
            this.Caption = caption;
            this.FieldName = fieldName;
            this.OwnerAlias = ownerAlias;
            this.LogicID = logicID;
            this.OperateID = operateID;
            this.Value = value;
            this.Value2 = Value2;
            this.Sort = sort;
            this.BracketLeft = bracketLeft;
            this.BracketRight = bracketRight;
            this.Enabled = enabled;
        
        }


        #region 属性(存储字段)
        [DataMember]
        public string Caption{get;set;}
        

        /// <summary>
        /// 字段名称
        /// </summary>
        [DataMember]
        public string FieldName { get; set; }
       
        /// <summary>
        /// 拥有者别名
        /// </summary>
        [DataMember]
        public string OwnerAlias { get; set; }
       
        /// <summary>
        /// 逻辑符号(0[And];1[Or])
        /// </summary>
        [DataMember]
        public int LogicID { get; set; }
        
        /// <summary>
        /// 运算符
        /// (0[=];1[≠];2[介于];10[＞];11[≥];12[＜];13[≤])
        /// (20[like %x%];21[like x%];22[like %x])
        /// (30[in];31[not in];32[Contain])
        /// (40[本周];41[上周];42[本月];43[上月];44[本年];45[上年];46[前n周];47[前n月];48[前n年])
        /// </summary>
        [DataMember]
        public int OperateID { get; set; }
      
        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        public object Value { get; set; }
        
        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        public object Value2 { get; set; }
        
        /// <summary>
        /// 顺序
        /// </summary>
        [DataMember]
        public int Sort { get; set; }
        
        /// <summary>
        /// 左括号
        /// </summary>
        [DataMember]
        public bool BracketLeft { get; set; }
       
        /// <summary>
        /// 右括号
        /// </summary>
        [DataMember]
        public bool BracketRight { get; set; }
       
        /// <summary>
        /// 启用
        /// </summary>
        [DataMember]
        public bool Enabled { get; set; }


        /// <summary>
        /// 不保存,默认false即保存
        /// </summary>
        [DataMember]
        public bool NotSave { get; set; }
         
        [DataMember]
        public int DbType { get; set; }

         [DataMember]
         public string DateFormat { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
        #endregion
    }
}
