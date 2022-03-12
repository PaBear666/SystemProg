using System;
using System.Text;

namespace App.Infrastructure
{
    public class Logger : ILogger
    {
        public void LogError(Exception e, string message = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"[{DateTime.Now} ERR]: ");

            if(message != null)
            {
                stringBuilder.AppendLine(message);
            }

            stringBuilder.AppendLine($"Exception: {e}");
            Console.WriteLine(stringBuilder);
        }
    }
}
