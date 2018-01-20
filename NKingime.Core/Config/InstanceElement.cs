using System;
using System.Configuration;

namespace NKingime.Core.Config
{
    /// <summary>
    /// 实例配置元素。
    /// </summary>
    public class InstanceElement : ConfigurationElement
    {
        /// <summary>
        /// 名称。
        /// </summary>
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return Convert.ToString(this["name"]); }
            set { this["name"] = value; }
        }

        /// <summary>
        /// 类型。
        /// </summary>
        [ConfigurationProperty("type")]
        public string Type
        {
            get { return Convert.ToString(this["type"]); }
            set { this["type"] = value; }
        }

        /// <summary>
        /// 是否启用。
        /// </summary>
        [ConfigurationProperty("enabled")]
        public bool Enabled
        {
            get { return Convert.ToBoolean(this["enabled"]); }
            set { this["enabled"] = value; }
        }

        /// <summary>
        /// 优先级（倒序）。
        /// </summary>
        [ConfigurationProperty("priority")]
        public int Priority
        {
            get { return Convert.ToInt32(this["priority"]); }
            set { this["priority"] = value; }
        }
    }
}
