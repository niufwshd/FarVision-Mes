using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Filter
{
    [DataContract]
    public class bf_Filter_OperDTO : BaseDTO
    {
         private int _iD;        
        private int _operID;        
        private string _name;        
        private int _sort;
        private string _caption;
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Filter_OperDTO()
        {
        }        
        
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_operID"></param>
        /// <param name="_name"></param>
        /// <param name="_sort"></param>
        public bf_Filter_OperDTO(int _iD,
                int _operID,
                string _name,
                int _sort)
        {
            this._iD = _iD;
            this._operID = _operID;
            this._name = _name;
            this._sort = _sort;
        }

        ///// <summary>
        ///// 记录ID
        ///// </summary>
        //[DataMember]
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
        /// 运算符
        /// <para>0[=];1[≠]; 2[介于];</para>
        /// <para>10[＞]; 11[≥]; 12[＜]; 13[≤];</para>
        /// <para>20[like %x%]; 21[like x%]; 22[like %x]</para>
        /// <para>30[in]; 31[not in]; 32[含所属]</para>
        /// <para>70[本日];71[昨日]</para>   20160328
        /// <para>40[本周]; 41[上周];</para>
        /// <para>42[本月]; 43[上月];</para>
        /// <para>44[本年]; 45[上年];</para>
        /// <para>39[前n天];  46[前n周]; 47[前n月]; 48[前n年]</para>    
        ///<para>56[后n天]; 57[后n周];58[后n月]; 59[后n年]</para>  20160328
        /// <para>60[空]; 61[非空]</para>
        /// </summary>
        [DataMember]
        public int OperID
        {
            get
            {
                return this._operID;
            }
            set
            {
                this._operID=value;
            }
        }        
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
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
        
        /// <summary>
        /// 获取或设置.
        /// </summary>
        [DataMember]
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

        [DataMember]
        public string Caption
        {
            get { return this._caption; }
            set { this._caption = value; }
        }
    }
}
