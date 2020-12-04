using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using YueMES.Base.Dal;
using YueMES.Base.Enum;
using YueMES.Base.Utils;
using YueMES.Data.Services;

namespace WebMES.Model.SystemModel.Filter
{
    public class SysDataAuthorityRules : IConfigCache
    {

        private static Dictionary<DataBaseType, string> dicDefaultSql = new Dictionary<DataBaseType, string>();
        private static ConcurrentDictionary<string, List<DataAuthorityRuleItem>> dicRules = null;
        static SysDataAuthorityRules instance = null;
        private static object _lock = new object();



        public List<DataAuthorityRuleItem> GetRuleItems(string tableName)
        {
            if (dicRules[DAO.DBNo] == null) return new List<DataAuthorityRuleItem>();
            return dicRules[DAO.DBNo].Where(w => w.TableName.ToUpper() == tableName.ToUpper() && w.IsValid).ToList();
        }

        private static string Default_sql
        {
            get
            {
                if (DAO.Default == null) return "";
                if (dicDefaultSql.ContainsKey(DAO.Default.dataBaseType))
                    return dicDefaultSql[DAO.Default.dataBaseType];
                string dfSql = $"select * from sys_Data_Rules";
                dicDefaultSql[DAO.Default.dataBaseType] = dfSql;
                return dfSql;

            }
        }

        public static SysDataAuthorityRules Default
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            dicRules = new ConcurrentDictionary<string, List<DataAuthorityRuleItem>>();
                            dicRules[DAO.DBNo] = null;
                            instance = new SysDataAuthorityRules();
                            CacheSyncServ.RegeditConfigCache(DAO.DBNo, instance);
                        }
                    }
                }

                if (!dicRules.ContainsKey(DAO.DBNo) || dicRules[DAO.DBNo] == null)
                {
                    lock (_lock)
                    {
                        if (!dicRules.ContainsKey(DAO.DBNo))
                        {
                            dicRules[DAO.DBNo] = null;
                        }
                        BooleanValue<DataTable> bvt = DAO.Default.GetDataTable(Default_sql);
                        if (!bvt.Success) return instance;

                        if (dicRules[DAO.DBNo] == null)
                        {
                            dicRules[DAO.DBNo] = new List<DataAuthorityRuleItem>();
                            foreach (DataRow row in bvt.Value.Rows)
                            {
                                dicRules[DAO.DBNo].Add(BuildItemData(row));
                            }
                        }
                    }
                }
                return instance;

            }
        }

        private static DataAuthorityRuleItem BuildItemData(DataRow row)
        {
            var item = new DataAuthorityRuleItem();
            item.ID = Convert.ToInt32(row["ID"]);
            item.BusiNo = row["BusiNo"].ToString();
            item.MenuNo = row["MenuNo"].ToString();
            item.TableName = row["TableName"].ToString();
            item.IsValid = (bool)row["IsValid"];
            item.FilterGroups = JsonConvert.DeserializeObject<FilterGroups>(row["Rules"].ToString());
            return item;
        }

        public string BusiNo
        {
            get
            {
                return "sysDataRules";
            }
        }

        public void AddRecord(List<int> InsList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (InsList == null || InsList.Count == 0) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in InsList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("select * from sys_Data_Rules where ID in({0})", sbd.ToString(0, sbd.Length - 1));
            
            BooleanValue<DataTable> bvt = dao.GetDataTable(sql);

            if (bvt.Success && bvt.Value.Rows.Count > 0)
            {
                if (dicRules[DAO.DBNo] != null)
                {
                    foreach (DataRow row in bvt.Value.Rows)
                    {
                        dicRules[DAO.DBNo].Add(BuildItemData(row));
                    }
                }
            }
        }

        public void RemoveRecord(List<int> DelList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {

            if (DelList == null || DelList.Count == 0) return;
            if (dicRules[DAO.DBNo] != null)
            {
                var rs = dicRules[DAO.DBNo];
               
                foreach (var id in DelList)
                {
                    for(int i = rs.Count; i >= 0; i--)
                    {
                        if (rs[i].ID == id)
                        {
                            rs.RemoveAt(i);
                        }
                    }
                }
            }
        }

        public void UpdateRecord(List<int> UpdList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (UpdList == null || UpdList.Count == 0) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in UpdList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("select * from sys_Data_Rules where ID in({0})", sbd.ToString(0, sbd.Length - 1));
            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (dicRules[DAO.DBNo] != null)
                {
                    var rs = dicRules[DAO.DBNo];
                    foreach (DataRow row in bv.Value.Rows)
                    {
                        var item = rs.FirstOrDefault(f =>row["ID"].Equals(f.ID));
                        if (item!=null)
                        {
                            var v= BuildItemData(row);
                            item.BusiNo = v.BusiNo;
                            item.MenuNo = v.MenuNo;
                            item.TableName = v.TableName;
                            item.IsValid = v.IsValid;
                            item.FilterGroups = v.FilterGroups;
                            
                        }
                    }
                }
            }
        }
    }

    public class DataAuthorityRuleItem
    {
        public int ID { get; set; }
        public string BusiNo { get; set; }
        public string MenuNo { get; set; }
        public string TableName { get; set; }
        public bool IsValid { get; set; }
        public FilterGroups FilterGroups { get; set; }

    }
}
