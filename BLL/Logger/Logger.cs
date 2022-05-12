using System;
using System.Text;

namespace BLL.Logger
{
    public class Logger : ILogger
    {
        readonly ILoggerContainer _textBox;
        public Logger(ILoggerContainer richText)
        {
            _textBox = richText;
        } 
        public void LogError(Exception e, string message = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"[{DateTime.Now} ERR]: ");

            if(message != null)
            {
                stringBuilder.AppendLine(message);
            }

            stringBuilder.AppendLine($"Exception: {e}");
            _textBox.AppendText(stringBuilder.ToString());
        }
    }
}
