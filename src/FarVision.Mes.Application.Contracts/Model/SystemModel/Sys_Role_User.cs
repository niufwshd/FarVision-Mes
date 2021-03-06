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
using System.Linq;

namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Sys_Role_Users : DTOExt, IConfigCache
    {
        private static object _lock = new object();

        #region 初始化
        /// <summary>
        /// 从表SystemArea中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected Sys_Role_Users(string SqlString)
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
        public new Sys_Role_User this[int index] { get { return ((Sys_Role_User)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Role_User(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Role_User); }
        #endregion
        #region 静态方法
        private static string Default_sql = null;
        //private static Sys_Role_Users m_Default;
        internal static Sys_Role_Users Default
        {
            get
            {
                Default_sql = string.Format("select * from Sys_Role_User");
                Sys_Role_Users m_Default = null;

                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_Default = (Sys_Role_Users)dto;

                if (m_Default != null) return m_Default;
                lock (_lock)
                {
                    if (m_Default == null)
                    {
                        m_Default = new Sys_Role_Users(Default_sql);
                        m_Default.TableName = "Sys_Role_User";
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
            get { return "Sys_Role_User"; }
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

            sql = string.Format("select * from Sys_Role_User where ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Role_Users busis = (Sys_Role_Users)busisData;
                    if (busis.Columns.Count != bv.Value.Columns.Count) return;
                    lock (_lock)
                    {
                        foreach (DataRow row in bv.Value.Rows)
                        {
                            busis.LoadDataRow(row, true);
                        }
                        busis.AcceptChanges();
                    }
                }
            }

            sql = "SELECT r.ID FROM sys_Role_User b INNER JOIN sys_Role r ON b.MID=r.ID where b.ID IN({0})";
            sql = string.Format(sql, sbd.ToString(0, sbd.Length - 1));
            bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                base.addThreadInfo(DBNo);
                foreach (DataRow row in bv.Value.Rows)
                {
                    Sys_Role busi = Sys_Roles.GetItem(Convert.ToInt32(row["ID"]));
                    if (busi == null) continue;
                    busi.ResetRoleUsers();
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
                Sys_Role_Users busis = (Sys_Role_Users)busisData;

                base.addThreadInfo(DBNo);
                List<DataRow> lst = null;
                if (DAO.Default.dataBaseType == DataBaseType.Oracle)
                {
                    lst = (from a in busis.AsEnumerable()
                           join c in Sys_Roles.Default.AsEnumerable()
                           on a.Field<Int64>("MID") equals c.Field<Int64>("ID")
                           where DelList.Contains(Convert.ToInt32(a.Field<Int64>("ID")))
                           select c).ToList();
                }
                else
                {
                    lst = (from a in busis.AsEnumerable()
                           join c in Sys_Roles.Default.AsEnumerable()
                           on a.Field<int>("MID") equals c.Field<int>("ID")
                           where DelList.Contains(a.Field<int>("ID"))
                           select c).ToList();

                }
                if (lst != null && lst.Count > 0)
                {
                    foreach (DataRow row in lst)
                    {
                        Sys_Role role = Sys_Roles.GetItem(Convert.ToInt32(row["ID"]));
                        if (role != null)
                        {
                            role.ResetRoleUsers();
                        }
                    }
                }
                lock (_lock)
                {
                    foreach (var id in DelList)
                    {
                        DataRow[] drs = busis.Select(string.Format("ID={0}", id));
                        if (drs.Length == 0) continue;
                        busis.Rows.Remove(drs[0]);
                    }
                    busis.AcceptChanges();
                }
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

            sql = string.Format("select * from Sys_Role_User where ID in({0})", sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Role_Users busis = (Sys_Role_Users)busisData;
                    if (busis.Columns.Count != bv.Value.Columns.Count) return;
                    lock (_lock)
                    {
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

            sql = "SELECT r.ID FROM sys_Role_User b  INNER JOIN sys_Role r ON b.MID=r.ID where b.ID IN({0})";
            sql = string.Format(sql, sbd.ToString(0, sbd.Length - 1));
            bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                base.addThreadInfo(DBNo);
                foreach (DataRow row in bv.Value.Rows)
                {
                    Sys_Role busi = Sys_Roles.GetItem(Convert.ToInt32(row["ID"]));
                    if (busi == null) continue;
                    busi.ResetRoleUsers();
                }

            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Sys_Role_User : YueMES.Base.Dal.DRO
    {
        #region 私有的方法
        /// <summary>
        /// 初始化SystemArea对象
        /// </summary>
        internal protected Sys_Role_User(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 公开的属性
        #region 对应数据表字段的属性
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return Convert.ToInt32(this["ID"]); } }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int MID { get { return Convert.ToInt32(this["MID"]); } }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get { return Convert.ToInt32(this["UserID"]); } }
        #endregion
        #region 自定义的属性
        /// <summary>
        /// 拥有该对象的强类型对象
        /// </summary>
        public Sys_Role_Users Owner
        {
            get { return (Sys_Role_Users)this.Table; }
        }
        #endregion
        #endregion
        #region 自定义属性
        #endregion
        #region 公开的方法
        #endregion
        #region 静态的方法
        #endregion
    }
}