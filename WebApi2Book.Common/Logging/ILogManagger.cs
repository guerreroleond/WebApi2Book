using log4net;
using System;

namespace WebApi2Book.Common.Logging
{
    public interface ILogManagger
    {
        ILog GetLog(Type typeAssociatedWithRequestedLog);
    }
}
