using App.Models.Abstractions;
using BLL.Analyzer;
using System;
using System.Windows.Forms;

namespace App.Presenters
{
    class AnalyzerPresenter : IDisposable
    {
        readonly ApplicationUI _client;
        readonly IAnalyzerModel _analyzer;
        TextBox _textBox;
        public AnalyzerPresenter(ApplicationUI client, IAnalyzerModel analyzer)
        {
            _client = client;
            _analyzer = analyzer;
            _textBox = _client.doWhileTextBox;
            Init();
        }
        public void InputVS_TextChanged(object sender, EventArgs e)
        {
            var result = _analyzer.Execute(_client.inputVS.Text);
            if (!result.Compiled)
            {
                _client.outputVS.Text = result.Message ?? "Не скомпилировано";
                _textBox.Text = "";
            }
            else
            {
                _client.outputVS.Text = "Cкомпилировано";
                _textBox.Text = result.Value;
            }
        }

        public void Init()
        {
            _client.tabControl3.Selected += TabControl3_TabIndexChanged;
            _client.button1.Click += new EventHandler(InputVS_TextChanged);
        }

        private void TabControl3_TabIndexChanged(object sender, EventArgs e)
        {
            switch (_client.tabControl3.SelectedTab.Text)
            {
                case "do while":
                    _analyzer.SetDesign(CsharpDesign.DoWhile);
                    _textBox = _client.doWhileTextBox;
                    break;
                case "if":
                    _analyzer.SetDesign(CsharpDesign.If);
                    _textBox = _client.ifTextBox;
                    break;
            }
        }

        public void Dispose()
        {
            _client.button1.Click -= new EventHandler(InputVS_TextChanged);
            _client.tabControl3.Selected -= TabControl3_TabIndexChanged;
        }
    }
}
