 using App.Models.Abstractions;
using BLL.Entities;
using BLL.Providers;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Presenters
{
    public class ClientPresenterFileResource : ClientPresenterFile<Resource>
    {
        public ClientPresenterFileResource(
            IView client,
            IFileModel<Resource> fileModel,
            IRepository<Resource> repository) : 
            base(client,
                fileModel,
                (m,r) => new ActionModalPresenterResource(m,r),
                client.DataGrid,
                repository)
        {

        }

        public override void SetFileProvider()
        {
            _fileExtension = _fileModel.SetFileProvider(new PlainTextProvider());
            _client.TextBox4.Text = "Plain Text";
        }

        public override void UpdateTable(object sender, IList<Resource> resources)
        {
            _dataGrid.Rows.Clear();
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
