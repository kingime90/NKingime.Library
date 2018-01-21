using System;
using NKingime.Core.General;

namespace NKingime.Core.Tests.General
{
    /// <summary>
    /// 
    /// </summary>
    public class BehaviourBaseInstance : BehaviourBase
    {
        public void Info(string message)
        {
            Logger.Info(message);
        }
    }
}
