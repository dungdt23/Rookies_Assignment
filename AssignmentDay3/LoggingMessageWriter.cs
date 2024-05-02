using System.IO;
using System.Reflection;
namespace AssignmentDay3
{
    public class LoggingMessageWriter : IMessageWriter
    {
        private readonly ILogger<LoggingMessageWriter> _logger;
        private string? _logFilePath = string.Empty;
        public LoggingMessageWriter(ILogger<LoggingMessageWriter> logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.LogInformation(message);
        }

        public void WriteLog(string message, string filePath)
        {
            try
            {
                string fileName = "logFile_" + DateTime.Now.ToString("ddMMyyyy");
                using (StreamWriter w = File.AppendText(filePath + "\\" + fileName))
                {
                    w.WriteLine(message);
                }
            }
            catch (Exception ex)
            {

                Log(ex.Message);
            }
        }
    }
}
