using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKingime.Core.Log
{
    /// <summary>
    /// 日志记录器。
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// 是否启用。
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// 优先级（倒序）。
        /// </summary>
        int Priority { get; }

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
