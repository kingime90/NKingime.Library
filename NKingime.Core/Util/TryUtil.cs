using System;
using NKingime.Core.Extentsion;

namespace NKingime.Core.Util
{
    /// <summary>
    /// 尝试应用。
    /// </summary>
    public static class TryUtil
    {
        /// <summary>
        /// 尝试调用指定无返回值的方法。
        /// </summary>
        /// <param name="tryAction">不具有参数并且没有返回值的方法。</param>
        /// <param name="exceptionAction">发生异常回调的方法（默认 null）。</param>
        public static void Action(Action tryAction, Action<Exception> exceptionAction = null)
        {
            try
            {
                tryAction();
            }
            catch (Exception ex)
            {
                if (exceptionAction.IsNotNull())
                    exceptionAction(ex);
            }
        }

        /// <summary>
        /// 尝试调用指定无返回值的方法。
        /// </summary>
        /// <typeparam name="T">不具有参数并且没有返回值的方法。</typeparam>
        /// <param name="tryFunc">具有返回值的方法。</param>
        /// <param name="exceptionFunc">发生异常回调的方法（默认 null）。</param>
        /// <returns></returns>
        public static T Action<T>(Action<T> tryAction, Action<Exception, T> exceptionAction = null) where T : class
        {
            T result = default(T);
            try
            {
                tryAction(result);
            }
            catch (Exception ex)
            {
                if (exceptionAction.IsNotNull())
                    exceptionAction(ex, result);
            }
            return result;
        }
    }
}
