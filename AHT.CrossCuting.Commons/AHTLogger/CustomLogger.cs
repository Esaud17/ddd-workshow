using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.CrossCuting.Commons.AHTLogger
{
    public class CustomLogger : ICustomLogger
    {
        private readonly ILogger _logger;

        public CustomLogger(ILogger logger)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            _logger = logger;
        }

        public void Debug(string method, string message)
        {
            LogEventInfo logEvent = new LogEventInfo(LogLevel.Debug, "", message);
            logEvent.Properties["Method"] = method;

            _logger.Log(logEvent);
        }

        public void Error(string method, string message)
        {
            LogEventInfo logEvent = new LogEventInfo(LogLevel.Error, "", message);
            logEvent.Properties["Method"] = method;

            _logger.Log(logEvent);
        }
    }
}
