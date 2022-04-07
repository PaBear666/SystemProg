using App.Controllers.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    class ClientPresenterAnalyzer : IDisposable
    {
        readonly Client _client;
        readonly IAnalyzerModel _analyzer;
        public ClientPresenterAnalyzer(Client client, IAnalyzerModel analyzer)
        {
            _client = client;
            _analyzer = analyzer;
        }
        public void InputVS_TextChanged(object sender, EventArgs e)
        {
            var result = _analyzer.Execute(_client.inputVS.Text);
            if (!result.Compiled)
            {
                _client.outputVS.Text = result.Message ?? "Не скомпилировано";
                _client.outputVS.ForeColor = System.Drawing.Color.Red;
                _client.textBox1.Text = "0";
            }
            else
            {
                _client.outputVS.Text = "Cкомпилировано";
                _client.outputVS.ForeColor = System.Drawing.Color.Green;
                _client.textBox1.Text = result.Value.ToString();
            }
        }

        public void Init()
        {
            _client.button1.Click += new EventHandler(InputVS_TextChanged);
        }

        public void Dispose()
        {
            _client.button1.Click -= new EventHandler(InputVS_TextChanged);
        }
    }
}
