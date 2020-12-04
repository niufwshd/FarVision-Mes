using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebMES.DTO.Filter;
using YueMES.Base.Dal;
using YueMES.Base.Enum;
using YueMES.Base.Utils;

namespace WebMES.Utils.DataExtend
{
    public class DataTableToJson
    {

        /// <summary>
        /// 返回json表示的树结构，包含LEVEL
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="keyField"></param>
        /// <param name="parentField"></param>
        /// <returns></returns>
        public static string ToTreeJson(DataTable dt, string keyField, string parentField)
        {
            if (dt == null || dt.Rows.Count == 0) return "";
            if (!dt.Columns.Contains(keyField) || !dt.Columns.Contains(parentField)) return "";
            StringBuilder sbd = new StringBuilder();


            var v = dt.AsEnumerable().Where(w => (w[parentField] == DBNull.Value || w[parentField].Equals(0l) || w[parentField].Equals(0) || w[parentField].ToString().Trim().Equals("") || w[parentField].Equals(w[keyField]))).ToList();
            if (v.Count == 0)
            {
                var keys = dt.AsEnumerable().Select(s => s[keyField]).Distinct();
                v = dt.AsEnumerable().Where(w => !keys.Contains(w[parentField])).ToList();
            }
            
            sbd.Append("[");
            foreach (DataRow row in v)
            {
                sbd.Append("{\"LEVEL\":\"0\",");
                string rowJson = datarowToJson(row);
                sbd.Append(rowJson.Substring(0, rowJson.Length - 1));
                var vv = dt.AsEnumerable().Where(w => w[parentField].Equals(row[keyField]) && w != row);
                if (vv.Count() > 0)
                {
                    getChildJson(sbd, vv.ToList(), keyField, parentField, 0);
                    sbd.Append("},");
                }
                else
                    sbd.Append("},");
            }
            //if (sbd.ToString().EndsWith(","))
            sbd.Remove(sbd.Length - 1, 1);
            sbd.Append("]");
            return sbd.ToString();

        }

        static void getChildJson(StringBuilder sbd, List<DataRow> lstChild, string keyField, string parentField, int lvl)
        {
            lvl++;
            sbd.Append(",\"children\":[");
            foreach (DataRow row in lstChild)
            {
                
                sbd.Append(string.Format("{{\"LEVEL\":\"{0}\",", lvl));
                string rowJson = datarowToJson(row);
                sbd.Append(rowJson.Substring(0, rowJson.Length - 1));
                var vv = row.Table.AsEnumerable().Where(w => w[parentField].Equals(row[keyField]));
                if (vv.Count() > 0)
                {
                    getChildJson(sbd, vv.ToList(), keyField, parentField, lvl);
                    sbd.Append("},");
                }
                else
                    sbd.Append("},");

            }
            //if (sbd.ToString().EndsWith(","))
            //{
            sbd.Remove(sbd.Length - 1, 1);

            //}
            sbd.Append("]");
        }

