#region 本页代码的部分或全部由自动代码生成器生成
// 自动代码生成器简介：
// 制作语言： Microsoft Visual Basic.NET(2003)
// 作者： 郭建光
// E-Mail： GuoJianGuang154@163.com
// QQ： 40808310
// 本页代码生成时间：2008年10月03日 15:37:28
#endregion
using System.Data;
using System.Collections.Generic;
using System.Linq;
using YueMES.Base.Dal;
using YueMES.Data.Business;
using YueMES.Data.Services;
using YueMES.Base.Utils;
using WebMES.Model.Data;
using System;
using System.Text;
using YueMES.Base.Enum;
using WebMES.Utils;
using YueMES.Base.DataBase;
using FarVision.Mes;

namespace WebMES.Model.SystemModel
{
    /// <summary>
    /// 系统用户信息
    /// </summary>
    public class Sys_Users : DTOExt, IConfigCache
    {
        private static object _lock = new object();
        public Sys_Users()
        {

        }
        #region 初始化
        /// <summary>
        /// 从表SystemArea中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Users(string SqlString)
            : base(SqlString)
        {

            BooleanResult br = this.Refresh();
            if (br.Success) { 

                if(!string.IsNullOrEmpty(SqlString) && this.Columns.Count>0){
                    YueMES.Base.Dal.DTO.AddInCache(SqlString, this);
                     CacheSyncServ.RegeditConfigCache(DAO.DBNo, this,SqlString);
                }
                return; 
            }
            dicDbDefaultError[DAO.DBNo] = br.ErrorText;
            //m_DefaultError = br.ErrorText;
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
        public new Sys_User this[int index] { get { return ((Sys_User)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_User(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_User); }
        #endregion
        #region 静态方法
        //private static string m_DefaultError;

        private static Dictionary<string, string> dicDbDefaultError = new Dictionary<string, string>();

        public static string DefaultError
        {
            get
            {
                if (dicDbDefaultError.ContainsKey(DAO.DBNo))
                {
                    return dicDbDefaultError[DAO.DBNo];
                }
                return null;
                //return m_DefaultError;
            }
        }

        private static string Default_sql = null;
        //private static Sys_Users m_Default;
        public static Sys_Users Default
        {
            get
            {
                Default_sql = string.Format("select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep=dp.dep");
                Sys_Users m_Default = null;

                YueMES.Base.Dal.DTO dto = null;
                if (Default_sql != null)
                    YueMES.Base.Dal.DTO.TryGetCache(Default_sql, out dto);
                if (dto != null)
                    m_Default = (Sys_Users)dto;


                if (m_Default != null && m_Default.Columns.Count>0) return m_Default;
                lock (_lock)
                {
                    if (m_Default == null || m_Default.Columns.Count == 0)
                    {
                        m_Default = new Sys_Users(Default_sql);
                        m_Default.TableName = "Sys_User";
                    }
                }

                if (m_Default != null && m_Default.Columns.Count > 0)
                {
                    YueMES.Base.Dal.DTO.AddInCache(Default_sql, m_Default);

                    //CacheSyncServ.RegeditConfigCache(DAO.DBNo, m_Default);
                }


                if (m_Default.Rows.Count > 0 &&  m_Default.Columns.Count > 0) return m_Default;
                m_Default = null;
                return m_Default;
            }
        }
        public static void SetDefaultNull()
        {
            if (Default_sql != null)
                YueMES.Base.Dal.DTO.CacheClear(Default_sql);
        }
        public static Sys_User GetItem(int id)
        {
            Sys_User result = (Sys_User)Default.FindRow("ID", id);
            if (result != null) return result;
            string sql = string.Format("select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep=dp.dep where su.ID={0}", id);
            BooleanValue<DataRow> bv = DAO.Default.GetDataRow(sql);
            DataRow dr = bv.Value;
            if (dr == null) return null;
            result = Default.LoadDataRow(dr, true) as Sys_User;
            return result;
        }


        /// <summary>
        /// 根据用户获取角色
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public static BooleanValue<DataTable> GetUserRoles(string UserNo)
        {
            string sql = $@"SELECT distinct sr.* from sys_Role_User sru
                        left join sys_Role sr on sr.ID=sru.MID
                        LEFT JOIN dbo.SYS_USER u ON u.id = sru.UserID
                        where u.no ='{UserNo}'";
            BooleanValue<DataTable> BV = DAO.Default.GetDataTable(sql);
            if (!BV.Success)
            {
                throw new Exception(BV.ErrorText);
            }
            return BV;
        }


        public static Sys_User GetItem(string no)
        {
            if (Default == null) return null;
            Sys_User result = (Sys_User)Default.FindRow("No", no);
            if (result != null) return result;
            string sql = "select su.*,sa.DEP,d.Name DepName from Sys_User su LEFT join salm sa on su.no=sa.SYS_USR left JOIN DEPT d on sa.DEP=d.DEP where su.No=@NO";
            BooleanValue<DataRow> bv = DAO.Default.GetDataRow(sql, new SqlParameters { DbParameters.CreateDbParameter("@NO", no, DbType.AnsiStringFixedLength, 50) });
            DataRow dr = bv.Value;
            if (dr == null) return null;
            result = Default.LoadDataRow(dr, true) as Sys_User;
            return result;
        }
        #endregion
        public string BusiNo
        {
            get { return "SYS_USER"; }
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

            sql = string.Format("select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep=dp.dep where su.ID in({0})", sbd.ToString(0, sbd.Length - 1));

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (CacheKey != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(string.IsNullOrEmpty(CacheKey)?Default_sql:CacheKey, DBNo, out busisData);
                    if (busisData == null) return;
                    Sys_Users busis = (Sys_Users)busisData;
                    lock (_lock)
                    {
                        if (busis.Columns.Count != bv.Value.Columns.Count) return;
                        foreach (DataRow row in bv.Value.Rows)
                        {
                            busis.LoadDataRow(row, true);
                        }

                        busis.AcceptChanges();
                    }
                }
              
            }

            sql="SELECT r.ID FROM sys_User a INNER JOIN sys_Role_User b ON a.ID=b.UserID INNER JOIN sys_Role r ON b.MID=r.ID where a.ID IN({0})";
            sql = string.Format(sql,sbd.ToString(0, sbd.Length - 1));
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

       

        public void RemoveRecord(List<int> DelList, DAO dao, string DBNo, string sysLinkName, string CacheKey = null)
        {
            if (DelList == null || DelList.Count == 0) return;
            if (CacheKey != null)
            {
                object busisData = null;
                YueMES.Base.Dal.DTO.TryGetCache(string.IsNullOrEmpty(CacheKey) ? Default_sql : CacheKey, DBNo, out busisData);
                if (busisData == null) return;
                Sys_Users busis = (Sys_Users)busisData;
                base.addThreadInfo(DBNo);
                List<DataRow> lst=null;
                if (DAO.Default.dataBaseType == DataBaseType.Oracle)
                {
                    lst = (from a in busis.AsEnumerable()
                            join b in Sys_Role_Users.Default.AsEnumerable()
                            on a.Field<Int64>("ID") equals b.Field<Int64>("UserID") 
                            join c in Sys_Roles.Default.AsEnumerable()
                            on b.Field<Int64>("MID") equals c.Field<Int64>("ID")
                            where DelList.Contains(Convert.ToInt32(a.Field<Int64>("ID")))
                            select c).ToList();
                }
                else
                {
                    lst = (from a in busis.AsEnumerable()
                           join b in Sys_Role_Users.Default.AsEnumerable()
                           on a.Field<int>("ID") equals b.Field<int>("UserID")
                           join c in Sys_Roles.Default.AsEnumerable()
                           on b.Field<int>("MID") equals c.Field<int>("ID")
                           where DelList.Contains(a.Field<int>("ID"))
                           select c).ToList();

                }
                if (lst != null && lst.Count > 0)
                {
                    foreach (DataRow row in lst)
                    {
                        Sys_Role role= Sys_Roles.GetItem(Convert.ToInt32(row["ID"]));
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

            sql = string.Format("select su.*,dp.name as DepName from Sys_User su left join dept dp on su.dep=dp.dep where su.ID in({0})", sbd.ToString(0, sbd.Length - 1));
           

            BooleanValue<DataTable> bv = dao.GetDataTable(sql);

            if (bv.Success && bv.Value.Rows.Count > 0)
            {
                if (CacheKey != null)
                {
                    object busisData = null;
                    YueMES.Base.Dal.DTO.TryGetCache(string.IsNullOrEmpty(CacheKey) ? Default_sql : CacheKey, DBNo, out busisData);
                    if (busisData == null) return;
                    Sys_Users busis = (Sys_Users)busisData;
                    lock (_lock)
                    {
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

            sql = "SELECT r.ID FROM sys_User a INNER JOIN sys_Role_User b ON a.ID=b.UserID INNER JOIN sys_Role r ON b.MID=r.ID where a.ID IN({0})";
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
    /// 系统用户记录
    /// </summary>
    public class Sys_User : SysUser
    {
        #region 自定义属性
        /// <summary>
        /// 返回该用户所属的角色列表
        /// </summary>
        public List<Sys_Role> OwnerRoles { get; set; }
        public Dictionary<string, Sys_Property_Sets> Menu_Properties { get;} 
        #endregion
    }
}