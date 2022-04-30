using App.Controllers.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Entities
{
    class ClientPresenterLowLevel : IDisposable
    {
        private readonly Client _client;
        readonly ILowLevelModel _lowLevelModel; 

        //Client client, IFileModel fileModel
        public ClientPresenterLowLevel(Client client,ILowLevelModel lowLevelModel)
        {
            _client = client;
            _lowLevelModel = lowLevelModel;
            _client.button2.Click += new EventHandler(Div);
            _client.button3.Click += new EventHandler(Div_Un);
            
        }

        private void Div(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(_client.textBox2.Text);
                float b = Convert.ToSingle(_client.textBox3.Text);
                float result = _lowLevelModel.GetResultDiv(a, b);
                _client.textBox4.Text = result.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Неверный формат ввода");
            }
            
        }
        private void Div_Un(object sender, EventArgs e)
        {
            try
            {
                UInt32 a = Convert.ToUInt32(_client.textBox2.Text);
                UInt32 b = Convert.ToUInt32(_client.textBox3.Text);
                int result = (int)_lowLevelModel.GetResultDivUn(a, b);
                _client.textBox4.Text = result.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Неверный формат ввода");
            }
            
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
