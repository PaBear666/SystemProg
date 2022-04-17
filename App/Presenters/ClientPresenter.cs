using App.Controllers;
using App.Infrastructure;
using App.Presenters;
using DAL.Repositories;
using System.Windows.Forms;

namespace App.Entities
{
    public class ClientPresenter
    {
        private readonly Client _client;
        private readonly ILogger _logger;
        private  ClientPresenterFile _clientPresenterFile;
        private  ClientPresenterLowLevel _lowLevelModel;
        private  ClientPresenterAnalyzer _analyzerModel;

        public ClientPresenter(Client client)
        {
            _client = client;
            _logger = new Logger();
            _clientPresenterFile = new ClientPresenterFileResource(_client, new FileModel<Resource>(_logger), new FileRepository<Resource>());
            _analyzerModel = new ClientPresenterAnalyzer(_client, new AnalyzerModel(_logger));
            _lowLevelModel = new ClientPresenterLowLevel();

            _client.tabControl2.Selected += TabControl2_Selected;
            Application.Run(_client);
        }
        private void TabControl2_Selected(object sender, TabControlEventArgs e)
        {
            _clientPresenterFile?.Dispose();
            switch (e.TabPage.Text)
            {
                case "Ресурсы":
                    _clientPresenterFile = new ClientPresenterFileResource(_client, new FileModel<Resource>(_logger), new FileRepository<Resource>());
                    break;
                case "Доступы":
                    _clientPresenterFile = new ClientPresenterFileAccess(_client, new FileModel<Access>(_logger), new FileRepository<Access>());
                    break;
                case "Файлы":
                    _clientPresenterFile = new ClientPresenterFileFile(_client, new FileModel<File>(_logger), new FileRepository<File>());
                    break;
            }
            _client.comboBox1.SelectedIndex = 1;
        }
    }
}
