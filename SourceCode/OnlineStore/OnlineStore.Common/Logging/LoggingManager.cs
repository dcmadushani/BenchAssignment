using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Common.Logging
{
    public class LoggingManager
    {
        private Logger log = LogManager.GetCurrentClassLogger();

        public void Error(string message)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine();
            formattedMessage.AppendLine($"***********************{DateTime.Now}:{LogLevel.Error}");
            formattedMessage.AppendLine(message);
            log.Error(formattedMessage);
            formattedMessage.Clear();
        }

        public void Info(string message)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine();
            formattedMessage.AppendLine($"***********************{DateTime.Now}:{LogLevel.Info}");
            formattedMessage.AppendLine(message);
            log.Error(formattedMessage);
            formattedMessage.Clear(); 
        }
    }
}
