using App.Controllers;
using App.Controllers.Abstractions;
using App.Infrastructure;
using DAL.Providers;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Presenters
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
            Init(client);
            _logger = new Logger();
            //Говно ебанное не работает, с 0 на 0 не срабатаывает событие
            _client.tabControl1.SelectedIndex = 0;
            Application.Run(_client);
        }

        public void Init(Client client)
        {
            _client.tabControl1.Selecting += tabControl1_SelectedIndexChanged;

        }

        private void tabControl1_SelectedIndexChanged(object sender, TabControlCancelEventArgs e)
        {
            switch (_client.tabControl1.SelectedTab.Text)
            {
                case "Работа с файлами":
                    _clientPresenterFile?.Dispose();
                    _clientPresenterFile = new ClientPresenterFile(_client, new FileModel(_logger));
                    break;
                case "Анализаторы":
                    _analyzerModel?.Dispose();
                    _analyzerModel = new ClientPresenterAnalyzer(_client, new AnalyzerModel(_logger));
                    break;
                case "Низкий уровень":
                    _lowLevelModel?.Dispose();
                    _lowLevelModel = new ClientPresenterLowLevel();
                    break;
            }
        }


        #region Analyzer

        #endregion

    }
}
