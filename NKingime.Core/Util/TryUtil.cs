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
        /// <param name="exceptionAction">发生异常回调的方法。</param>
        public static void Action(Action tryAction, Action<Exception> exceptionAction)
        {
            try
            {
                tryAction();
            }
            catch (Exception ex)
            {
                exceptionAction(ex);
            }
        }

        /// <summary>
        /// 尝试调用指定无返回值的方法。
        /// </summary>
        /// <param name="tryAction">不具有参数并且没有返回值的方法。</param>
        public static void Action(Action tryAction)
        {
            try
            {
                tryAction();
            }
            catch
            {

            }
        }
    }
}
