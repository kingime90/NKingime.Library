using System;
using System.Collections.Generic;
using System.Linq;

namespace NKingime.Core.Util
{
    /// <summary>
    /// 反射应用。
    /// </summary>
    public static class ReflectionUtil
    {
        /// <summary>
        /// 获取已加载到此应用程序域的执行上下文中的程序集中创建指定类型的实例分配集合。
        /// </summary>
        /// <typeparam name="T">要创建的实例分配基类型。</typeparam>
        /// <typeparam name="isAbstract">是否为抽象的并且必须被重写（默认 false）。</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> CreateInstances<T>(bool isAbstract = false) where T : class
        {
            var rootType = typeof(T);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(type => rootType.IsAssignableFrom(type) && type.IsAbstract == isAbstract);
            return types.Select(s => Activator.CreateInstance(s) as T);
        }
    }
}
