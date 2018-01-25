using NKingime.Core.Extentsion;
using NKingime.Core.Flag;
using NUnit.Framework;

namespace NKingime.Core.Tests.Extentsion
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class GeneralExtentsionTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void IsRange()
        {
            int value = 10;
            int minValue, maxValue;
            minValue = 10;
            maxValue = 11;
            var result = value.IsRange(minValue, maxValue, CompareFlag.GreaterAndLess);
            result = value.CompareTo(minValue) > 0;
            result = value.CompareTo(maxValue) < 0;
        }
    }
}
