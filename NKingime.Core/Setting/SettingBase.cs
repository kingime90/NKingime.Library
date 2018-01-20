using System;

namespace NKingime.Core.Setting
{
    /// <summary>
    /// 设置接口基类。
    /// </summary>
    public abstract class SettingBase : ISetting
    {
        /// <summary>
        /// 名称。
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// 描述。
        /// </summary>
        public abstract string Describe { get; }

        /// <summary>
        /// 是否启用。
        /// </summary>
        public abstract bool Enabled { get; }

        /// <summary>
        /// 优先级（倒序）。
        /// </summary>
        public abstract int Priority { get; }
    }
}
