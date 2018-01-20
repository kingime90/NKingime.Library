using NKingime.Core.Ioc;

namespace NKingime.Core.Setting
{
    /// <summary>
    /// 设置接口。
    /// </summary>
    public interface ISetting: IDependency
    {
        /// <summary>
        /// 名称。
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 描述。
        /// </summary>
        string Describe { get; }

        /// <summary>
        /// 是否启用。
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// 优先级（倒序）。
        /// </summary>
        int Priority { get; }
    }
}
