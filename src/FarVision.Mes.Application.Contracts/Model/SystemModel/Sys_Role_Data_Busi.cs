#region 本页代码的部分或全部由自动代码生成器生成
// 自动代码生成器简介：
// 制作语言： Microsoft Visual Basic.NET(2003)
// 作者： 郭建光
// E-Mail： GuoJianGuang154@163.com
// QQ： 40808310
// 本页代码生成时间：2008年10月03日 15:37:28
#endregion
using System.Data;
using YueMES.Data.Business;
using YueMES.Base.Dal;
using WebMES.Model.Data;
using System;
using YueMES.Data.Services;
using System.Text;
using YueMES.Base.Utils;

namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Sys_Role_Data_Busis : DTOExt, IConfigCache
    {
        private static object _lock = new object();
        
        #region 初始化
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected Sys_Role_Data_Busis(string SqlString)
            : base(SqlString)
        {
            this.Refresh();
        }
        #endregion
        #region 私有的方法
        #endregion
        #region 公开的属性
        #region 自定义属性
        #endregion
        #endregion
        #region 公开的方法
        /// <summary>
        /// 获取某一行的数据对象
        /// </summary>
        public new Sys_Role_Data_Busi this[int index] { get { return ((Sys_Role_Data_Busi)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Role_Data_Busi(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Role_Data_Busi); }

        public Sys_Role_Data_Busi this[string busiNo]
        {
            get { return (Sys_Role_Data_Busi)this.FindRow("BusiNo", busiNo); }
        }
        #endregion
        #region 静态方法
        private static string Default_sql = null;
        //internal static Sys_Role_Data_Busis m_Default;
        internal static Sys_Role_Data_Busis Default
        {
            get
            {

                Default_sql = string.Format("select * from sys_Role_Data_Busi");
                Sys_Role_Data_Busis m_Default = null;

                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_Default = (Sys_Role_Data_Busis)dto;

                if (m_Default != null) return m_Default;
                lock (_lock)
                {
                    lock (_lock)
                    {
                        m_Default = new Sys_Role_Data_Busis(Default_sql);
                        m_Default.TableName = "sys_Role_Data_Busi";
                    }
                }

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
        #endregion


        public string BusiNo
        {
            get { return "sys_Role_Data_Busi"; }
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

            sql = string.Format("select * from sys_Role_Data_Busi where ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Role_Data_Busis busis = (Sys_Role_Data_Busis)busisData;
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
                Sys_Role_Data_Busis busis = (Sys_Role_Data_Busis)busisData;
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

            sql = string.Format("select * from sys_Role_Data_Busi where ID in({0})", sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Role_Data_Busis busis = (Sys_Role_Data_Busis)busisData;
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
    /// 
    /// </summary>
    public class Sys_Role_Data_Busi : YueMES.Base.Dal.DRO
    {
        #region 私有的方法
        /// <summary>
        /// 初始化SystemArea对象
        /// </summary>
        internal protected Sys_Role_Data_Busi(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 公开的属性
        #region 对应数据表字段的属性
        //, , sFormType, iDefaultQueryCount, iControlSpace, iControlColumn, bCreateLookUp, bSyncLookUp, sTableName, 
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return Convert.ToInt32(this["ID"]); } }
        /// <summary>
        /// 
        /// </summary>
        public string BusiNo { get { return this["BusiNo"].ToString(); } }
        /// <summary>
        /// 
        /// </summary>
        public string FieldNo { get { return this["FieldNo"].ToString(); } }
        /// <summary>
        /// 
        /// </summary>
        public string FieldName { get { return this["FieldName"].ToString(); } }
        #endregion
        #region 自定义的属性
        /// <summary>
        /// 拥有该对象的强类型对象
        /// </summary>
        public Sys_Role_Data_Busis Owner
        {
            get { return (Sys_Role_Data_Busis)this.Table; }
        }
        #endregion
        #endregion
        #region 自定义属性
        public bf_Busi Business { get { return bf_Busis.GetItem(this.BusiNo); } }
        #endregion
        #region 公开的方法
        #endregion
        #region 静态的方法
        #endregion
    }
}