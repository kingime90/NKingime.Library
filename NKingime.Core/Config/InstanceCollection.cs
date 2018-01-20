using System;
using System.Configuration;

namespace NKingime.Core.Config
{
    /// <summary>
    /// 实例集合配置元素。
    /// </summary>
    public class InstanceCollection : ConfigurationElementCollection
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
                return "instance";
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new InstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((InstanceElement)element).Name;
        }
    }
}
