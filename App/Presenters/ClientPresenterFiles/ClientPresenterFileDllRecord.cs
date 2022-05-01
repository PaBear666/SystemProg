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
    class ClientPresenterFileDllRecord : ClientPresenterFile<DllRecord>
    {

        public ClientPresenterFileDllRecord(ApplicationUI client, FileModel<DllRecord> fileModel, IRepository<DllRecord> repository)
            :base(client,
                fileModel,
                (m, r) => new ActionModalPresenterDllRecord(m, r),
                client.dataGrid3,
                repository)
        {

        }

        public override void SetFileProvider()
        {
            _fileExtension = _fileModel.SetFileProvider(new PlainTextProvider());
            _client.textBox4.Text = "Plain Text";
        }

        public override void UpdateTable(object sender, IList<DllRecord> resources)
        {
            _dataGrid.Rows.Clear();
            for (int i = 0; i < resources.Count; i++)
            {
                _dataGrid.Rows.Add();
                _dataGrid.Rows[i].Cells[0].Value = resources[i].Id;
                _dataGrid.Rows[i].Cells[1].Value = resources[i].Name;
                _dataGrid.Rows[i].Cells[2].Value = resources[i].Version;
                _dataGrid.Rows[i].Cells[3].Value = resources[i].LastEditDate;
            }
        }
    }
}
