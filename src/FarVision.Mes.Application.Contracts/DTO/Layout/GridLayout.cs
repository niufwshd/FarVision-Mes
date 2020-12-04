using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Layout
{

    [Serializable]
    [DataContract]
    public class GridLayoutsDTO : BaseDTO
    {
        public GridLayoutsDTO()
        { }

        public GridLayoutDTO this[string fieldName] {
            get {
                if (Groups == null) Groups = new List<GridLayoutDTO>();
                return Groups.Find((g) => g.FieldName == fieldName); }
        
        }
        [DataMember]
        /// <summary>
        /// 
        /// </summary>
        public List<GridLayoutDTO> Groups { get;  set; }
        [DataMember]
        /// <summary>
        /// 
        /// </summary>
        public List<GridLayoutDTO> Stats { get {

            if (Groups == null) return new List<GridLayoutDTO>();
            return Groups.Where(w => w.SummaryType >= 0 && w.SummaryType <=5).ToList();
        } }
        [DataMember]
        /// <summary>
        /// 
        /// </summary>
        public List<GridLayoutDTO> Sorts { get {
            if (Groups == null) return new List<GridLayoutDTO>();
            return Groups.Where(w => w.SortIndex >= 0 && w.SortOrder > 0).ToList();

        } }
        

        public static int Compare_SortIndex(GridLayoutDTO x, GridLayoutDTO y)
        {
            return x.SortIndex.CompareTo(y.SortIndex);
        }
        public static int Compare_GroupIndex(GridLayoutDTO x, GridLayoutDTO y)
        {
            return x.GroupIndex.CompareTo(y.GroupIndex);
        }
    
    

}

    [Serializable]
    [DataContract]
    public class GridLayoutDTO : BaseDTO
    {
        public GridLayoutDTO()
        { }

        public GridLayoutDTO(string _FieldName, int _VisibleIndex, int _GroupIndex, int _SortIndex, int _SortOrder, int _Width, int _FixedStyle, int _SummaryType)
        {
            this.FieldName = _FieldName;
            this.VisibleIndex = _VisibleIndex;
            this.GroupIndex = _GroupIndex;
            this.SortIndex = _SortIndex;
            this.SortOrder = _SortOrder;
            this.Width = _Width;
            this.FixedStyle = _FixedStyle;
            this.SummaryType = _SummaryType;
       
        }
        [DataMember]
        /// <summary>
        /// 字段名称
        /// </summary>
        public string FieldName {get;set;}
        
        [DataMember]
        /// <summary>
        /// 列顺序
        /// </summary>
        public int VisibleIndex {get;set;}
        
        [DataMember]
        /// <summary>
        /// 分组顺序
        /// </summary>
        public int GroupIndex { get; set; }
       
        [DataMember]
        /// <summary>
        /// 排序顺序
        /// </summary>
        public int SortIndex {get;set;}

        [DataMember]
        /// <summary>
        /// 排序模式
        /// </summary>
        public int SortOrder { get; set; }
       
        [DataMember]
        /// <summary>
        /// 宽度
        /// </summary>
        public int Width {get;set;}
        
        [DataMember]
        /// <summary>
        /// 
        /// </summary>
        public int FixedStyle { get; set; }
       
        [DataMember]
        /// <summary>
        /// 合计信息
        /// <para>0 sum</para>
        /// <para>6 none</para>
        /// </summary>
        public int SummaryType { get; set; }

       
    }
}
