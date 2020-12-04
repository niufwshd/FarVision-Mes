using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace WebMES.Model.SystemModel
{
    public class Sys_Summarys : YueMES.Base.Dal.DTO
    {

        #region 初始化
        /// <summary>
        /// 从表sys_Summary中选择数据
        /// </summary>
        /// <param name="SqlString">参数化的Transact-SqlString 语句</param>
        protected internal Sys_Summarys(string SqlString)
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
        public new Sys_Summary this[int index] { get { return ((Sys_Summary)(this.Rows[index])); } }
        /// <summary>
        /// 从现有的行创建新行
        /// </summary>
        /// <param name="builder">一个 System.Data.DataRowBuilder 对象。</param>
        /// <returns></returns>
        protected override DataRow NewRowFromBuilder(DataRowBuilder builder) { return new Sys_Summary(builder); }
        /// <summary>
        /// 返回数据行的对象类型
        /// </summary>
        /// <returns></returns>
        protected override System.Type GetRowType() { return typeof(Sys_Summary); }
        #endregion
        #region 静态方法
        private static Sys_Summarys m_Default;
        public static Sys_Summarys Default
        {
            get
            {
                if (m_Default != null) return m_Default;
                m_Default = new Sys_Summarys(string.Format("select * from sys_Summary"));
                m_Default.TableName = "sys_Summary";
                return m_Default;
            }
        }
        internal static void SetDefaultNull()
        {
            m_Default = null;
        }
        public static Sys_Summary GetItem(int id)
        {
            Sys_Summary result = (Sys_Summary)Default.FindRow("ID", id);
            return result;
        }

        #endregion
    }

    /// <summary>
    /// 系统汇总记录
    /// </summary>
    public class Sys_Summary : YueMES.Base.Dal.DRO
    {

        #region 初始化
        /// <summary>
        /// 初始化sys_Summary对象
        /// </summary>
        internal protected Sys_Summary(System.Data.DataRowBuilder builder)
            : base(builder)
        {
        }
        #endregion
        #region 对应数据表字段的属性
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get { return (int)this["ID"]; } }
        /// <summary>
        /// 菜单编号
        /// </summary>
        public string MenuNo { get { return (string)this["MenuNo"]; } }
        /// <summary>
        /// 业务编号
        /// </summary>
        public string BusiNo { get { return (string)this["BusiNo"]; } }
        #endregion
        #region 公开的属性
        #endregion
        #region 公开的方法
        #endregion
        #region 静态方法
        #endregion
    }
}
