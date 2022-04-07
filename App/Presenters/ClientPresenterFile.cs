

using App.Controllers.Abstractions;
using DAL.Providers;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Presenters
{
    class ClientPresenterFile : IDisposable
    {
        readonly Client _client;
        private readonly IFileModel _fileModel;
        private string _fileExtension;

        public ClientPresenterFile(Client client, IFileModel fileModel)
        {
            _fileModel = fileModel;
            _client = client;
            Init();
        }

        public void Init()
        {
            _client.fileTypeCB.SelectedIndexChanged += new EventHandler(EnableBtnWorkWithFile_SelectedIndexChanged);
            _client.loadFileBtn.Click += new EventHandler(UnloadFileBtn_Click);
            _client.unloadFileBtn.Click += new EventHandler(LoadFileBtn_Click);
            _client.addRecordBtn.Click += new EventHandler(AddRecordBtn_Click);
            _client.updateRecordBtn.Click += new EventHandler(UpdateRecordBtn_Click);
            _client.deleteRecordBtn.Click += new EventHandler(DeleteRecordBtn_Click);
            _client.dataGrid.SelectionChanged += new EventHandler(SelectedRowEvent);
            _client.comboBox1.SelectedIndexChanged += new EventHandler(RepositoryType_SelectedIndexChanged);

            _client.fileTypeCB.SelectedIndexChanged += new EventHandler(FileTypeCB_SelectedIndexChanged);
            _fileModel.UpdateResourceHandler += UpdateTable;
            _client.comboBox1.SelectedItem = "ОЗУ";
        }

        public void AddRecordBtn_Click(object sender, EventArgs e)
        {
            var modal = new ActionModalPresenter(ModalAction.Add, null, new ActionModal());
            modal.ShowDialog(r => _fileModel.AddRecord(r.ToResourceEntity()));
        }

        public void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            var value = _client.dataGrid.SelectedRows[0].Cells[0].Value;
            if (value != null)
            {
                _fileModel.RemoveRecord((int)value);
            }
        }

        public void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            var value = _client.dataGrid.SelectedRows[0].Cells[0].Value;
            if (value != null)
            {
                var id = (int)value;
                var resource = _fileModel.GetById(id).ToResource();
                var modal = new ActionModalPresenter(ModalAction.Update, resource, new ActionModal());
                modal.ShowDialog(r => _fileModel.UpdateRecord(id, r.ToResourceEntity()));
            }
        }

        public void FileTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileProvderStr = _client.fileTypeCB.SelectedItem as string;
            switch (fileProvderStr)
            {
                case "Plain Text":
                    _fileExtension = _fileModel.SetFileProvider(new PlainTextProvider());
                    break;
                case "CSV":
                    _fileExtension = _fileModel.SetFileProvider(new CSVProvider());
                    break;
            }
        }

        public void RepositoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileProvderStr = _client.comboBox1.SelectedItem as string;
            switch (fileProvderStr)
            {
                case "ОЗУ":
                    _fileModel.SetRepository(new FileRepository());
                    break;
                case "БД":
                    _fileModel.SetRepository(new DbRepository("Server=(localdb)\\mssqllocaldb;Database=systemProg;Trusted_Connection=True;"));
                    break;
            }
        }

        public void LoadFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = $"All files of type|*.{_fileExtension}";
                dialog.FilterIndex = 1;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _fileModel.LoadFromFile(dialog.FileName);
                }
            }
        }

        public void UnloadFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = $"All files of type|*.{_fileExtension}";
                dialog.FilterIndex = 1;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _fileModel.UnloadToFile(dialog.FileName);
                }
            }
        }



        public void SelectedRowEvent(object sender, EventArgs e)
        {
            var selectedOne = _client.dataGrid.SelectedRows.Count == 1;
            _client.deleteRecordBtn.Enabled = selectedOne;
            _client.updateRecordBtn.Enabled = selectedOne;
        }

        public void UpdateTable(object sender, IList<Resource> resources)
        {
            _client.dataGrid.Rows.Clear();
            for (int i = 0; i < resources.Count; i++)
            {
                _client.dataGrid.Rows.Add();
                var resource = resources[i].ToResourceEntity();
                _client.dataGrid.Rows[i].Cells[0].Value = resource.Id;
                _client.dataGrid.Rows[i].Cells[1].Value = resource.Address;
                _client.dataGrid.Rows[i].Cells[2].Value = resource.IsOpen;
                _client.dataGrid.Rows[i].Cells[3].Value = resource.AccessDate;
            }
        }


        public void EnableBtnWorkWithFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            _client.fileTypeCB.SelectedIndexChanged -= EnableBtnWorkWithFile_SelectedIndexChanged;
            _client.loadFileBtn.Enabled = true;
            _client.unloadFileBtn.Enabled = true;
        }

        public void Dispose()
        {
            _client.fileTypeCB.SelectedIndexChanged -= new EventHandler(EnableBtnWorkWithFile_SelectedIndexChanged);
            _client.loadFileBtn.Click -= new EventHandler(UnloadFileBtn_Click);
            _client.unloadFileBtn.Click -= new EventHandler(LoadFileBtn_Click);
            _client.addRecordBtn.Click -= new EventHandler(AddRecordBtn_Click);
            _client.updateRecordBtn.Click -= new EventHandler(UpdateRecordBtn_Click);
            _client.deleteRecordBtn.Click -= new EventHandler(DeleteRecordBtn_Click);
            _client.dataGrid.SelectionChanged -= new EventHandler(SelectedRowEvent);
            _client.comboBox1.SelectedIndexChanged -= new EventHandler(RepositoryType_SelectedIndexChanged);
            _client.fileTypeCB.SelectedIndexChanged -= new EventHandler(FileTypeCB_SelectedIndexChanged);
            _fileModel.UpdateResourceHandler -= UpdateTable;
        }
    }
}
