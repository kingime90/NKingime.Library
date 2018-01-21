using System;
using NUnit.Framework;
using NKingime.Core.Config;
using System.Configuration;
using System.Linq;
using NKingime.Core.Log;
using NKingime.Core.Util;

namespace NKingime.Core.Tests.Log
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class LoggerBaseTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Debug()
        {
            var customRegisterSection = (CustomRegisterSection)ConfigurationManager.GetSection("custom.config/customRegister");
            var behaviourElements = customRegisterSection.Behaviours.Cast<BehaviourElement>();
            var behaviourType = typeof(LoggerBase);
            string assemblyName = behaviourType.Assembly.GetName().Name;
            var behaviourElement = behaviourElements.FirstOrDefault(p => p.TypeName == behaviourType.FullName && p.Assembly == assemblyName);
            if (behaviourElement == null) return;
            //
            var instanceElements = behaviourElement.Instances.Cast<InstanceElement>();
            var instanceElement = instanceElements.OrderByDescending(s => s.Priority).FirstOrDefault(p => p.Enabled);
            if (instanceElement == null) return;
            //
            var instance = ReflectionUtil.CreateInstances(instanceElement.Assembly, instanceElement.TypeName, true);
            var logger = instance as LoggerBase;
            logger.DebugAsync($"系统当前时间：{DateTime.Now}");
        }
    }
}
