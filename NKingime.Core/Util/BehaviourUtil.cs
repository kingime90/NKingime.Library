using System;
using System.Configuration;
using System.Linq;
using NKingime.Core.Config;
using System.Collections.Generic;

namespace NKingime.Core.Util
{
    /// <summary>
    /// 行为应用。
    /// </summary>
    public static class BehaviourUtil
    {
        /// <summary>
        /// 行为配置节名称。
        /// </summary>
        public const string SectionName = "custom.config/customBehaviour";

        /// <summary>
        /// 创建行为实例。
        /// </summary>
        /// <typeparam name="T">行为类型。</typeparam>
        /// <param name="behaviourType">行为类型，默认 null。</param>
        /// <returns></returns>
        public static T CreateBehaviourInstance<T>(Type behaviourType = null) where T : class
        {
            if (behaviourType == null)
                behaviourType = typeof(T);
            //
            var instance = CreateBehaviourInstance(typeof(T));
            return instance as T;
        }

        /// <summary>
        /// 创建行为实例。
        /// </summary>
        /// <param name="behaviourType">行为类型。</param>
        /// <returns></returns>
        public static object CreateBehaviourInstance(Type behaviourType)
        {
            var instanceElements = GetBehaviourInstanceElements(behaviourType);
            if (instanceElements == null || !instanceElements.Any())
                return null;
            //
            var instanceElement = instanceElements.OrderByDescending(s => s.Priority).FirstOrDefault(p => p.Enabled);
            if (instanceElement == null)
                return null;
            //
            return ReflectionUtil.CreateInstances(instanceElement.Assembly, instanceElement.TypeName, true);
        }

        /// <summary>
        /// 获取行为配置元素集合。
        /// </summary>
        /// <param name="sectionName">配置节名称。</param>
        /// <returns></returns>
        public static IEnumerable<BehaviourElement> GetBehaviourElements(string sectionName)
        {
            var customBehaviourSection = (CustomBehaviourSection)ConfigurationManager.GetSection(sectionName);
            return customBehaviourSection.Behaviours.Cast<BehaviourElement>();
        }

        /// <summary>
        /// 获取行为配置元素集合。
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<BehaviourElement> GetBehaviourElements()
        {
            return GetBehaviourElements(SectionName);
        }

        /// <summary>
        /// 获取行为配置元素。
        /// </summary>
        /// <param name="typeName">该类型的全名。</param>
        /// <param name="assemblyName">程序集的显示名称。请参见 System.Reflection.Assembly.FullName。</param>
        /// <returns></returns>
        public static BehaviourElement GetBehaviourElement(string typeName, string assemblyName)
        {
            var behaviourElements = GetBehaviourElements();
            return behaviourElements.FirstOrDefault(p => p.TypeName == typeName && p.Assembly == assemblyName);
        }

        /// <summary>
        /// 获取行为配置元素。
        /// </summary>
        /// <param name="behaviourType">行为类型。</param>
        /// <returns></returns>
        public static BehaviourElement GetBehaviourElement(Type behaviourType)
        {
            return GetBehaviourElement(behaviourType.FullName, behaviourType.Assembly.GetName().Name);
        }

        /// <summary>
        /// 获取行为配置元素。
        /// </summary>
        /// <typeparam name="T">行为类型。</typeparam>
        /// <returns></returns>
        public static BehaviourElement GetBehaviourElement<T>()
        {
            return GetBehaviourElement(typeof(T));
        }

        /// <summary>
        /// 获取行为实例配置元素集合。
        /// </summary>
        /// <param name="typeName">该类型的全名。</param>
        /// <param name="assemblyName">程序集的显示名称。请参见 System.Reflection.Assembly.FullName。</param>
        /// <returns></returns>
        public static IEnumerable<InstanceElement> GetBehaviourInstanceElements(string typeName, string assemblyName)
        {
            var behaviourElement = GetBehaviourElement(typeName, assemblyName);
            if (behaviourElement == null)
                return null;
            //
            return behaviourElement.Instances.Cast<InstanceElement>();
        }

        /// <summary>
        /// 获取行为实例配置元素集合。
        /// </summary>
        /// <param name="behaviourType">行为类型。</param>
        /// <returns></returns>
        public static IEnumerable<InstanceElement> GetBehaviourInstanceElements(Type behaviourType)
        {
            return GetBehaviourInstanceElements(behaviourType.FullName, behaviourType.Assembly.GetName().Name);
        }

        /// <summary>
        /// 获取行为实例配置元素集合。
        /// </summary>
        /// <typeparam name="T">行为类型。</typeparam>
        /// <returns></returns>
        public static IEnumerable<InstanceElement> GetBehaviourInstanceElements<T>()
        {
            return GetBehaviourInstanceElements(typeof(T));
        }
    }
}
