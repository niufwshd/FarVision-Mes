using YueMES.Data.Business;
using YueMES.Data.Utils;
using WebMES.DTO.PostBack;
using WebMES.DTO.SysData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;



namespace WebMES.Utils.DataExtend
{
    public static class BDOConverter
    {

    
        /// <summary>
        /// BDOs模型转DataSet
        /// </summary>
        /// <param name="bdos"></param>
        /// <returns></returns>
        public static DataSet ToDataSetDTO(BDOs bdos)
        {
            DataSet ds = new DataSet(bdos.DataSetName);

            foreach (DataTable t in bdos.Tables)
            {
                DataView dv = t.DefaultView;
                DataTable dt = dv.ToTable();
                dt.AcceptChanges();
                dt.TableName = t.TableName;
                ds.Tables.Add(dt);

                DataRelation rel = bdos.GetDataRelation(bdos.MasterBDO, t);
                if (rel != null)
                {
                    List<DataColumn> pColumns = new List<DataColumn>();
                    foreach (DataColumn col in rel.ParentColumns)
                    {
                        if (ds.Tables[bdos.MasterBDO.TableName].Columns.Contains(col.ColumnName))
                            pColumns.Add(ds.Tables[bdos.MasterBDO.TableName].Columns[col.ColumnName]);
                    }
                    List<DataColumn> childColumns = new List<DataColumn>();
                    foreach (DataColumn col in rel.ChildColumns)
                    {
                        if (ds.Tables[t.TableName].Columns.Contains(col.ColumnName))
                            childColumns.Add(ds.Tables[t.TableName].Columns[col.ColumnName]);
                    }
                    ds.Relations.Add(rel.RelationName, pColumns.ToArray(), childColumns.ToArray());
                }
            }
            return ds;
        
        }
        /// <summary>
        /// BDO模型转DataTable
        /// </summary>
        /// <param name="bdo"></param>
        /// <returns></returns>
        public static DataTable ToDataTableDTO(BDO bdo)
        {
            DataView dv = bdo.DefaultView;
            DataTable dt = dv.ToTable();
            dt.AcceptChanges();
            dt.TableName = bdo.TableName;
            return dt;
        
        }
        /// <summary>
        /// DataSet转BDOs模型
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static List<BDOs> ToBDOsModel(DataSet ds)
        {
            List<BDOs> lstDs = new List<BDOs>();
            List<string> lstTbInBdos = new List<string>();
            foreach (DataRelation v in ds.Relations)
            {
                BDOs BDOS = lstDs.Find((b) =>
                {
                    DataTable dt = v.ParentTable;
                    while (dt.ParentRelations.Count > 0)
                    {
                        dt = dt.ParentRelations[0].ParentTable;
                    }
                    return b.DataSetName == dt.TableName;
                });
                if (BDOS == null)
                {
                    BDOs bdos = new BDOs();                                      //新建DS
                    if (v.ParentTable.ParentRelations.Count == 0)
                    {
                        bdos.DataSetName = v.ParentTable.TableName;
                        CheckNullValue(v.ParentTable);
                        BDO bdo = new BDO(bdos, null, v.ParentTable.Copy());
                        bdo.TableName = v.ParentTable.TableName;
                        bdos.Tables.Add(bdo);  //添加MasterBDO

                        bdo = new BDO(bdos, bdos.MasterBDO, v.ChildTable.Copy());
                        bdo.TableName = v.ChildTable.TableName;
                        bdos.Tables.Add(bdo);
                        CopyRelation(bdos, v);

                        bdos.MasterBDO.Children.Add(bdo);
                        lstDs.Add(bdos);
                        lstTbInBdos.Add(v.ParentTable.TableName);
                        lstTbInBdos.Add(v.ChildTable.TableName);
                    }
                    else
                    {
                        DataTable dt = v.ParentTable;
                        while (dt.ParentRelations.Count > 0)
                        {
                            dt = dt.ParentRelations[0].ParentTable;
                        }
                        bdos.DataSetName = dt.TableName;

                        CheckNullValue(dt);
                        BDO bdo = new BDO(bdos, null, dt.Copy());
                        bdo.TableName = dt.TableName;
                        bdos.Tables.Add(bdo);  //添加MasterBDO
                        lstDs.Add(bdos);
                        lstTbInBdos.Add(dt.TableName);

                        while (dt.ChildRelations.Count > 0)
                        {
                            for (int i = 0; i < dt.ChildRelations.Count; i++)
                            {
                                bdo = new BDO(bdos, bdos.MasterBDO, dt.ChildRelations[i].ChildTable.Copy());
                                bdo.TableName = dt.ChildRelations[i].ChildTable.TableName;
                                bdos.Tables.Add(bdo);
                                CopyRelation(bdos, dt.ChildRelations[i]);
                                bdos.MasterBDO.Children.Add(bdo);
                                lstTbInBdos.Add(dt.ChildRelations[i].ChildTable.TableName);
                            }
                            dt = dt.ChildRelations[0].ChildTable;
                        }

                    }
                }
                else if (!BDOS.Tables.Contains(v.ChildTable.TableName))
                {
                    CheckNullValue(v.ChildTable);
                    BDO bdo = new BDO(BDOS, BDOS.MasterBDO, v.ChildTable.Copy());
                    bdo.TableName = v.ChildTable.TableName;
                    BDOS.Tables.Add(bdo);
                    CopyRelation(BDOS, v);
                    BDOS.MasterBDO.Children.Add(bdo);
                    lstTbInBdos.Add(v.ChildTable.TableName);
                }
            }
            //无表关系的单表
            foreach (DataTable dt in ds.Tables)
            {
                if (!lstTbInBdos.Exists((name) => name == dt.TableName))
                {
                    CheckNullValue(dt);
                    BDOs singleBDOs = new BDOs();
                    singleBDOs.DataSetName = dt.TableName;
                    BDO bdo = new BDO(singleBDOs, null, dt.Copy());
                    bdo.TableName = dt.TableName;
                    singleBDOs.Tables.Add(bdo);
                    lstDs.Add(singleBDOs);
                }
            }
            return lstDs;

        }

