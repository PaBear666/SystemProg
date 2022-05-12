using App.Models.Abstractions;
using BLL.Exceptions;
using BLL.Logger;
using System;

namespace App.Presenters
{
    class LowLevelPresenter : IDisposable
    {
        private readonly IView _client;
        private readonly ILowLevelModel _lowLevelModel;
        private readonly ILogger _logger;

        public LowLevelPresenter(IView client,ILowLevelModel lowLevelModel, ILogger logger)
        {
            _logger = logger;
            _client = client;
            _lowLevelModel = lowLevelModel;
            Init();
        }

        private void Init()
        {
            _client.Button2.Click += Div;
            _client.Button3.Click += Compare;
            _client.Button4.Click += BitAnd;
        }

        private void BitAnd(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(_client.TextBox1.Text);
                int b = int.Parse(_client.TextBox2.Text);

                _client.TextBox3.Text = _lowLevelModel.GetResultBitAnd(a, b).ToString();

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
                int a = int.Parse(_client.TextBox1.Text);
                int b = int.Parse(_client.TextBox2.Text);

                _client.TextBox3.Text = _lowLevelModel.GetResultCompare(a, b).ToString();

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
                uint a = uint.Parse(_client.TextBox1.Text);
                uint b = uint.Parse(_client.TextBox2.Text);

                _client.TextBox3.Text = _lowLevelModel.GetResultDivUn(a, b).ToString();

            }
            catch (Exception)
            {
                _logger.LogError(new WrongFormatException(), "Неверный формат у операндов");
            }
        }

        public void Dispose()
        {
            _client.Button2.Click -= Div;
            _client.Button3.Click -= Compare;
            _client.Button4.Click -= BitAnd;
        }
    }
}
