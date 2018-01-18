using System;
using NUnit.Framework;
using NKingime.Core.Extentsion;

namespace NKingime.Core.Tests.Extentsion
{
    /// <summary>
    /// 字符串扩展方法单元测试。
    /// </summary>
    [TestFixture]
    public class StringExtentsionTest
    {
        /// <summary>
        /// 测试指示指定的字符串是 null 还是 System.String.Empty 字符串。
        /// </summary>
        [Test]
        public void IsNullOrEmpty()
        {
            //测试字符串null
            string value = null;
            var result = value.IsNullOrEmpty();
            Assert.IsTrue(result);

            //测试字符串string.Empty
            value = string.Empty;
            result = value.IsNullOrEmpty();
            Assert.IsTrue(result);

            //测试字符串空白
            value = " ";
            result = value.IsNullOrEmpty();
            Assert.IsFalse(result);
        }

        /// <summary>
        /// 测试指示指定的字符串是 null、空还是仅由空白字符组成。
        /// </summary>
        [Test]
        public void IsNullOrWhiteSpace()
        {
            //测试字符串null
            string value = null;
            var result = value.IsNullOrWhiteSpace();
            Assert.IsTrue(result);

            //测试字符串string.Empty
            value = string.Empty;
            result = value.IsNullOrWhiteSpace();
            Assert.IsTrue(result);

            //测试字符串空白
            value = " ";
            result = value.IsNullOrWhiteSpace();
            Assert.IsTrue(result);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void GetString()
        {
            //测试获取字符串为null
            string value, defVal;
            value = null;
            defVal = string.Empty;
            string result = value.GetString();
            Assert.AreEqual(result, defVal);

            //测试获取字符串为默认值
            value = null;
            defVal = null;
            result = value.GetString(defVal);
            Assert.AreEqual(result, defVal);

            //测试获取字符串为默认值
            value = null;
            defVal = DateTime.Now.Ticks.ToString();
            result = value.GetString(defVal);
            Assert.AreEqual(result, defVal);

            //测试获取字符串不为null
            value = "Love";
            defVal = "Like";
            result = value.GetString(defVal);
            Assert.AreEqual(result, value);


        }
    }
}
