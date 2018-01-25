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
        /// 尝试调用不具有参数并且没有返回值的方法。
        /// </summary>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="exceptionAction">发生异常调用的方法。</param>
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
        /// 尝试调用不具有参数并且没有返回值的方法。
        /// </summary>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="throwOnLog">发生异常是否记录日志。</param>
        public static void Action(Action tryAction, bool throwOnLog = false)
        {
            Action(tryAction, throwOnLog, "尝试调用方法，发生异常。");
        }

        /// <summary>
        /// 尝试调用不具有参数并且没有返回值的方法。
        /// </summary>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="throwOnLog">发生异常是否记录日志。</param>
        /// <param name="message">发生异常记录的日志消息。</param>
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

        /// <summary>
        /// 尝试调用具有一个参数并且没有返回值的方法。
        /// </summary>
        /// <typeparam name="T">参数类型。</typeparam>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="parame">尝试要调用方法的参数。</param>
        /// <param name="exceptionAction">发生异常调用的方法。</param>
        public static void Action<T>(Action<T> tryAction, T parame, Action<Exception, T> exceptionAction)
        {
            Action<Exception> anonymousAction = null;
            if (exceptionAction != null)
            {
                anonymousAction = (ex) =>
                {
                    exceptionAction(ex, parame);
                };
            }
            Action(() =>
            {
                tryAction(parame);
            }, anonymousAction);
        }

        /// <summary>
        /// 尝试调用具有一个参数并且没有返回值的方法。
        /// </summary>
        /// <typeparam name="T">参数类型。</typeparam>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="parame">尝试要调用方法的参数。</param>
        /// <param name="exceptionAction">发生异常调用的方法。</param>
        public static void Action<T>(Action<T> tryAction, T parame, Action<Exception> exceptionAction)
        {
            Action(() =>
            {
                tryAction(parame);
            }, exceptionAction);
        }

        /// <summary>
        /// 尝试调用具有一个参数并且没有返回值的方法。
        /// </summary>
        /// <typeparam name="T">参数类型。</typeparam>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="parame">尝试要调用方法的参数。</param>
        /// <param name="throwOnLog">发生异常是否记录日志。</param>
        public static void Action<T>(Action<T> tryAction, T parame, bool throwOnLog = false)
        {
            Action(() =>
            {
                tryAction(parame);
            }, throwOnLog);
        }

        /// <summary>
        /// 尝试调用具有一个参数并且没有返回值的方法。
        /// </summary>
        /// <typeparam name="T">参数类型。</typeparam>
        /// <param name="tryAction">尝试要调用的方法。</param>
        /// <param name="parame">尝试要调用方法的参数。</param>
        /// <param name="throwOnLog">发生异常是否记录日志。</param>
        /// <param name="message">发生异常记录的日志消息。</param>
        public static void Action<T>(Action<T> tryAction, T parame, bool throwOnLog, string message)
        {
            Action(() =>
            {
                tryAction(parame);
            }, throwOnLog, message);
        }
    }
}
