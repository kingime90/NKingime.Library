using System;

namespace NKingime.Core.Util
{
    /// <summary>
    /// 枚举应用。
    /// </summary>
    public static class EnumUtil
    {
        /// <summary>
        /// 将一个或多个枚举常数的名称或数字值的字符串表示转换成等效的枚举对象。一个参数指定该操作是否区分大小写。用于指示转换是否成功的返回值。
        /// </summary>
        /// <typeparam name="TEnum">要将 value 转换为的枚举类型。</typeparam>
        /// <param name="value">要转换的枚举名称或基础值的字符串表示形式。</param>
        /// <param name="ignoreCase">true 表示不区分大小写；false 表示区分大小写（默认 true）。</param>
        /// <param name="defaultValue">转换失败默认值（默认 null）。</param>
        /// <returns></returns>
        public static TEnum? TryParse<TEnum>(string value, bool ignoreCase = true, TEnum? defaultValue = null) where TEnum : struct
        {
            TEnum temp;
            if (Enum.TryParse(value, ignoreCase, out temp))
                return temp;
            //
            return defaultValue;
        }
    }
}
