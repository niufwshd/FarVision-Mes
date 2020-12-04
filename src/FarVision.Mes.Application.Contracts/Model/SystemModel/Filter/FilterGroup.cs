using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.SystemModel.Filter
{
    [Serializable]
    public class FilterGroup
    {

        public FilterGroup()
        {
            Rules = new List<FilterRule>();
        }
        public List<FilterRule> Rules { get; set; }
        public int LogicID { get; set; }

    }
    [Serializable]
    public class FilterGroups
    {
        public FilterGroups()
        {
            Groups = new List<FilterGroup>();
        }
        public string BusiNo { get; set; }
        public List<FilterGroup> Groups { get; set; }
    }

}
