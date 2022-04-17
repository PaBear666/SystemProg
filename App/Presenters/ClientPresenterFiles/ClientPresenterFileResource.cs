using App.Controllers.Abstractions;
using App.Entities;
using App.Infrastructure;
using App.Providers;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Presenters
{
    public class ClientPresenterFileResource : ClientPresenterFile<Resource>
    {
        public ClientPresenterFileResource(
            Client client,
            IFileModel<Resource> fileModel,
            IRepository<Resource> repository) : 
            base(client,
                fileModel,
                (m,r) => new ActionModalPresenterResource(m,r),
                client.dataGrid,
                repository)
        {

        }

        public override void SetFileProvider()
        {
            _fileExtension = _fileModel.SetFileProvider(new CSVProvider());
            _client.fileTypeCB.SelectedIndex = 0;
        }

        public override void UpdateTable(object sender, IList<Resource> resources)
        {
            _client.dataGrid.Rows.Clear();
            for (int i = 0; i < resources.Count; i++)
            {
                _dataGrid.Rows.Add();
                _dataGrid.Rows[i].Cells[0].Value = resources[i].Id;
                _dataGrid.Rows[i].Cells[1].Value = resources[i].Address;
                _dataGrid.Rows[i].Cells[2].Value = resources[i].IsOpen;
                _dataGrid.Rows[i].Cells[3].Value = resources[i].AccessDate;
            }
        }
    }
}
