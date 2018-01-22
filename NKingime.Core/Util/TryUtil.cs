using System;
using NKingime.Core.General;

namespace NKingime.Core.Util
{
    /// <summary>
    /// 尝试应用。
    /// </summary>
    public class TryUtil : BehaviourBase
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
                //if (exceptionAction != null)
                //    exceptionAction(ex);
                exceptionAction?.Invoke(ex);
            }
        }

        /// <summary>
        /// 尝试调用指定无返回值的方法。
        /// </summary>
        /// <param name="tryAction">不具有参数并且没有返回值的方法。</param>
        /// <param name="throwOnLog">发生异常是否记录日志。</param>
        public static void Action(Action tryAction, bool throwOnLog = false)
        {
            Action(tryAction, throwOnLog, "尝试调用方法，发生异常。");
        }

        /// <summary>
        /// 尝试调用指定无返回值的方法。
        /// </summary>
        /// <param name="tryAction">不具有参数并且没有返回值的方法。</param>
        /// <param name="throwOnLog">发生异常是否记录日志。</param>
        /// <param name="message">发生异常消息。</param>
        public static void Action(Action tryAction, bool throwOnLog, string message)
        {
            Action<Exception> exceptionAction = null;
            if (throwOnLog)
            {
                exceptionAction = (ex) =>
                {
                    Logger.Error(message, ex);
                };
            }
            Action(tryAction, exceptionAction);
        }
    }
}
