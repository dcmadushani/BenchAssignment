using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Common.Logging
{
    public class LoggingManager
    {
        private Logger log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Method to log errors
        /// </summary>
        /// <param name="message"></param>
        public void Error(string message)
        {
            StringBuilder formattedMessage = new StringBuilder();
            formattedMessage.AppendLine();
            formattedMessage.AppendLine($"***********************{DateTime.Now}:{LogLevel.Error}");
            formattedMessage.AppendLine(message);
            log.Error(formattedMessage);
            formattedMessage.Clear();
        }

        /// <summary>
        /// Method to log information
        /// </summary>
        /// <param name="message"></param>
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
