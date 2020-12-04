using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Device
{
    [Serializable]
    public class InfuxdbDataModel
    {
        public List<result> results { get; set; }

        public InfuxdbDataModel()
        {
            results = new List<result>();
        }

    }

    [Serializable]
    public class result
    {
        public long statement_id { get; set; }
        public List<serie> series { get; set; }

        public result()
        {
            series = new List<serie>(); 
        }
    }
    [Serializable]
    public class serie
    {
        public string name { get; set; }

        public List<string> columns { get; set; }

        public List<List<string>> values { get; set; }

        public serie()
        {
            columns = new List<string>();
            values = new List<List<string>>();
        }
    }
}
