using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace Core.Helper
{

    /// <summary>
    /// Seperated inplementation of Nlog, using interface, logger can be changed in future, by changing settings
    /// in this class, this allows to plug another logger of change settings centrally.
    /// </summary>
   public class LoggingServiceHelper : ILoggingServiceHelper
    {
        private static Logger _logger;
        private NLog.Targets.FileTarget logfileWithStackTrace;
        public LoggingServiceHelper()
        {
            var config = new NLog.Config.LoggingConfiguration();

            logfileWithStackTrace = new NLog.Targets.FileTarget("logfile") { 
                Layout = "${longdate}|${processid}|${level:uppercase=true}|${sequenceid}|${stacktrace}|${message}${exception:format=ToString}",
                FileName = "${specialfolder:folder=LocalApplicationData}/Titli/${assembly-version}/logs/logfile.txt" ,
                ArchiveFileName = "${specialfolder:folder=LocalApplicationData}/Titli/${assembly-version}/archives/log.{#####}.txt",
                ArchiveAboveSize = 1024000, ArchiveNumbering = NLog.Targets.ArchiveNumberingMode.Sequence,
                KeepFileOpen =  false
            };

            //this is default target (commented), which emits minimal log, above target is having stacktrace included.
            //var logfileDefault = new NLog.Targets.FileTarget("logfileMinimal")
            //{
            //    FileName = "${specialfolder:folder=LocalApplicationData}/Titli/${assembly-version}/logs/logfile.txt",
            //    ArchiveFileName = "${specialfolder:folder=LocalApplicationData}/Titli/${assembly-version}/archives/log.{#####}.txt",
            //    ArchiveAboveSize = 1024000,
            //    ArchiveNumbering = NLog.Targets.ArchiveNumberingMode.Sequence,
            //    KeepFileOpen = false
            //};

            config.AddRule(LogLevel.Trace, LogLevel.Fatal, logfileWithStackTrace,"*");
            
            // Apply config           
            NLog.LogManager.Configuration = config;
            _logger = LogManager.GetCurrentClassLogger();
            
        }

        public void LogError(string msg)
        {
            _logger.Log(NLog.LogLevel.Error, msg);
        }

        public void LogInfo(string msg)
        {
            _logger.Log(NLog.LogLevel.Info, msg);
        }

        public void LogTrace(string msg)
        {
            _logger.Log(NLog.LogLevel.Trace, msg);
        }

        public void LogDebug(string msg)
        {
            _logger.Log(NLog.LogLevel.Debug, msg);
        }

        public void ChangeLoggingLevels(LogLevel minLevel)
        {
            var config = new NLog.Config.LoggingConfiguration();
            config.RemoveRuleByName("*");
            config.AddRule(minLevel, LogLevel.Fatal, logfileWithStackTrace, "*");
            NLog.LogManager.Configuration = config;
            _logger = LogManager.GetCurrentClassLogger();
        }
    }
}
