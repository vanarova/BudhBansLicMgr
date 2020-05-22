using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helper
{
   public interface ILoggingServiceHelper
    {

        void LogTrace(string msg);

        void LogInfo(string msg);

        void LogError(string msg);

        void LogDebug(string msg);

        void ChangeLoggingLevels(NLog.LogLevel minLevel);
    }
}
