using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.Filter
{
    [DataContract]
    public class CustomConditions
    {
        [DataMember]
        public string colName { get; set; }

        [DataMember]
        public string operateSybol { get; set; }

        [DataMember]
        public string colValue { get; set; }

        [DataMember]
        public string logic { get; set; }

        [DataMember]
        public bool leftBracket { get; set; }

        [DataMember]
        public bool rightBracket { get; set; }


        public string getLeftBracketLogic
        {
            get {
                return leftBracket?$"{logic} (":logic;
            }
        }

        [DataMember]
        public DbType DbType { get; set; }


        public CustomConditions()
        {
            logic = " and ";
            operateSybol = " like ";
            DbType = DbType.String;

        }
    }

   
    [DataContract]
    public class CustomSorts
    {
        [DataMember]
        public string colName { get; set; }
        [DataMember]
        public string stDir { get; set; }
        [DataMember]
        public int stPri { get; set; }

     

    }
    [DataContract]
    public class filterConidtions
    {
        [DataMember]
        public List<CustomConditions> filterCols { get; set; }
        [DataMember]
        public List<CustomSorts> sortCols { get; set; }
        public filterConidtions()
        {
            filterCols = new List<CustomConditions>();
            sortCols = new List<CustomSorts>();
        }

       // private List<CustomConditions> _selectedFilter=null;
        [DataMember]
        public List<CustomConditions> selectedFilter { get; set; }
        //{
        //    get
        //    {

        //        if (_selectedFilter == null)
        //        {
        //            _selectedFilter = new List<CustomConditions>();
        //        }
        //        return _selectedFilter;
        //    }
        //    set
        //    {
        //        _selectedFilter = value;
        //    }
        //}

    }
      [DataContract]
    public class PostFilterConditions
    {
        [DataMember]
        public List<CustomConditions> filterCols { get; set; }
        [DataMember]
        public List<CustomSorts> sortCols { get; set; }

        [DataMember]
        public List<FilterCustomDTO> filterCustoms { get; set; }

        /// <summary>
        /// 展开查询模式
        /// </summary>
        [DataMember]
        public bool isExpandMode { get; set; }

        public PostFilterConditions()
        {
            filterCols = new List<CustomConditions>();
            sortCols = new List<CustomSorts>();
            filterCustoms = new List<FilterCustomDTO>();
            isExpandMode = false;
        }
    }
}
