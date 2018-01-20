using NKingime.Core.Setting;
using System;

namespace NKingime.Core.Log
{
    /// <summary>
    /// 日志记录器基类。
    /// </summary>
    public abstract class LoggerBase : SettingBase, ILogger
    {
        /// <summary>
        /// 记录调试。
        /// </summary>
        /// <param name="message"></param>
        public abstract void Debug(string message);

        /// <summary>
        /// 记录调试。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Debug(string message, Exception exception);

        /// <summary>
        /// 记录错误。
        /// </summary>
        /// <param name="message"></param>
        public abstract void Error(string message);

        /// <summary>
        /// 记录错误。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Error(string message, Exception exception);

        /// <summary>
        /// 记录信息。
        /// </summary>
        /// <param name="message"></param>
        public abstract void Info(string message);

        /// <summary>
        /// 记录信息。
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public abstract void Info(string message, Exception exception);
    }
}
