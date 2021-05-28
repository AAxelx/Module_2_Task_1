using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Task_1
{
    public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private readonly StringBuilder _logs = new StringBuilder();

        static Logger()
        {
        }
        private Logger() 
        { 
        }
        public static Logger Instance => _instance;
        public string Logs => _logs.ToString();
        public void LoggerEventInfo(string message)
        {
            LogEvent(LogType.Info, message);
        }
        public void LoggerEventWarning(string message)
        {
            LogEvent(LogType.Warning, message);
        }
        public void LoggerEventError(string message)
        {
            LogEvent(LogType.Error, message);
        }
        public void LogEvent(LogType logType, string message)
        {
            var logMessage = $"{DateTime.UtcNow}: {logType} {message}";

            Console.WriteLine(logMessage);
            _logs.AppendLine(logMessage);
        }
    }
}
