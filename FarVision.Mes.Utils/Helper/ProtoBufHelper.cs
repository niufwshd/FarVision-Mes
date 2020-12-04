using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProtoBuf;
using System.Data;
using ProtoBuf.Data;
using YueMES.Base.Utils;

namespace WebMES.Utils
{
    public class ProtoBufHelper
    {
        public static byte[] Serializeby(object obj)
        {
            using (var stream = new MemoryStream())
            {
                if (obj is DataTable)
                {
                    DataSerializer.Serialize(stream, (DataTable)obj);
                    return stream.ToArray();
                }
                else if (obj is DataSet)
                {
                    DataSerializer.Serialize(stream, (DataSet)obj);
                    return stream.ToArray();
                
                }
                else
                {
                    Serializer.Serialize(stream, obj);
                    return stream.ToArray();
                }
                
            }
        }
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static byte[] Serialize<T>(T t)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                Serializer.Serialize<T>(ms, t);
                return ms.ToArray();

            }
        }

       
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        public static T DeSerialize<T>(string content)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                T t = Serializer.Deserialize<T>(ms);
                return t;
            }
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T DeSerialize<T>(Stream stream)
        {
            T t = Serializer.Deserialize<T>(stream);
            return t;
        }

        public static T DeSerialize<T>(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                T t = Serializer.Deserialize<T>(ms);
                return t;
            }
        }

        public static BooleanValue<DataTable> DeSerializeDataTable(byte[] buffer)
        {
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                DataTable dt = null;
                BooleanValue<DataTable> bv = new BooleanValue<DataTable>(dt);
                try
                {
                    dt = DataSerializer.DeserializeDataTable(ms);
                    bv.Value = dt;
                }
                catch (Exception ex)
                {
                    bv.ErrorText = ex.Message;
                }

                return bv;
            }
        }

        public static BooleanValue<DataSet> DeSerializeDataSet(byte[] buffer,params string[] tables)
        {
            
            using (MemoryStream ms = new MemoryStream(buffer))
            {
                DataSet ds = null;
                BooleanValue<DataSet> bv = new BooleanValue<DataSet>(ds);
                try
                {
                    ds = DataSerializer.DeserializeDataSet(ms, tables);
                     bv.Value = ds;
                }
                catch (Exception ex)
                {
                    bv.ErrorText = ex.Message;
                }
                
                return bv;
            }
        }

    }
}