        /// <summary>
        /// 转换层级关系
        /// </summary>
        /// <returns></returns>
        public static BooleanValue<DataTable> ToTreeView(DataTable dt, string keyField, string parentField, List<CustomSorts> csorts)
        {
            DataTable dtCopy = dt.Clone();

            try
            {
                dtCopy.Columns.Add("$$treeLevel", typeof(int));
               // dtCopy.Columns.Add("topLevelKey", typeof(string));
                if (!dtCopy.Columns.Contains(keyField) || !dtCopy.Columns.Contains(parentField)) return new BooleanValue<DataTable>(null, "未指定父节点，子节点字段");
                //var p = dt.AsEnumerable().Where(w => w[parentField] == DBNull.Value || w[parentField].ToString() == "0" || string.IsNullOrEmpty(w[parentField].ToString().Trim()));
                //if (p == null || p.Count()==0)
                //{
                //    var v = dt.AsEnumerable().Where(w => w[parentField] != DBNull.Value && !string.IsNullOrEmpty(w[parentField].ToString().Trim())).Select(s => s[parentField].ToString()).Distinct().ToList();
                //    p = dt.AsEnumerable().Where(w => v.Contains(w[keyField].ToString()));
                //}
                //if (p == null || p.Count() == 0)
                //{
                //    p = dt.AsEnumerable();
                //}

               
                var keys = dt.AsEnumerable().Select(s => s[keyField]).Distinct();
                var v = dt.AsEnumerable().Where(w => !keys.Contains(w[parentField])).ToList();
                

                // var v = dt.AsEnumerable().Where(w => p.Contains(w[keyField].ToString())).ToList();
                // if(v==null || v.Count == 0)
                //{
                //    v = dt.AsEnumerable().ToList();
                // }
                foreach (DataRow row in v)
                {
                    DataRow nr = dtCopy.NewRow();
                    nr.ItemArray = row.ItemArray;
                    nr["$$treeLevel"] = 0;
                   // nr["topLevelKey"] = row[keyField];
                    dtCopy.Rows.Add(nr);
                    var vv = dt.AsEnumerable().Where(w => w[parentField].Equals(row[keyField]) && w != row);
                    if (vv.Count() > 0)
                    {
                        getChildRow(vv.ToList(), keyField, parentField, 0,dtCopy);

                    }

                }
               // foreach (DataRow row in v)
               // {
               //     DataRow r= dtCopy.AsEnumerable().FirstOrDefault(f => f["topLevelKey"].ToString().StartsWith(row[keyField].ToString()));
               //     DataRow nr = dtCopy.NewRow();
               //     nr.ItemArray = row.ItemArray;
               //     dtCopy.Rows.InsertAt(nr, dtCopy.Rows.IndexOf(r));
               //     dtCopy.Rows.Remove(row);
               // }
               // string custOrder = getSortExp(csorts);
               // custOrder = string.IsNullOrEmpty(custOrder) ? "" : $"{custOrder},";
               //DataView dv = new DataView(dtCopy);
                
               // dv.Sort = $"topLevelKey desc";
               
               // dtCopy = dv.ToTable();

            }
            catch(Exception ex)
            {
                LogHelper.Error(ex);
                return new BooleanValue<DataTable>(null, ex.Message);
            }
            return new BooleanValue<DataTable>(dtCopy);
        }

        static string getSortExp(List<CustomSorts> cs)
        {

          
            if (cs == null || cs.Count == 0)
                return "";
            var v = cs.OrderBy(od => od.stPri);
            StringBuilder sbd = new StringBuilder();
          
            Regex reg = new Regex("_");
            foreach (var s in v)
            {
                if (sbd.ToString().Contains(s.colName)) continue;
                sbd.Append(",");
                sbd.Append(s.colName);
                sbd.Append(" ");
                sbd.Append(s.stDir);

            }
            return sbd.ToString().Substring(1);
        }

        static void getChildRow(List<DataRow> lstChild, string keyField, string parentField, int lvl,DataTable dtCopy)
        {
            lvl++;
       
            foreach (DataRow row in lstChild)
            {
                DataRow nr = dtCopy.NewRow();
                nr.ItemArray = row.ItemArray;

                nr["$$treeLevel"] = lvl;
                dtCopy.Rows.Add(nr);
                var vv = row.Table.AsEnumerable().Where(w => w[parentField].Equals(row[keyField]));
                if (vv.Count() > 0)
                {
                    getChildRow(vv.ToList(), keyField, parentField, lvl,dtCopy);
                    
                }
            }
       
        }

        public static string datarowToJson(DataRow row)
        {
            StringBuilder sbd = new StringBuilder();

            foreach (DataColumn col in row.Table.Columns)
            {

                sbd.Append("\"");
                sbd.Append(col.ColumnName.ToUpper());
                sbd.Append("\":");
                if (col.DataType == typeof(string) || col.DataType == typeof(DateTime))
                {
                    sbd.Append("\"");
                    sbd.Append(row[col]);
                    sbd.Append("\",");
                }
                else if (col.DataType == typeof(bool))
                {
                    sbd.Append(row[col] == DBNull.Value ? "null" : row[col].ToString().ToLower());
                    sbd.Append(",");
                }
                else 
                {
                    sbd.Append(row[col] == DBNull.Value ? "null" : row[col]);
                    sbd.Append(",");
                }
            }

            return sbd.ToString();
        }

        public static string ToJson(DataTable dt)
        {
            return JsonConvert.SerializeObject(dt);
        }

    }
}
