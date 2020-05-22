using Core.Helper;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titli.UnitTests
{
   class Stubs
    {

      public static void Run(ServiceContainer service)
        {
            CheckLoggingLevels(service);
        }

      public static void CheckLoggingLevels(ServiceContainer service)
        {
            ILoggingServiceHelper logger = service.GetInstance<ILoggingServiceHelper>();
            //logger.Log(NLog.LogLevel.Trace, "Test log");
            logger.LogTrace("Test Trace log");
            logger.ChangeLoggingLevels(NLog.LogLevel.Error);
            logger.LogTrace("Error log"); //This wont print, as min level is set to Error.
            logger.ChangeLoggingLevels(NLog.LogLevel.Trace);
            logger.LogTrace("Trace log"); //This will print, minlevel is trace again.
        }
    }
}
