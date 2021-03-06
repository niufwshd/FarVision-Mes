#region 本页代码的部分或全部由自动代码生成器生成
// 自动代码生成器简介：
// 制作语言： Microsoft Visual Basic.NET(2003)
// 作者： 郭建光
// E-Mail： GuoJianGuang154@163.com
// QQ： 40808310
// 本页代码生成时间：2008年10月03日 15:37:28
#endregion
using YueMES.Base.Dal;
using YueMES.Base.Enum;
using YueMES.Base.Utils;
using YueMES.Data.Services;
using WebMES.Model.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FarVision.Mes;

namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 系统属性信息
    /// </summary>
    public class Sys_Property_Sets : DTOExt, IConfigCache
    {
        private static object _lock = new object();

        #region 初始化
        /// <summary>
        /// 从表SystemArea中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Property_Sets(string SqlString)
            : base(SqlString)
        {
            this.Refresh();
        }
        #endregion
        #region 私有的方法
        #endregion
        #region 公开的属性
        #endregion
        #region 公开的方法
        /// <summary>
        /// 获取某一行的数据对象
        /// </summary>
        public new Sys_Property_Set this[int index] { get { return ((Sys_Property_Set)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Property_Set(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Property_Set); }
        #endregion
        #region 静态方法
        private static Dictionary<string, string> dicDefaultSql = new Dictionary<string, string>();

        private static string Default_sql
        {
            get
            {
                var key = $"{DAO.Default.dataBaseType}_{DataService.GBF_DB_Name}";
                if (dicDefaultSql.ContainsKey(key))
                    return dicDefaultSql[key];
                string dfSql = null;
                if (DAO.Default.dataBaseType == DataBaseType.SqlServer)
                {
                    dfSql = string.Format(
                                                @"select sps.* from sys_Property_Set sps
                                            left join {0}sys_Property sp on sp.ID=sps.PropertyID
                                            where sp.IsSystem=1 and sps.iUserID=-1
                                            order by sp.MenuNo,sp.ItemSort", DataService.GBF_DB_Name);
                }
                else
                {
                    dfSql = string.Format(
                                               @"select sps.* from sys_Property_Set sps
                                            left join sys_Property{0} sp on sp.ID=sps.PropertyID
                                            where sp.IsSystem=1 and sps.iUserID=-1
                                            order by sp.MenuNo,sp.ItemSort", DataService.GBF_DB_Name);
                }
                dicDefaultSql[key] =dfSql;
                return dfSql;


            }
        }
        //private static Sys_Property_Sets m_EP;
        /// <summary>
        /// 企业级属性值
        /// </summary>
        public static Sys_Property_Sets EP
        {
            get
            {
                
                Sys_Property_Sets m_EP = null;
                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_EP = (Sys_Property_Sets)dto;


                if (m_EP != null) return m_EP;

                lock (_lock)
                {
                    if (m_EP != null && m_EP.Columns.Count > 0) return m_EP;
                    m_EP = new Sys_Property_Sets(Default_sql);
                    m_EP.TableName = "Sys_Property_Set";

                    if (m_EP != null && m_EP.Columns.Count > 0)
                    {
                        YueMES.Base.Dal.DTO.AddInCache(Default_sql, m_EP);
                        CacheSyncServ.RegeditConfigCache(DAO.DBNo, m_EP);
                    }
                    else
                        m_EP = null;
                }

                return m_EP;
            }
        }

        internal static Sys_Property_Sets GetProperties(string menuNo, int userID)
        {
            string sql = "";
            if (DAO.Default.dataBaseType == DataBaseType.SqlServer)
            {
                sql = string.Format(
   @"select sps.* from sys_Property_Set sps left join {2}sys_Property sp on sp.ID=sps.PropertyID
where sps.iUserID={0} and sp.MenuNo='{1}' order by sp.ItemSort", userID, menuNo, DataService.GBF_DB_Name);
            }
            else
            {
                sql = string.Format(
   @"select sps.* from sys_Property_Set sps left join sys_Property{2} sp on sp.ID=sps.PropertyID
where sps.iUserID={0} and sp.MenuNo='{1}' order by sp.ItemSort", userID, menuNo, DataService.GBF_DB_Name);
            }

            Sys_Property_Sets result = new Sys_Property_Sets(sql);
            result.Columns["ID"].AutoIncrement = true;
            result.Columns["iUserID"].DefaultValue = userID;
            return result;
        }
        #endregion

        public string BusiNo
        {
            get { return "sys_Property_Set"; }
        }
        public void AddRecord(System.Collections.Generic.List<int> InsList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (InsList == null || InsList.Count == 0) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in InsList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("select * from sys_Property_Set where ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Property_Sets busis = (Sys_Property_Sets)busisData;
                    if (busis.Columns.Count != bv.Value.Columns.Count) return;
                    foreach (DataRow row in bv.Value.Rows)
                    {
                        busis.LoadDataRow(row, true);
                    }
                    busis.AcceptChanges();
                }
            }
        }

        

        public void RemoveRecord(System.Collections.Generic.List<int> DelList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (DelList == null || DelList.Count == 0) return;
            if (Default_sql != null)
            {
                object busisData = null;
                YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                Sys_Property_Sets busis = (Sys_Property_Sets)busisData;
                foreach (var id in DelList)
                {
                    DataRow[] drs = busis.Select(string.Format("ID={0}", id));
                    if (drs.Length == 0) continue;
                    busis.Rows.Remove(drs[0]);
                }
                busis.AcceptChanges();
            }
        }

        public void UpdateRecord(System.Collections.Generic.List<int> UpdList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (UpdList == null || UpdList.Count == 0) return;
            string sql = "";
            StringBuilder sbd = new StringBuilder();
            foreach (var id in UpdList)
            {
                sbd.Append(id);
                sbd.Append(",");
            }

            sql = string.Format("select * from sys_Property_Set where ID in({0})", sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Property_Sets busis = (Sys_Property_Sets)busisData;
                    if (busis.Columns.Count != bv.Value.Columns.Count) return;
                    foreach (var id in UpdList)
                    {
                        DataRow[] drs = busis.Select(string.Format("ID={0}", id));
                        if (drs.Length == 0) continue;
                        busis.Rows.Remove(drs[0]);
                    }
                    foreach (DataRow row in bv.Value.Rows)
                    {
                        busis.LoadDataRow(row, true);
                    }
                    busis.AcceptChanges();
                }
            }
        }
    }
    /// <summary>
    /// 系统属性记录
    /// </summary>
    public class Sys_Property_Set : SysPropertySet
    {
       
    }
}