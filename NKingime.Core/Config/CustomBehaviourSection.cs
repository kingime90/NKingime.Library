using System;
using System.Configuration;

namespace NKingime.Core.Config
{
    /// <summary>
    /// 自定行为配置节。
    /// </summary>
    public class CustomBehaviourSection : ConfigurationSection
    {
        /// <summary>
        /// 行为集合。
        /// </summary>
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public BehaviourCollection Behaviours
        {
            get { return (BehaviourCollection)this[""]; }
        }
    }
}
