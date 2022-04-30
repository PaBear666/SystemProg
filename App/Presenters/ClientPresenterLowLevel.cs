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

            
        }

        private void Div(object sender, EventArgs e)
        {

            
        }
        private void Div_Un(object sender, EventArgs e)
        {

            
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
