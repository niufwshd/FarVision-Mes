using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WebMES.Utils.DataExtend
{
    /// <summary>
    /// 对象拼接sql语句
    /// </summary>
    public class SqlBuilderHelper
    {
        /// <summary>
        /// Insert SQL语句
        /// </summary>
        /// <param name="obj">要转换的对象，不可空</param>
        /// <param name="tableName">要添加的表明，不可空</param>
        /// <returns>
        /// 空
        /// sql语句
        /// </returns>
        public static string InsertSql<T>(T t, string tableName) where T : class
        {
            if (t == null || string.IsNullOrEmpty(tableName))
            {
                return string.Empty;
            }
            string columns = GetColmons(t);
            if (string.IsNullOrEmpty(columns))
            {
                return string.Empty;
            }
            string values = GetValues(t);
            if (string.IsNullOrEmpty(values))
            {
                return string.Empty;
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into " + tableName);
            sql.Append("(" + columns + ")");
            sql.Append(" values(" + values + ")");
            return sql.ToString();
        }

        /// <summary>
        /// BulkInsert SQL语句（批量添加）
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="objs">要转换的对象集合，不可空</param>
        /// <param name="tableName">>要添加的表明，不可空</param>
        /// <returns>
        /// 空
        /// sql语句
        /// </returns>
        public static string BulkInsertSql<T>(List<T> objs, string tableName) where T : class
        {
            if (objs == null || objs.Count == 0 || string.IsNullOrEmpty(tableName))
            {
                return string.Empty;
            }
            string columns = GetColmons(objs[0]);
            if (string.IsNullOrEmpty(columns))
            {
                return string.Empty;
            }
            string values = string.Join(",", objs.Select(p => string.Format("({0})", GetValues(p))).ToArray());
            StringBuilder sql = new StringBuilder();
            sql.Append("Insert into " + tableName);
            sql.Append("(" + columns + ")");
            sql.Append(" values " + values + "");
            return sql.ToString();
        }

        /// <summary>
        /// 获得类型的列名
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string GetColmons<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return string.Join(",", obj.GetType().GetProperties().Select(p => p.Name).ToList());
        }

        /// <summary>
        /// 获得值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string GetValues<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return string.Join(",", obj.GetType().GetProperties().Select(p => string.Format("'{0}'", p.GetValue(obj))).ToArray());
        }


        /// <summary>
        /// 根据实体类生成sql语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="keyFiled"></param>
        /// <returns></returns>
        public static string UpdateSqlParms<T>(string tableName, string keyFiled = "ID") where T : class
        {
            var typ = typeof(T);
            object o = Activator.CreateInstance<T>();
            if (string.IsNullOrEmpty(tableName))
                tableName = typ.Name;
            if (o == null || string.IsNullOrEmpty(tableName))
                return string.Empty;
            string sql = $"UPDATE {tableName} SET {GetUpdateFiled(o, keyFiled)} WHERE {keyFiled }=@{keyFiled };";
            return sql;
        }

        /// <summary>
        /// 获得类型的列名
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static string GetUpdateFiled<T>(T obj, string keyFiled)
        {
            if (obj == null)
                return string.Empty;
            var arr = obj.GetType().GetProperties().Where(x => x.Name != keyFiled).Select(x => $"{x.Name}=@{x.Name}").ToList();
            return string.Join(",", arr);
        }
    }
}
