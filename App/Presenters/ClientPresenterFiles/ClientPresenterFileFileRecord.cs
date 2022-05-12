using App.Models;
using BLL.Entities;
using BLL.Providers;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    class ClientPresenterFileFileRecord : ClientPresenterFile<FileRecord>
    {

        public ClientPresenterFileFileRecord(IView client, FileModel<FileRecord> fileModel, IRepository<FileRecord> repository) :
            base(client,
                fileModel,
                (m, r) => new ActionModalPresenterFileRecord(m, r),
                client.DataGrid2,
                repository)
        {

        }

        public override void SetFileProvider()
        {
            _fileExtension = _fileModel.SetFileProvider(new CSVProvider());
            _client.TextBox4.Text = "CSV";
        }

        public override void UpdateTable(object sender, IList<FileRecord> resources)
        {
            _dataGrid.Rows.Clear();
            for (int i = 0; i < resources.Count; i++)
            {
                _dataGrid.Rows.Add();
                _dataGrid.Rows[i].Cells[0].Value = resources[i].Id;
                _dataGrid.Rows[i].Cells[1].Value = resources[i].Path;
                _dataGrid.Rows[i].Cells[2].Value = resources[i].Size;
                _dataGrid.Rows[i].Cells[3].Value = resources[i].LastEditDate;
            }
        }
    }
}
