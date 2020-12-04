using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.SysData
{
    public class DataTableModel
    {
        public string name;
        public string queryno;
        public DataTable data;
        
    
    }

    public class DataSetModel
    {
        public string name;
        public List<DataTableModel> dataModel;
        public List<RelationDTO> relations;

        public DataSetModel()
        {
            dataModel = new List<DataTableModel>();
            relations = new List<RelationDTO>();
        }
    
    
    }
    
}
