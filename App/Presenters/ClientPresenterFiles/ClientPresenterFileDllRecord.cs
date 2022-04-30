﻿using App.Controllers;
using App.Controllers.Abstractions;
using App.Entities;
using App.Infrastructure;
using App.Providers;
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

        public ClientPresenterFileDllRecord(Client client, FileModel<DllRecord> fileModel, IRepository<DllRecord> repository)
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
            _client.fileTypeCB.SelectedIndex = 1;
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