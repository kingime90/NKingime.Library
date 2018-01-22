using System;
using NUnit.Framework;
using System.Configuration;
using NKingime.Core.Config;
using System.Linq;
using NKingime.Core.Util;

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
            TryUtil.Action(() =>
            {
                int m = 100;
                int result = m / 0;
            }, true);
        }
    }
}
