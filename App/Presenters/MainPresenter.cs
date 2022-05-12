using App.Models;
using App.Presenters;
using BLL.Entities;
using BLL.Logger;
using DAL.Repositories;
using System.Windows.Forms;

namespace App.Presenters
{
    public class MainPresenter
    {
        private readonly IView _client;
        private readonly ILogger _logger;
        private  ClientPresenterFile _clientPresenterFile;
        private  LowLevelPresenter _lowLevelPresenter;
        private  AnalyzerPresenter _analyzerPresenter;

        public MainPresenter(IView client)
        {
            _client = client;
            _logger = new Logger(_client.Logtext);
            _clientPresenterFile = new ClientPresenterFileResource(_client, new FileModel<Resource>(_logger), new FileRepository<Resource>());
            _analyzerPresenter = new AnalyzerPresenter(_client, new AnalyzerModel(_logger));
            _lowLevelPresenter = new LowLevelPresenter(_client, new LowLevelModel(), _logger);

            _client.TabControl2.Selected += TabControl2_Selected;
        }
        private void TabControl2_Selected(object sender, TabControlEventArgs e)
        {
            _clientPresenterFile?.Dispose();
            switch (e.TabPage.Text)
            {
                case "Записи о ресурсах":
                    _clientPresenterFile = new ClientPresenterFileResource(_client, new FileModel<Resource>(_logger), new FileRepository<Resource>());
                    break;
                case "Записи о dll":
                    _clientPresenterFile = new ClientPresenterFileDllRecord(_client, new FileModel<DllRecord>(_logger), new FileRepository<DllRecord>());
                    break;
                case "Записи о файлах":
                    _clientPresenterFile = new ClientPresenterFileFileRecord(_client, new FileModel<FileRecord>(_logger), new FileRepository<FileRecord>());
                    break;
            }
            _client.ComboBox1.SelectedIndex = 1;
        }
    }
}