        public static List<BDOs> ToBDOsModel(PostData postData)
        {
            //取真实表名
            for (int i = 0; i < postData.BusiDatas.Length; i++)
            {
                bf_Busi busi = bf_Busis.GetItem(postData.BusiDatas[i].BusiNo);
                if (busi == null) continue;
                postData.BusiDatas[i].TableName = busi.TableName;
                busi = bf_Busis.GetItem(postData.BusiDatas[i].ParentBusiNo);
                if (busi == null) continue;
                postData.BusiDatas[i].ParentTableName = busi.TableName;
            }
            //按照表关系转换
            List<BDOs> lstDs = new List<BDOs>();
            List<string> lstTbInBdos = new List<string>();
            for (int i = 0; i < postData.relations.Length;i++)
            {
                RelationDTO rel = postData.relations[i];
                BDOs BDOS = lstDs.Find((b) => b.DataSetName == rel.parentBusiNo);
                if (BDOS == null)
                {
                    BDOs bdos = null;
                    BDO bdoParent = null;
                    foreach (BDOs bds in lstDs)
                    {
                        bdoParent = bds[rel.parentBusiNo];
                        if (bdoParent != null)
                        {
                            bdos = bds;
                            break;
                        }
                    }
                    if (bdoParent == null)
                    {
                        bdos = new BDOs(rel.parentBusiNo);     
                        bdoParent = JsonToBDO(bdos,null,rel.parentBusiNo, postData.BusiDatas.AsEnumerable().FirstOrDefault(f => f.BusiNo.Equals(rel.parentBusiNo)).JsonData);
                        CheckNullValue(bdoParent);                                   
                        bdos.DataSetName = rel.parentBusiNo;
                    }

                    BDO bdoChild = JsonToBDO(bdos, null, rel.name, postData.BusiDatas.AsEnumerable().FirstOrDefault(f => f.BusiNo.ToUpper().Equals(rel.name.ToUpper())).JsonData);
                    if (bdoParent.Rows.Count == 0)
                    {
                        foreach (DataRow row in bdoChild.Rows)
                        {
                            if (bdoParent.AsEnumerable().FirstOrDefault(f => f[rel.parentCols[0]].Equals(row[rel.childCols[0]])) != null) continue;
                            DataRow nr = bdoParent.NewRow();
                            nr[rel.parentCols[0]] =row.RowState==DataRowState.Deleted?row[rel.childCols[0],DataRowVersion.Original]: row[rel.childCols[0]];
                            bdoParent.Rows.Add(nr);
                        }
                        bdoParent.AcceptChanges();
                    }
                    bdoParent.AddChildren(rel.name, bdoChild, rel.parentCols[0], rel.childCols[0]);
                    //CopyRelation(bdos, rel);

                    if (!lstDs.Contains(bdos))
                    {
                        lstDs.Add(bdos);
                        lstTbInBdos.Add(rel.parentBusiNo);
                    }
                    lstTbInBdos.Add(rel.name);
                }
                else
                {
                    BDO bdo = JsonToBDO(BDOS, null, rel.name, postData.BusiDatas.AsEnumerable().FirstOrDefault(f => f.BusiNo.Equals(rel.name)).JsonData);
                    CheckNullValue(bdo);
                    if (BDOS.MasterBDO.Rows.Count == 0)
                    {
                        foreach (DataRow row in bdo.Rows)
                        {
                            if (BDOS.MasterBDO.AsEnumerable().FirstOrDefault(f => f[rel.parentCols[0]].Equals(row[rel.childCols[0]])) != null) continue;
                            DataRow nr = BDOS.MasterBDO.NewRow();
                            nr[rel.parentCols[0]] = row[rel.childCols[0]];
                            BDOS.MasterBDO.Rows.Add(nr);
                        }
                        BDOS.MasterBDO.AcceptChanges();
                    }

                    BDOS.MasterBDO.AddChildren(rel.name, bdo,rel.parentCols[0],rel.childCols[0]);
                    //CopyRelation(BDOS, rel);
                    lstTbInBdos.Add(rel.name);
                }
            }

            //无表关系的单表
            foreach (BusiData bd in postData.BusiDatas)
            {
              
                if (!lstTbInBdos.Exists((name) => name == bd.BusiNo))
                {
                    BDOs singleBDOs = new BDOs(bd.BusiNo);
                    BDO bdo = JsonToBDO(singleBDOs, null, bd.BusiNo, postData.BusiDatas.AsEnumerable().FirstOrDefault(f => f.BusiNo.Equals(bd.BusiNo)).JsonData);
                    CheckNullValue(bdo);
                    singleBDOs.DataSetName = bd.BusiNo;
                    lstDs.Add(singleBDOs);
                }
            }

            return lstDs;
        
        }

