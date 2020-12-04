using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Layout
{

    [DataContract]
    public class VGridLayoutsDTO : BaseDTO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public VGridLayoutDTO this[string fieldName] { get { return TopItems.Find((g) => g.Name == fieldName); } }
        /// <summary>
        /// 
        /// </summary>
        public List<VGridLayoutDTO> TopItems { get; internal set; }
     
    
    }

    [DataContract]
    public class VGridLayoutDTO : BaseDTO
    {
        public VGridLayoutDTO()
        { }

        public VGridLayoutDTO(string _Name, string _ParentName, bool _Visible, bool _Expanded, bool _IsCategoryCustom, int _Heigh, int _FixedStyle)
        {
            this.Name = _Name;
            this.ParentName = _ParentName;
            this.Visible = _Visible;
            this.Expanded = _Expanded;
            this.IsCategoryCustom = _IsCategoryCustom;
            this.Height = _Heigh;
            this.FixedStyle = _FixedStyle;
        
        }
         [DataMember]
        /// <summary>
        /// 名称
        /// </summary>
        public string Name  {get;set;}
       
         [DataMember]
        /// <summary>
        /// 父项名称
        /// </summary>
        public string ParentName {get;set;}
       
         [DataMember]
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool Visible  {get;set;}
       
         [DataMember]
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool Expanded  {get;set;}
    
         [DataMember]
        /// <summary>
        /// 是否自定义分组项
        /// </summary>
        public bool IsCategoryCustom  {get;set;}
        
         [DataMember]
        /// <summary>
        /// 高度
        /// </summary>
        public int Height  {get;set;}
       
         [DataMember]
        /// <summary>
        /// 
        /// </summary>
        public int FixedStyle  {get;set;}
        
    }
}
