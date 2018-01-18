
namespace NKingime.Core.General
{
    /// <summary>
    /// 定义可设置或检索的键/值对。
    /// </summary>
    /// <typeparam name="TKey">键的类型。</typeparam>
    /// <typeparam name="TValue">值的类型。</typeparam>
    public class KeyValue<TKey, TValue>
    {
        public KeyValue()
        {

        }

        public KeyValue(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// 获取键/值对中的键。
        /// </summary>
        public TKey Key { get; set; }

        /// <summary>
        /// 获取键/值对中的值。
        /// </summary>
        public TValue Value { get; set; }
    }
}
