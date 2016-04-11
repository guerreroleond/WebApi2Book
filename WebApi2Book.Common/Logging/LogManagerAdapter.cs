using log4net;
using System;

namespace WebApi2Book.Common.Logging
{
    public class LogManagerAdapter : ILogManagger
    {
        public ILog GetLog(Type typeAssociatedWithRequestedLog)
        {
            var log = LogManager.GetLogger(typeAssociatedWithRequestedLog);
            return log;
        }
    }
}
