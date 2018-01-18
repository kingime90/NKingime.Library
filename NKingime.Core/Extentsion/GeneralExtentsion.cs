using System;
using System.Collections.Generic;
using System.Linq;

namespace NKingime.Core.Extentsion
{
    /// <summary>
    /// 常规扩展。
    /// </summary>
    public static class GeneralExtentsion
    {
        /// <summary>
        /// 指示指定的类型是否为 null。
        /// </summary>
        /// <typeparam name="T">要测试的类型。</typeparam>
        /// <param name="t">类型实例。</param>
        /// <returns>如果 t 参数为 null，则为 true；否则为 false。</returns>
        public static bool IsNull<T>(this T t)
        {
            return t == null;
        }

        /// <summary>
        /// 指示指定的类型是否不为 null。
        /// </summary>
        /// <typeparam name="T">要测试的类型。</typeparam>
        /// <param name="t">类型实例。</param>
        /// <returns>如果 t 参数不为 null，则为 true；否则为 false。</returns>
        public static bool IsNotNull<T>(this T t)
        {
            return !IsNull(t);
        }

        /// <summary>
        /// 获取指定类型实例或默认实例。
        /// </summary>
        /// <typeparam name="T">要获取的类型。</typeparam>
        /// <param name="t">要获取的类型实例。</param>
        /// <param name="defVal">默认类型实例。</param>
        /// <returns>如果 t 参数不为 null，则为 t；如果 defVal 参数不为 null，则为 defVal；否则为 default(T)。</returns>
        public static T GetOrDefault<T>(this T t, T defVal)
        {
            if (t.IsNotNull()) return t;
            //
            if (defVal.IsNotNull()) return defVal;
            //
            return default(T);
        }
    }
}