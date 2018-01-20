using NKingime.Core.Setting;
using System;

namespace NKingime.Core.Log
{
    /// <summary>
    /// 日志记录器。
    /// </summary>
    public interface ILogger: ISetting
    {
        /// <summary>
        /// 记录调试。
        /// </summary>
        /// <param name="message">消息。</param>
        void Debug(string message);

        /// <summary>
        /// 记录调试。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <param name="exception">异常。</param>
        void Debug(string message, Exception exception);

        /// <summary>
        /// 记录错误。
        /// </summary>
        /// <param name="message">消息。</param>
        void Error(string message);

        /// <summary>
        /// 记录错误。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <param name="exception">异常。</param>
        void Error(string message, Exception exception);

        /// <summary>
        /// 记录信息。
        /// </summary>
        /// <param name="message">消息。</param>
        void Info(string message);

        /// <summary>
        /// 记录信息。
        /// </summary>
        /// <param name="message">消息。</param>
        /// <param name="exception">异常。</param>
        void Info(string message, Exception exception);
    }
}
