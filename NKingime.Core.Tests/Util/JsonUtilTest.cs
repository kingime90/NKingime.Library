using System;
using NUnit.Framework;
using NKingime.Core.Util;

namespace NKingime.Core.Tests.Util
{
    /// <summary>
    /// JSON应用测试。
    /// </summary>
    [TestFixture]
    public class JsonUtilTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Deserialize()
        {
            var entity = new { Success = false, Message = string.Empty };
            string json = "[]";
            var result = JsonUtil.Deserialize(json, entity);
        }
    }
}
