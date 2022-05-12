using App.Models.Abstractions;
using BLL.Analyzer;
using System;
using System.Windows.Forms;

namespace App.Presenters
{
    class AnalyzerPresenter : IDisposable
    {
        readonly IView _client;
        readonly IAnalyzerModel _analyzer;
        TextBox _textBox;
        public AnalyzerPresenter(IView client, IAnalyzerModel analyzer)
        {
            _client = client;
            _analyzer = analyzer;
            _textBox = _client.DoWhileTextBox;
            Init();
        }
        public void InputVS_TextChanged(object sender, EventArgs e)
        {
            var result = _analyzer.Execute(_client.InputVS.Text);
            if (!result.Compiled)
            {
                _client.OutputVS.Text = result.Message ?? "Не скомпилировано";
                _textBox.Text = "";
            }
            else
            {
                _client.OutputVS.Text = "Cкомпилировано";
                _textBox.Text = result.Value;
            }
        }

        public void Init()
        {
            _client.TabControl3.Selected += TabControl3_TabIndexChanged;
            _client.Button1.Click += new EventHandler(InputVS_TextChanged);
        }

        private void TabControl3_TabIndexChanged(object sender, EventArgs e)
        {
            switch (_client.TabControl3.SelectedTab.Text)
            {
                case "do while":
                    _analyzer.SetDesign(CsharpDesign.DoWhile);
                    _textBox = _client.DoWhileTextBox;
                    break;
                case "if":
                    _analyzer.SetDesign(CsharpDesign.If);
                    _textBox = _client.IfTextBox;
                    break;
            }
        }

        public void Dispose()
        {
            _client.Button1.Click -= new EventHandler(InputVS_TextChanged);
            _client.TabControl3.Selected -= TabControl3_TabIndexChanged;
        }
    }
}
