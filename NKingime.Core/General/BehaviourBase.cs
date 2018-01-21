using System;
using NKingime.Core.Log;
using NKingime.Core.Util;

namespace NKingime.Core.General
{
    /// <summary>
    /// 行为基类。
    /// </summary>
    public abstract class BehaviourBase
    {
        /// <summary>
        /// 行为配置节名称。
        /// </summary>
        public const string SectionName = "custom.config/customBehaviour";

        static BehaviourBase()
        {
            Logger = CreateBehaviourInstance<LoggerBase>();
        }

        protected BehaviourBase()
        {

        }

        /// <summary>
        /// 日志记录器基类。
        /// </summary>
        public static readonly LoggerBase Logger;

        /// <summary>
        /// 创建行为实例。
        /// </summary>
        /// <typeparam name="T">行为类型。</typeparam>
        /// <param name="behaviourType">行为类型，默认 null。</param>
        /// <returns></returns>
        public static T CreateBehaviourInstance<T>(Type behaviourType = null) where T : class
        {
            return BehaviourUtil.CreateBehaviourInstance<T>(behaviourType);
        }
    }
}
