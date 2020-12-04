using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Utils.DataExtend
{
    /// <summary>
    /// DataTable的行列转换
    /// 
    /// </summary>
    public class DataTableTrans
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtSource"></param>
        /// <param name="fixFieldNames">固定显示的列</param>
        /// <param name="kv">需要转置的列名及值,key为需要转置的名称列,value为值列</param>
        /// <returns></returns>
        public static DataTable RowToColumnTrans(DataTable dtSource, List<string> fixFieldNames, KeyValuePair<string, string> kv, out List<string> transCols)
        {
            transCols = new List<string>();
            DataTable dt = new DataTable();
            if (!fixFieldNames.Contains("IDX"))
                dt.Columns.Add("IDX");
            foreach (var v in fixFieldNames)
            {
                dt.Columns.Add(v);
            }

            //以关键字段为筛选条件  列转为行 
            var columns = (from x in dtSource.AsEnumerable() select x[kv.Key].ToString().ToUpper()).Distinct();
            foreach (var item in columns)
            {
                transCols.Add(item);
                dt.Columns.Add(item);
            }

            StringBuilder sbd = new StringBuilder();
            Dictionary<string, List<DataRow>> dic = new Dictionary<string, List<DataRow>>();

            foreach (DataRow row in dtSource.Rows)
            {
                sbd.Clear();

                //以固定字段分组
                foreach (var v in fixFieldNames)
                {
                    if (dtSource.Columns.Contains(v))
                    {
                        if (dtSource.Columns[v].DataType == typeof(DateTime))
                        {
                            if (row[v] == DBNull.Value)
                            {
                                sbd.Append("");
                            }
                            else
                            {
                                sbd.Append(((DateTime)row[v]).ToString("yyyy-MM-dd HH:mm:ss"));
                            }
                        }
                        else
                        {
                            sbd.Append(row[v]);
                        }
                        sbd.Append("_|_");
                    }
                }
                List<DataRow> lst = null;
                if (dic.ContainsKey(sbd.ToString()))
                {
                    lst = dic[sbd.ToString()];
                }
                else
                {
                    lst = new List<DataRow>();
                    dic[sbd.ToString()] = lst;
                }
                lst.Add(row);

            }

            int itm = 1;
            List<object> dataArr = new List<object>();
            List<object> arrTemp = new List<object>();
            foreach (var key in dic.Keys)
            {
                arrTemp.Clear();
               
                foreach (var v in fixFieldNames)
                {
                    arrTemp.Add(dic[key][0][v]);
                }
                List<DataRow> lstTmp = dic[key];
                DateTime dtStart = DateTime.Now;
                while (lstTmp.Count > 0 && (DateTime.Now-dtStart).TotalMilliseconds<3000)
                {
                    dataArr.Clear();
                    DataRow nr = dt.NewRow();
                    dataArr.Add(itm++);
                    dataArr.AddRange(arrTemp);
                    foreach (var col in transCols)
                    {
                        var row = lstTmp.FirstOrDefault(w => w[kv.Key].ToString().ToUpper().Equals(col));
                        if (row == null) 
                        {
                            dataArr.Add(DBNull.Value);
                            continue; 
                        }
                        dataArr.Add(row[kv.Value]);
                        lstTmp.Remove(row);
                    }
                    nr.ItemArray = dataArr.ToArray();
                    dt.Rows.Add(nr);

                }
               
               

                //foreach (var v in transCols)
                //{
                //    bool flag = false;
                //    foreach (var vv in dic[key])
                //    {
                //        if (vv.ItemArray[2].ToString() == v.ToString() || vv.ItemArray[1].ToString() == v.ToString())
                //        {
                //            //object a = vv[kv.Value];
                //            dataArr.Add(vv[kv.Value]);
                //            flag = true;
                //        }
                //    }
                //    if (!flag)
                //    {
                //        object a = "";
                //        dataArr.Add(a);
                //    }
                //}

               
            }
            return dt;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dtSource"></param>
        /// <param name="fixFieldNames">固定显示的列</param>
        /// <param name="kv">需要转置的列名及值,key为需要转置的名称列,value为值列</param>
        /// <returns></returns>
        public static DataTable RowToColumnCSHGLTrans(DataTable dtSource, List<string> fixFieldNames, KeyValuePair<string, string> kv, out List<string> transCols)
        {
            transCols = new List<string>();
            DataTable dt = new DataTable();
            if (!fixFieldNames.Contains("IDX"))
                dt.Columns.Add("IDX");
            foreach (var v in fixFieldNames)
            {
                dt.Columns.Add(v);
            }

            //以关键字段为筛选条件  列转为行 
            var columns = (from x in dtSource.AsEnumerable() select x[kv.Key].ToString()).Distinct();
            foreach (var item in columns)
            {
                transCols.Add(item);
                transCols.Add(item + "_HGL");
                dt.Columns.Add(item);
                dt.Columns.Add(item + "_HGL");
            }

            StringBuilder sbd = new StringBuilder();
            Dictionary<string, List<DataRow>> dic = new Dictionary<string, List<DataRow>>();

            foreach (DataRow row in dtSource.Rows)
            {
                sbd.Clear();

                //以固定字段分组
                foreach (var v in fixFieldNames)
                {
                    if (dtSource.Columns.Contains(v))
                    {
                        sbd.Append(row[v]);
                        sbd.Append("_|_");
                    }
                }
                List<DataRow> lst = null;
                if (dic.ContainsKey(sbd.ToString()))
                {
                    lst = dic[sbd.ToString()];
                }
                else
                {
                    lst = new List<DataRow>();
                    dic[sbd.ToString()] = lst;
                }
                lst.Add(row);

            }

            int itm = 1;
            List<object> dataArr = new List<object>();
            foreach (var key in dic.Keys)
            {
                dataArr.Clear();
                DataRow nr = dt.NewRow();
                dataArr.Add(itm);
                itm++;
                foreach (var v in fixFieldNames)
                {
                    dataArr.Add(dic[key][0][v]);
                }
                foreach (var v in dic[key])
                {
                    dataArr.Add(v[kv.Value]);
                    dataArr.Add(v["M_CSIFHG"]);
                }
                nr.ItemArray = dataArr.ToArray();
                dt.Rows.Add(nr);
            }
            return dt;

        }


    }
}
