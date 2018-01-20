using System;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Config/log4net.config", ConfigFileExtension = "config", Watch = true)]

namespace NKingime.Core.Log
{
    /// <summary>
    /// log4net日志记录器。
    /// </summary>
    public class Log4NetLogger
    {

    }
}
