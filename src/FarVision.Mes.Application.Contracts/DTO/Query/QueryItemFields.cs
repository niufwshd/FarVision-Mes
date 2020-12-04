using System;
using System.Collections.Generic;
using System.Text;
using WebMES.DTO.Business;

namespace WebMES.DTO.Query
{
    [Serializable]
    public class QueryItemFields
    {
        public string busiNo { get; set; }
        public string alias { get; set; }

        public List<QueryCondition> unionCondi{ get;private set; }

        public List<bf_Busi_FieldDTO> fields { get; private set; }

        public QueryItemFields()
        {
            fields = new List<bf_Busi_FieldDTO>();
            unionCondi = new List<QueryCondition>();
        }
        public void setUnionConidtion(string condition,string alia)
        {
            if (string.IsNullOrEmpty(condition)) return;
            alia = alia.ToUpper();
            string[] sps = condition.Split(' ');
            for(int i=0;i<sps.Length;i++)
            {
                string[] exps = sps[i].Split('=');
                if (exps.Length < 2) continue;
                QueryCondition cd = new QueryCondition();
                cd.mColName = exps[0].ToUpper().Trim().StartsWith(alia)? exps[1].Replace(".", "_").ToUpper().Trim() : exps[0].Replace(".", "_").ToUpper().Trim();
                cd.sColName = exps[0].ToUpper().Trim().StartsWith(alia) ? exps[0].Replace(".", "_").ToUpper().Trim() : exps[1].Replace(".", "_").ToUpper().Trim();
                if (i < sps.Length - 1)
                {
                    cd.logic = sps[i + 1].ToLower();
                    i++;
                }
                unionCondi.Add(cd);
            }

        }
    }
    [Serializable]
    public class QueryCondition
    {
       
        public string mColName { get; set; }

        public string sColName { get; set; }


        public string operateSybol { get; set; }

       
        public string logic { get; set; }

        public QueryCondition()
        {
            logic = "and";
            operateSybol = "=";
        }
    }

}
