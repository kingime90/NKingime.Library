using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace NKingime.Core.Util
{
    /// <summary>
    /// JSON应用。
    /// </summary>
    public static class JsonUtil
    {
        /// <summary>
        /// JSON序列化默认设置。
        /// </summary>
        static JsonUtil()
        {
            if (JsonConvert.DefaultSettings == null)
            {
                JsonConvert.DefaultSettings = () =>
                {
                    return new JsonSerializerSettings
                    {
                        Converters = new List<JsonConverter>
                        {
                            //日期转换器
                            new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" },
                        },
                    };
                };
            }
        }

        /// <summary>
        /// 将指定的对象序列化为JSON字符串。
        /// </summary>
        /// <param name="value">要序列化的对象。</param>
        /// <returns></returns>
        public static string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// 将指定的对象序列化为JSON字符串。
        /// </summary>
        /// <param name="value">要序列化的对象。</param>
        /// <param name="format">指示应如何格式化输出。</param>
        /// <returns></returns>
        public static string Serialize(object value, Formatting format)
        {
            return JsonConvert.SerializeObject(value, format);
        }

        /// <summary>
        /// 将JSON字符串反序列化为动态类型。
        /// </summary>
        /// <param name="json">要反序列化的JSON字符串。</param>
        /// <returns></returns>
        public static dynamic Deserialize(string json)
        {
            return JObject.Parse(json);
        }

        /// <summary>
        /// 将JSON字符串反序列化为指定.NET类型。
        /// </summary>
        /// <param name="value">要反序列化的JSON字符串。</param>
        /// <param name="type">被反序列化的对象的类型。</param>
        /// <returns></returns>
        public static object Deserialize(string value, Type type)
        {
            return JsonConvert.DeserializeObject(value, type);
        }

        /// <summary>
        /// 将JSON字符串反序列化为指定.NET类型。
        /// </summary>
        /// <typeparam name="T">要反序列化的对象的类型。</typeparam>
        /// <param name="value">要反序列化的JSON字符串。</param>
        /// <returns></returns>
        public static T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        /// <summary>
        /// 将JSON字符串反序列化为指定的匿名类型。
        /// </summary>
        /// <typeparam name="T">要反序列化的对象的类型。</typeparam>
        /// <param name="value">要反序列化的JSON字符串。</param>
        /// <param name="anonymousTypeObject">匿名类型对象。</param>
        /// <returns></returns>
        public static T Deserialize<T>(string value, T anonymousTypeObject)
        {
            try
            {
                return JsonConvert.DeserializeAnonymousType(value, anonymousTypeObject);
            }
            catch
            {
                return anonymousTypeObject;
            }
        }
    }
}
