using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Business
{
    [DataContract]
    public class bf_Busi_BandDTO:BaseDTO
    {
         private int _iD;        
        private int _mID;        
        private string _name;        
        private bool _expand;        
        private int _sort;
        private Image _image1;        
        
        /// <summary>
        /// 默认构造方法.
        /// </summary>
        public bf_Busi_BandDTO()
        {
        }
        public bf_Busi_BandDTO(DataRow dr)
        {
            this._iD = (int)dr["ID"];
            this._mID = (int)dr["MID"];
            this._name = (string)dr["Name"];
            this._expand = (bool)dr["Expand"];
            this._sort = (int)dr["Sort"];
            //if (dr["IMAGE1"] != DBNull.Value)
            //    this._image1 = Image.FromStream(new MemoryStream((byte[])dr["Image1"]));
            //else
            //    this._image1 = null;
        }   
        /// <summary>
        /// 含参构造方法.
        /// </summary>
        /// <param name="_iD"></param>
        /// <param name="_mID"></param>
        /// <param name="_name"></param>
        /// <param name="_expand"></param>
        /// <param name="_sort"></param>
        /// <param name="_image1"></param>
        public bf_Busi_BandDTO(int _iD,
                int _mID,
                string _name,
                bool _expand,
                int _sort,
                Image _image1)
        {
            this._iD = _iD;
            this._mID = _mID;
            this._name = _name;
            this._expand = _expand;
            this._sort = _sort;
            this._image1 = _image1;
        }        
        
       //[DataMember]
       // public int ID
       // {
       //     get
       //     {
       //         return this._iD;
       //     }
       //     set
       //     {
       //         this._iD=value;
       //     }
       // }

       // [DataMember]
       // public int MID
       // {
       //     get
       //     {
       //         return this._mID;
       //     }
       //     set
       //     {
       //         this._mID=value;
       //     }
       // }

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

        [DataMember]
        public bool Expand
        {
            get
            {
                return this._expand;
            }
            set
            {
                this._expand=value;
            }
        }

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

        //[DataMember]
        //public Image Image1
        //{
        //    get
        //    {
        //        return _image1;
        //    }
        //    set
        //    {
        //        this._image1=value;
        //    }
        //}

        [DataMember]
        public string Caption { get; set; }
    }
}
