using System;
using System.Text;
using System.Windows.Forms;

namespace App.Infrastructure
{
    public class Logger : ILogger
    {
        readonly RichTextBox _textBox;
        public Logger(RichTextBox richText)
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
            _textBox.Text = stringBuilder.ToString();
        }
    }
}
