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
        /// 实例集合。
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public InstanceCollection Instances
        {
            get { return (InstanceCollection)this[""]; }
        }
    }
}
