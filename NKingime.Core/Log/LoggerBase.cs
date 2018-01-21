using System;
using System.Threading.Tasks;

namespace NKingime.Core.Log
{
    /// <summary>
    /// 日志记录器基类。
    /// </summary>
    public abstract class LoggerBase : ILogger
    {
        /// <summary>
        /// 记录调试。
        /// </summary>
        /// <param name="message"></param>
        public abstract void Debug(string message);

        /// <summary>
        /// 异步记录调试。
        /// </summary>
        /// <param name="message"></param>
        public virtual void DebugAsync(string message)
        {
            Task.Run(() =>
            {
                Debug(message);
            });
        }

        /// <summary>
        /// 记录调试。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Debug(string message, Exception exception);

        /// <summary>
        /// 异步记录调试。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public virtual void DebugAsync(string message, Exception exception)
        {
            Task.Run(() =>
            {
                Debug(message, exception);
            });
        }

        /// <summary>
        /// 记录错误。
        /// </summary>
        /// <param name="message"></param>
        public abstract void Error(string message);

        /// <summary>
        /// 异步记录错误。
        /// </summary>
        /// <param name="message"></param>
        public virtual void ErrorAsync(string message)
        {
            Task.Run(() =>
            {
                Error(message);
            });
        }

        /// <summary>
        /// 记录错误。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Error(string message, Exception exception);

        /// <summary>
        /// 异步记录错误。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public virtual void ErrorAsync(string message, Exception exception)
        {
            Task.Run(() =>
            {
                Error(message, exception);
            });
        }

        /// <summary>
        /// 记录信息。
        /// </summary>
        /// <param name="message"></param>
        public abstract void Info(string message);

        /// <summary>
        /// 异步记录信息。
        /// </summary>
        /// <param name="message"></param>
        public virtual void InfoAsync(string message)
        {
            Task.Run(() =>
            {
                Info(message);
            });
        }

        /// <summary>
        /// 异步记录信息。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Info(string message, Exception exception);

        /// <summary>
        /// 异步记录错误。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public virtual void InfoAsync(string message, Exception exception)
        {
            Task.Run(() =>
            {
                Info(message, exception);
            });
        }
    }
}
