using System;
using System.Data;
using YueMES.Base.Dal;
using WebMES.Model.Data;
using YueMES.Data.Services;
using YueMES.Base.Utils;
using System.Text;

namespace WebMES.Model.SystemModel
{
    public class Sys_BillSources : DTOExt, IConfigCache
    {
        private static object _lock = new object();
      
        #region 初始化
        /// <summary>
        /// 从表sys_Summary中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_BillSources(string SqlString)
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
        public new Sys_BillSource this[int index] { get { return ((Sys_BillSource)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_BillSource(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_BillSource); }
        #endregion
        #region 静态方法
        private static string Default_sql = null;
       // private static Sys_BillSources m_Default;
        public static Sys_BillSources Default
        {
            get
            {

                Default_sql = string.Format("select * from sys_BillSource");
                Sys_BillSources m_Default = null;

                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_Default = (Sys_BillSources)dto;

                if (m_Default != null) return m_Default;
                //m_Default = new Sys_BillSources(string.Format("select * from {0}.dbo.sys_BillSource", YueMES.Data.Services.DataService.GBF_DB_Name));

                lock (_lock)
                {
                    if (m_Default == null)
                        m_Default = new Sys_BillSources(Default_sql);
                }

                //YueMES.Data.Services.DataService.GBF_DB_Name
                //m_Default.TableName = YueMES.Data.Services.DataService.GBF_DB_Name+".dbo.sys_BillSource";
                m_Default.TableName = "sys_BillSource";



                if (m_Default != null && m_Default.Columns.Count > 0)
                {
                    YueMES.Base.Dal.DTO.AddInCache(Default_sql, m_Default);
                    CacheSyncServ.RegeditConfigCache(DAO.DBNo, m_Default);
                }
                else
                    m_Default = null;

                return m_Default;

            }
        }

        public static void SetDefaultNull()
        {
            if (Default_sql != null)
                YueMES.Base.Dal.DTO.CacheClear(Default_sql);
        }
     
        public static Sys_BillSource GetItem(int id)
        {
            Sys_BillSource result = (Sys_BillSource)Default.FindRow("ID", id);
            return result;
        }

        #endregion

       

        public string BusiNo
        {
            get { return "sys_BillSource"; }
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

            sql = string.Format("select * from sys_BillSource where ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_BillSources busis = (Sys_BillSources)busisData;
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
                Sys_BillSources busis = (Sys_BillSources)busisData;
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

            sql = string.Format("select * from sys_BillSource where ID in({0})", sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_BillSources busis = (Sys_BillSources)busisData;
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

    public class Sys_BillSource : YueMES.Base.Dal.DRO
    {
        #region 初始化
        /// <summary>
        /// 初始化sys_Summary对象
        /// </summary>
        internal protected Sys_BillSource(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 对应数据表字段的属性
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return Convert.ToInt32(this["ID"]); } }
        /// <summary>
        /// 菜单编号
        /// </summary>
        public string MenuNo { get { return this["MenuNo"].ToString(); } }
        /// <summary>
        /// 查询编号
        /// </summary>
        public string QueryNo { get { return this["QueryNo"].ToString(); } }
        public DateTime InputDate { get { return (DateTime)this["InputDate"]; } }
        #endregion
        #region 公开的属性
        #endregion
        #region 公开的方法
        #endregion
        #region 静态方法
        #endregion
    }
}
