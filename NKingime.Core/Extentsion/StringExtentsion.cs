using NKingime.Core.Flag;

namespace NKingime.Core.Extentsion
{
    /// <summary>
    /// 字符串扩展方法。
    /// </summary>
    public static class StringExtentsion
    {

        /// <summary>
        /// 指示指定的字符串是 null 还是 System.String.Empty 字符串。
        /// </summary>
        /// <param name="value">要测试的字符串。</param>
        /// <returns>如果 value 参数为 null 或空字符串 ("")，则为 true；否则为 false。</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// 指示指定的字符串是 null、空还是仅由空白字符组成。
        /// </summary>
        /// <param name="value">要测试的字符串。</param>
        /// <returns>如果 value 参数为 null 或 System.String.Empty，或者如果 value 仅由空白字符组成，则为 true。</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static string GetString(this string value, string defVal = "")
        {
            return value.GetOrDefault(defVal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trimFlag"></param>
        /// <param name="trimChars"></param>
        /// <returns></returns>
        public static string GetString(this string value, TrimStringFlag trimFlag, params char[] trimChars)
        {
            return GetString(value, string.Empty, trimFlag, trimChars);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="defVal"></param>
        /// <param name="trimFlag"></param>
        /// <param name="trimChars"></param>
        /// <returns></returns>
        public static string GetString(this string value, string defVal, TrimStringFlag trimFlag, params char[] trimChars)
        {
            return value.GetOrDefault(defVal).Trim(trimFlag, trimChars);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="trimFlag"></param>
        /// <param name="trimChars"></param>
        /// <returns></returns>
        public static string Trim(this string value, TrimStringFlag trimFlag, params char[] trimChars)
        {
            switch (trimFlag)
            {
                case TrimStringFlag.Start:
                    return value.TrimStart(trimChars);
                case TrimStringFlag.End:
                    return value.TrimEnd(trimChars);
                case TrimStringFlag.All:
                    return value.Trim(trimChars);
            }
            return value;
        }
    }
}