        public static BDO JsonToBDO(BDOs owner,BDO parentBDO,  string busino,string jsonData)
        {



            BDO bdo = new BDO(owner, parentBDO, busino, "1<>1",false,-1,-1,false);

            try
            {
                ArrayList arrayList = JsonConvert.DeserializeObject<ArrayList>(jsonData);
                foreach (var v in arrayList)
                {
                    Newtonsoft.Json.Linq.JObject jobj = v as Newtonsoft.Json.Linq.JObject;
                    string dataState = "0";  //0-unchange,1-add,2-modify,3-delete
                    Newtonsoft.Json.Linq.JToken token;
                    if (jobj.TryGetValue("dataState", out token))
                        dataState = token.ToString();
                    //if (dataState == "0") continue;
                    DataRow nr = bdo.NewRow();
                    bdo.Rows.Add(nr);
                    if (dataState == "2")
                    {
                        foreach (var vv in jobj)
                        {
                            if (!vv.Key.EndsWith("_old")) continue;
                            string filedName = vv.Key.Substring(0, vv.Key.Length - 4);
                            if (!bdo.Columns.Contains(filedName)) continue;
                            if (vv.Value.GetType() == typeof(Newtonsoft.Json.Linq.JObject) || vv.Value.GetType() == typeof(Newtonsoft.Json.Linq.JArray))
                            {
                                if (bdo.Columns[filedName].DataType != typeof(string)) continue;
                                nr[filedName] = vv.Value.ToString();
                            }
                            else
                            {
                                if (((Newtonsoft.Json.Linq.JValue)vv.Value).Value == null && !bdo.Columns[filedName].AllowDBNull) continue;
                                if (((Newtonsoft.Json.Linq.JValue)vv.Value).Type == Newtonsoft.Json.Linq.JTokenType.Boolean)
                                {
                                    nr[filedName] = (bool)((Newtonsoft.Json.Linq.JValue)vv.Value).Value ? 1 : 0;
                                }
                                else
                                    nr[filedName] = ((Newtonsoft.Json.Linq.JValue)vv.Value).Value == null || ((Newtonsoft.Json.Linq.JValue)vv.Value).Value.Equals("") || ((Newtonsoft.Json.Linq.JValue)vv.Value).Value.Equals("null") ? DBNull.Value : vv.Value.ToObject(bdo.Columns[filedName].DataType);
                            }
                        }
                        nr.AcceptChanges();
                    }
                    bool flg = true;
                    foreach (var vv in jobj)
                    {
                        if (!bdo.Columns.Contains(vv.Key)) continue;
                        if (vv.Key.EndsWith("_old")) continue;
                        if (vv.Value.GetType() == typeof(Newtonsoft.Json.Linq.JObject)) continue;
                        var vl = (Newtonsoft.Json.Linq.JValue)vv.Value;
                        if ((vl.Value == null || vl.Value.ToString().ToUpper() == "NULL") && !bdo.Columns[vv.Key].AllowDBNull) continue;

                        if (dataState == "1" && bdo.Columns[vv.Key].DataType == typeof(Guid))
                        {
                            ((BRO)nr).OldID = vl.Value;
                            continue;
                        }

                        if (!nr[vv.Key].Equals(vl.Value))
                            flg = flg & false;

                        if (vl.Value == null || vl.Value.ToString().ToUpper() == "NULL")
                        {
                            nr[vv.Key] = DBNull.Value;
                        }
                        else if (vl.Type == Newtonsoft.Json.Linq.JTokenType.String && (bdo.Columns[vv.Key].DataType == typeof(Boolean) || bdo.Columns[vv.Key].DataType == typeof(Int32)) && (vl.Value.ToString().ToUpper() == "TRUE" || vl.Value.ToString().ToUpper() == "FALSE"))
                        {
                            nr[vv.Key] = vl.Value.ToString().ToUpper() == "TRUE" ? 1 : 0;
                        }
                        else if (vv.Value.Type == Newtonsoft.Json.Linq.JTokenType.Boolean)
                        {
                            nr[vv.Key] = (vv.Value.HasValues || vl.Value.ToString().ToUpper() == "TRUE") ? 1 : 0;
                        }
                        else
                        {
                            //if (!nr[vv.Key].Equals(vl.Value))
                            //    flg = flg & false;
                            object objValue = ((Newtonsoft.Json.Linq.JValue)vv.Value).Value;
                            nr[vv.Key] = objValue == null || string.IsNullOrEmpty(objValue.ToString().Trim()) ? DBNull.Value : vv.Value.ToObject(bdo.Columns[vv.Key].DataType);
                        }
                    }
                    if (dataState == "2" && flg)
                        nr.AcceptChanges();

                    if (dataState == "3")
                    {
                        nr.AcceptChanges();
                        nr.Delete();
                    }
                    else if (dataState == "0")
                        nr.AcceptChanges();
                }
            }
            catch(Exception ex)
            {
                if(ex.Message=="Input string was not in a correct format.")
                {
                    throw new ApplicationException("数据类型转换错误, 请删除后再输入重试.");
                }
                else
                {
                    throw ex;
                }
            }

            return bdo;
        }

