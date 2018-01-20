using System;
using System.Configuration;

namespace NKingime.Core.Config
{
    /// <summary>
    /// 行为配置元素。
    /// </summary>
    public class BehaviourElement : ConfigurationElement
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
        /// 实例集合。
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public InstanceCollection Instances
        {
            get { return (InstanceCollection)this[""]; }
        }
    }
}
