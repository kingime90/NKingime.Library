using System;
using System.Configuration;

namespace NKingime.Core.Config
{
    /// <summary>
    /// 行为集合配置元素。
    /// </summary>
    public class BehaviourCollection : ConfigurationElementCollection
    {
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        protected override string ElementName
        {
            get
            {
                return "behaviour";
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new BehaviourElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((BehaviourElement)element).Name;
        }
    }
}
