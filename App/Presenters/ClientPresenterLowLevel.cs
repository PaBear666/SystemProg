using App.Controllers.Abstractions;
using App.Exceptions;
using App.Infrastructure;
using System;

namespace App.Entities
{
    class ClientPresenterLowLevel : IDisposable
    {
        private readonly Client _client;
        private readonly ILowLevelModel _lowLevelModel;
        private readonly ILogger _logger;

        public ClientPresenterLowLevel(Client client,ILowLevelModel lowLevelModel, ILogger logger)
        {
            _logger = logger;
            _client = client;
            _lowLevelModel = lowLevelModel;
            Init();
        }

        private void Init()
        {
            _client.button2.Click += Div;
            _client.button3.Click += Compare;
            _client.button4.Click += BitAnd;
        }

        private void BitAnd(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(_client.textBox1.Text);
                int b = int.Parse(_client.textBox2.Text);

                _client.textBox3.Text = _lowLevelModel.GetResultBitAnd(a, b).ToString();

            }
            catch (Exception)
            {
                _logger.LogError(new WrongFormatException(), "Неверный формат у операндов");
            }
        }

        private void Compare(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(_client.textBox1.Text);
                int b = int.Parse(_client.textBox2.Text);

                _client.textBox3.Text = _lowLevelModel.GetResultCompare(a, b).ToString();

            }
            catch(Exception)
            {
                _logger.LogError(new WrongFormatException(), "Неверный формат у операндов");
            }
            
        }

        private void Div(object sender, EventArgs e)
        {
            try
            {
                uint a = uint.Parse(_client.textBox1.Text);
                uint b = uint.Parse(_client.textBox2.Text);

                _client.textBox3.Text = _lowLevelModel.GetResultDivUn(a, b).ToString();

            }
            catch (Exception)
            {
                _logger.LogError(new WrongFormatException(), "Неверный формат у операндов");
            }
        }

        public void Dispose()
        {
            _client.button2.Click -= Div;
            _client.button3.Click -= Compare;
            _client.button4.Click -= BitAnd;
        }
    }
}
