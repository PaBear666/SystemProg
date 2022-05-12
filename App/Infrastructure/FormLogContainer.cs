using BLL.Logger;
using System.Windows.Forms;

namespace App.Infrastructure
{
    class FormLogContainer : ILoggerContainer
    {
        RichTextBox _textBox;
        public FormLogContainer(RichTextBox richTextBox)
        {
            _textBox = richTextBox;
        }

        public void AppendText(string log)
        {
            _textBox.Text += log;
        }

    }
}
