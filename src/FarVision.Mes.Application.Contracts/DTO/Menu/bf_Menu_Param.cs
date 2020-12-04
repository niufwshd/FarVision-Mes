using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Menu
{
    [DataContract]
    [ProtoContract]
    public class bf_Menu_ParamDTO : BaseDTO
    {
      //  private int _iD;        
      //  private int _mID;        
        private string _name;
        private object _value;
        private int _sort;        

        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Menu_ParamDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_name"></param>
        /// <param name="_valueText"></param>
        /// <param name="_valueType"></param>
        /// <param name="_sort"></param>
        public bf_Menu_ParamDTO(int _iD,
                int _mID,
                string _name,
                object _value,
                int _sort)
        {
          //  this._iD = _iD;
           // this._mID = _mID;
            this._name = _name;
            this._value = _value;
            this._sort = _sort;
        }        
        
        /// <summary>
        /// 获取或设置.
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
        /// 获取或设置.
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
        /// 获取或设置.
        /// </summary>
        [DataMember]
        [ProtoMember(3)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name=value;
            }
        }        
        
        
        [DataMember]
        [ProtoMember(4)]
        public object Value { get; set; }
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
        [ProtoMember(5)]
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
    }
}
