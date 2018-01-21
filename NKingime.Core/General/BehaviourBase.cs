using System;
using NKingime.Core.Config;
using NKingime.Core.Log;
using NKingime.Core.Util;
using System.Configuration;
using System.Linq;

namespace NKingime.Core.General
{
    /// <summary>
    /// 行为基类。
    /// </summary>
    public class BehaviourBase
    {
        /// <summary>
        /// 行为配置节名称。
        /// </summary>
        public const string SectionName = "custom.config/customBehaviour";

        static BehaviourBase()
        {
            Logger = CreateBehaviourInstance<LoggerBase>();
        }

        private BehaviourBase()
        {
            
        }

        /// <summary>
        /// 日志记录器基类。
        /// </summary>
        public static LoggerBase Logger { get; private set; }

        /// <summary>
        /// 创建行为实例。
        /// </summary>
        /// <typeparam name="T">行为类型。</typeparam>
        /// <returns></returns>
        public static T CreateBehaviourInstance<T>() where T : class
        {
            T result = default(T);
            var customBehaviourSection = (CustomBehaviourSection)ConfigurationManager.GetSection(SectionName);
            var behaviourElements = customBehaviourSection.Behaviours.Cast<BehaviourElement>();
            var behaviourType = typeof(T);
            string assemblyName = behaviourType.Assembly.GetName().Name;
            var behaviourElement = behaviourElements.FirstOrDefault(p => p.TypeName == behaviourType.FullName && p.Assembly == assemblyName);
            if (behaviourElement == null)
                return result;
            //
            var instanceElements = behaviourElement.Instances.Cast<InstanceElement>();
            var instanceElement = instanceElements.OrderByDescending(s => s.Priority).FirstOrDefault(p => p.Enabled);
            if (instanceElement == null)
                return result;
            //
            var instance = ReflectionUtil.CreateInstances(instanceElement.Assembly, instanceElement.TypeName, true);
            result = instance as T;
            return result;
        }
    }
}
