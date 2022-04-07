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
            _logger = new Logger();
            _clientPresenterFile = new ClientPresenterFile(_client, new FileModel(_logger));
            _analyzerModel = new ClientPresenterAnalyzer(_client, new AnalyzerModel(_logger));
            _lowLevelModel = new ClientPresenterLowLevel();
            Application.Run(_client);
        }

        #region Analyzer

        #endregion

    }
}
