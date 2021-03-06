#region 本页代码的部分或全部由自动代码生成器生成
// 自动代码生成器简介：
// 制作语言： Microsoft Visual Basic.NET(2003)
// 作者： 郭建光
// E-Mail： GuoJianGuang154@163.com
// QQ： 40808310
// 本页代码生成时间：2008年10月03日 15:37:28
#endregion
using System.Data;
using YueMES.Base.Dal;
using WebMES.Model.Data;
using System;
using YueMES.Data.Services;
using System.Text;
using YueMES.Base.Utils;
using System.Linq;
using YueMES.Base.Enum;
using System.Collections.Generic;
using FarVision.Mes;

namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 系统角色信息
    /// </summary>
    public class Sys_Roles : DTOExt, IConfigCache
    {
        private static object _lock = new object();

        #region 初始化
        /// <summary>
        /// 从表SystemArea中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Roles(string SqlString)
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
        public new Sys_Role this[int index] { get { return ((Sys_Role)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Role(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Role); }
        #endregion
        #region 静态方法
        private static string Default_sql = null;
        //private static Sys_Roles m_Default;
        /// <summary>
        /// 
        /// </summary>
        public static Sys_Roles Default
        {
            get
            {
                Default_sql = string.Format("select * from Sys_Role");
                Sys_Roles m_Default = null;

                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_Default = (Sys_Roles)dto;

                if (m_Default != null) return m_Default;
                lock (_lock)
                {
                    if (m_Default == null)
                    {
                        m_Default = new Sys_Roles(Default_sql);
                        m_Default.TableName = "Sys_Role";
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
        public static Sys_Role GetItem(int id)
        {
            Sys_Role result = (Sys_Role)Default.FindRow("ID", id);
            if (result != null) return result;
            string sql = string.Format("select * from Sys_Role where ID={0}", id);
            DataRow dr = DAO.Default.GetDataRow(sql).Value as DataRow;
            if (dr == null) return null;
            result = Default.LoadDataRow(dr, true) as Sys_Role;
            return result;

        }
        #endregion

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

            sql = string.Format("select * from Sys_Role where ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Roles busis = (Sys_Roles)busisData;
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
        }

        public string BusiNo
        {
            get { return "Sys_Role"; }
        }

        public void RemoveRecord(System.Collections.Generic.List<int> DelList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (DelList == null || DelList.Count == 0) return;
            if (Default_sql != null)
            {
                object busisData = null;
                YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                Sys_Roles busis = (Sys_Roles)busisData;
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

            sql = string.Format("select * from Sys_Role where ID in({0})", sbd.ToString(0, sbd.Length - 1));


            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (Default_sql != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, DBNo, out busisData);
                    Sys_Roles busis = (Sys_Roles)busisData;
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
        }
    }
    /// <summary>
    /// 系统角色记录
    /// </summary>
    public class Sys_Role: SysRole 
    {
        private object _lock = new object();

        #region 自定义属性
        private Sys_Users m_Users = null;
        /// <summary>
        /// 直接用户
        /// </summary>
        public Sys_Users Users
        {
            get
            {
                if (this.m_Users != null && this.m_Users.Rows.Count > 0) return this.m_Users;
                lock (_lock)
                {
                    if (this.m_Users != null && this.m_Users.Rows.Count > 0) return this.m_Users;
                    List<DataRow> usrs;
                    if (DAO.Default.dataBaseType == DataBaseType.Oracle)
                    {
                        usrs = (from a in Sys_Users.Default.AsEnumerable()
                                join b in Sys_Role_Users.Default.AsEnumerable()
                                on a.Field<Int64>("ID") equals b.Field<Int64>("UserID")
                                where b.Field<Int64>("MID") == (Int64)this.ID
                                select a).ToList();
                    }
                    else
                    {
                        usrs = (from a in Sys_Users.Default.AsEnumerable()
                                join b in Sys_Role_Users.Default.AsEnumerable()
                                    on a.Field<int>("ID") equals b.Field<int>("UserID")
                                where b.Field<int>("MID") == this.ID
                                select a).ToList();

                    }
                    if (usrs == null) return null;
                    this.m_Users = Sys_Users.Default.Clone() as Sys_Users;
                    foreach (DataRow row in usrs)
                    {
                        this.m_Users.LoadDataRow(row, true);
                    }
                }
                return this.m_Users;
            }
        }
        private Sys_Role_Menus m_Role_Menus = null;
        /// <summary>
        /// 菜单配置数据
        /// </summary>
        public Sys_Role_Menus Role_Menus
        {
            get
            {
                if (this.m_Role_Menus != null) return this.m_Role_Menus;
                this.TempSqlString = string.Format(@"select * from sys_Role_Menu ma where MID={0}", this.ID);
                this.m_Role_Menus = new Sys_Role_Menus(this.TempSqlString);
                return this.m_Role_Menus;
            }
        }

        public void ResetRoleUsers()
        {
            lock (_lock)
            {
                this.m_Users = null;
            }
        }
    }
}