        private static void CopyRelation(BDOs bdos,DataRelation rel)
        {
            List<DataColumn> pColumns = new List<DataColumn>();
            foreach (DataColumn col in rel.ParentColumns)
            {
                if (bdos.Tables[rel.ParentTable.TableName].Columns.Contains(col.ColumnName))
                    pColumns.Add(bdos.Tables[rel.ParentTable.TableName].Columns[col.ColumnName]);
            }
            List<DataColumn> childColumns = new List<DataColumn>();
            foreach (DataColumn col in rel.ChildColumns)
            {
                if (bdos.Tables[rel.ChildTable.TableName].Columns.Contains(col.ColumnName))
                    childColumns.Add(bdos.Tables[rel.ChildTable.TableName].Columns[col.ColumnName]);
            }
            bdos.Relations.Add(rel.RelationName, pColumns.ToArray(), childColumns.ToArray());
        
        }

        private static void CopyRelation(BDOs bdos, RelationDTO rel)
        {
            List<DataColumn> pColumns = new List<DataColumn>();
            foreach (string col in rel.parentCols)
            {
                if (bdos.Tables[rel.parentBusiNo].Columns.Contains(col))
                    pColumns.Add(bdos.Tables[rel.parentBusiNo].Columns[col]);
            }
            List<DataColumn> childColumns = new List<DataColumn>();
            foreach (string col in rel.childCols)
            {
                if (bdos.Tables[rel.name].Columns.Contains(col))
                    childColumns.Add(bdos.Tables[rel.name].Columns[col]);
            }
            bdos.Relations.Add(rel.name, pColumns.ToArray(), childColumns.ToArray());

        }
        private static void CheckNullValue(DataTable dt)
        {
            if (dt==null || dt.Rows.Count == 0) return;
            foreach (DataColumn col in dt.Columns)
            {

                if (!col.AllowDBNull && dt.Rows[0].RowState!=DataRowState.Deleted && dt.Rows[0][col.ColumnName] == DBNull.Value)
                {
                    throw new Exception(string.Format("业务{0}字段{1}不允许空",dt.TableName, col.ColumnName));
                }
            }

        }
        public static string BDOToJSON(BDO bdoData) 
        {
            StringBuilder sbd = new StringBuilder();
            sbd.Append("{\"busiName\":\"");
            sbd.Append(bdoData.BusiNo);
            sbd.Append("\",\"busiQueryno\":\"");
            sbd.Append(bdoData.Business.QueryNo);
            sbd.Append("\",\"busiData\":");
            string str = JsonConvert.SerializeObject(bdoData);
            sbd.Append(str);
            sbd.Append("}");
            return sbd.ToString();
        }

