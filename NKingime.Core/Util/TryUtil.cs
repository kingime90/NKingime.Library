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
        /// 尝试调用指定的方法。
        /// </summary>
        /// <param name="action">不具有参数并且没有返回值的方法。</param>
        /// <param name="exceptionAction">发生异常回调的方法（默认 null）。</param>
        public static void TryAction(Action action, Action<Exception> exceptionAction = null)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                if (exceptionAction.IsNotNull())
                    exceptionAction(ex);
            }
        }


    }
}
