using System;
using NUnit.Framework;
using NKingime.Core.Config;
using System.Configuration;
using System.Linq;
using NKingime.Core.Log;
using NKingime.Core.Util;
using NKingime.Core.General;
using NKingime.Core.Tests.General;

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
            var baseInstance = new BehaviourBaseInstance();
            baseInstance.Info("循环开始......");
            for (int i = 0; i < 1000; i++)
            {
                baseInstance.Info($"系统当前时间：{DateTime.Now}");
            }
            baseInstance.Info("循环结束......");
            baseInstance.Info("睡眠开始......");
            System.Threading.Thread.Sleep(1000 * 60 * 2);
            baseInstance.Info("睡眠结束......");
        }
    }
}