        static void AddChildBDOData(DataSetModel dsMd,BDO mbdo)
        {
            foreach (var bdo in mbdo.Children)
            {

                dsMd.dataModel.Add(new DataTableModel { name = bdo.BusiNo, queryno = bdo.Business.QueryNo, data = bdo });
                dsMd.relations.Add(new RelationDTO()
                {
                    name = bdo.BusiNo,
                    parentBusiNo = mbdo.Business.No,
                    parentCols = new List<string> { bdo.ParentRelations[0].ParentColumns[0].ColumnName },
                    childCols = new List<string> { bdo.ParentRelations[0].ChildColumns[0].ColumnName }
                });
                if (bdo.Children.Count > 0)
                {
                    AddChildBDOData(dsMd, bdo);
                }
            }

        }

        public static string BDOsToJSON(BDOs bdos)
        {
            DataSetModel dsMd = new DataSetModel();
            dsMd.name = bdos.DataSetName;
            BDO mbdo = bdos.MasterBDO;
            dsMd.dataModel.Add(new DataTableModel { name = mbdo.BusiNo, data = mbdo, queryno = mbdo.Business.QueryNo });
            AddChildBDOData(dsMd, mbdo);
          
            StringBuilder sbd = new StringBuilder();
            sbd.Append("{ \"name\":\"");
            sbd.Append(dsMd.name);
            sbd.Append("\",\"datas\":[");
            foreach (var v in dsMd.dataModel)
            {
                sbd.Append("{\"busiName\":\"");
                sbd.Append(v.name);
                sbd.Append("\",\"busiQueryno\":\"");
                sbd.Append(v.queryno);
                sbd.Append("\",\"busiData\":");
                string str = JsonConvert.SerializeObject(v.data);
                sbd.Append(str);
                sbd.Append("},");
            }
            sbd.Remove(sbd.Length - 1, 1);
            sbd.Append("],\"relations\":");
            sbd.Append(JsonConvert.SerializeObject(dsMd.relations));
            sbd.Append("}");
            return sbd.ToString();
        }
  

    }
}
