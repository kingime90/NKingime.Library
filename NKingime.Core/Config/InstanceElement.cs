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
        /// 类型名称。
        /// </summary>
        [ConfigurationProperty("typeName")]
        public string TypeName
        {
            get { return Convert.ToString(this["typeName"]); }
            set { this["typeName"] = value; }
        }

        /// <summary>
        /// 程序集名称。
        /// </summary>
        [ConfigurationProperty("assembly")]
        public string Assembly
        {
            get { return Convert.ToString(this["assembly"]); }
            set { this["assembly"] = value; }
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
