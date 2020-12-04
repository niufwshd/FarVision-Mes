using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WebMES.Utils.Extensions
{
    public static class ObjectExtedsion
    {

        private static DBNull dbNull = DBNull.Value;

        public static int? ToIntOrNull(this object obj)
        {
            int? result = null;
            string value = obj.ToString();

            if (string.IsNullOrEmpty(value)) return result;

            if (int.TryParse(value, out int v)) return v;

            return result;
        }

        public static int ToInt(this object obj)
        {
            var result = 0;
            var value = obj.ToString();

            if (string.IsNullOrEmpty(value)) return result;

            if (int.TryParse(value, out int v)) return v;

            return result;
        }

        public static decimal? ToDecimalOrNull(this object obj)
        {
            decimal? result = null;
            
            string value = obj.ToString();

            if (string.IsNullOrEmpty(value)) return result;

            if (decimal.TryParse(value, out decimal v)) return v;

            return result;
        }

        public static decimal ToDecimal(this object obj)
        {
            var result = 0.00m;
            var value = obj.ToString();

            if (string.IsNullOrEmpty(value)) return result;

            if (decimal.TryParse(value, out decimal v)) return v;

            return result;
        }

        public static DateTime? ToDateTimeOrNull(this object obj)
        {
            DateTime? result = null;
            if (string.IsNullOrEmpty(obj.ToString())) return result;

            if (DateTime.TryParse(obj.ToString(), out DateTime v)) return v;

            return result;
        }

        public static DateTime ToDateTime(this object obj)
        {
            var result = DateTime.MinValue;

            if (string.IsNullOrEmpty(obj.ToString())) return result;

            if (DateTime.TryParse(obj.ToString(), out DateTime v)) return v;

            return result;
        }

        public static object ToDateTimeOrDBNull(this DateTime? dateTime)
        {
            if (dateTime == null) return dbNull;

            return dateTime.Value;
        }

        public static object ToDecimalOrDBNull(this decimal? dm)
        {
            var dbNull = DBNull.Value;
            if (dm == null) return dbNull;

            return dm.Value;
        }

        public static object ToIntOrDBNull(this int? i)
        {
            if (i == null) return dbNull;
            return i.Value;
        }

        public static object ToFloatOrDBNull(this float? f)
        {
            if (f == null) return dbNull;
            return f.Value;
        }

        public static object ToStringOrDBNull(this string s)
        {
            if (string.IsNullOrEmpty(s)) return dbNull;
            return s;
        }

        public static bool? ToBooleanOrNull(this object obj)
        {
            bool? result = null;

            var value = obj.ToString();
            if (string.IsNullOrEmpty(value)) return result;

            if (bool.TryParse(value, out bool v)) return v;

            return result;
        }


    }
}
