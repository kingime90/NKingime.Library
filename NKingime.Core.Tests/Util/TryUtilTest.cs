using System;
using NUnit.Framework;
using System.Configuration;
using NKingime.Core.Config;
using System.Linq;

namespace NKingime.Core.Tests.Util
{
    /// <summary>
    /// 尝试应用单元测试。
    /// </summary>
    [TestFixture]
    public class TryUtilTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Action()
        {
            var customRegisterSection = (CustomRegisterSection)ConfigurationManager.GetSection("custom.config/customRegister");
            var behaviours = customRegisterSection.Behaviours.Cast<BehaviourElement>();
            foreach (var behaviour in behaviours)
            {
                var instances = behaviour.Instances.Cast<InstanceElement>();
                foreach (var instance in instances)
                {

                }
            }
        }
    }
}
