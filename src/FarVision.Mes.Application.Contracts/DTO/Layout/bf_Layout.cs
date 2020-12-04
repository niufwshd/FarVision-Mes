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
    public class bf_LayoutDTO : BaseDTO
    {
       private int _iD;        
        private string _no;        
        private int _type;        
        private string _category;         
      
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_LayoutDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_no"></param>
        /// <param name="_type"></param>
        /// <param name="_category"></param>
        /// <param name="_iUserID"></param>
        /// <param name="_viewData"></param>
        public bf_LayoutDTO(int _iD,
                string _no,
                int _type,
                string _category,
                int _iUserID)
        {
            this._iD = _iD;
            this._no = _no;
            this._type = _type;
            this._category = _category;

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
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string UsrNo { get; set; }
      
        


        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        public string ViewJSonData { get; set; }
        

        /// <summary>
        /// 
        /// </summary>
        //[DataMember]
        //public GridLayoutsDTO GridLayoutsDTO { get; set; }
    }
}
