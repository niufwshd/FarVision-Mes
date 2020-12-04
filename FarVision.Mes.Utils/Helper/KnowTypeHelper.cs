using WebMES.DTO;
using WebMES.DTO.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WebMES.Utils
{
    public class KnowTypeHelper
    {
        public static IEnumerable<Type> GetKnownTypes(ICustomAttributeProvider provider)
        {
            Assembly asm= Assembly.GetAssembly(typeof(BaseDTO));
            List<Type> tList = new List<Type>();
            foreach (Type t in asm.GetTypes())
            {
                if (t.BaseType == typeof(BaseDTO))
                {
                    tList.Add(t);
                }
            }
            tList.Add(typeof(Image));
            tList.Add(typeof(Bitmap));
            tList.Add(typeof(int));
            return tList;
        }
    }
}
