using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMES.DTO
{
    public class DataConvert
    {
        public static int StringToInteger(string value, int defaultValue)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;
            int result = defaultValue;
            if (int.TryParse(value, out result) == false) return defaultValue;
            return result;
        }
        public static bool StringToBoolean(string value, bool defaultValue)
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;
            bool result = defaultValue;
            if (bool.TryParse(value, out result) == false) return defaultValue;
            return result;
        }
    }
}
