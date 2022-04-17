using App.Controllers.Abstractions;
using App.Infrastructure;
using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.Presenters
{
    abstract public class ClientPresenterFile<T> : ClientPresenterFile
        where T : class, IEntity
    {
        protected IFileModel<T> _fileModel;
        protected string _fileExtension;
        protected readonly Client _client;
        protected DataGridView _dataGrid;
        protected Func<ModalAction,T,IActionModalPresenter<T>> _actionModal;

        public ClientPresenterFile(
            Client client,
            IFileModel<T> fileModel,
            Func<ModalAction, T, IActionModalPresenter<T>> actionModal,
            DataGridView dataGrid,
            IRepository<T> repository)
        {
            _fileModel = fileModel;
            _client = client;
            _actionModal = actionModal;
            _dataGrid = dataGrid;
            Init();
            _fileModel.SetRepository(repository);
            SetFileProvider();
        }

        public void Init()
        {
            _client.fileTypeCB.SelectedIndexChanged += new EventHandler(EnableBtnWorkWithFile_SelectedIndexChanged);
            _client.loadFileBtn.Click += new EventHandler(UnloadFileBtn_Click);
            _client.unloadFileBtn.Click += new EventHandler(LoadFileBtn_Click);
            _client.addRecordBtn.Click += new EventHandler(AddRecordBtn_Click);
            _client.updateRecordBtn.Click += new EventHandler(UpdateRecordBtn_Click);
            _client.deleteRecordBtn.Click += new EventHandler(DeleteRecordBtn_Click);
            _dataGrid.SelectionChanged += new EventHandler(SelectedRowEvent);
            _client.comboBox1.SelectedValueChanged += RepositoryType_SelectedIndexChanged;
            _fileModel.UpdateResourceHandler += UpdateTable;
            _client.comboBox1.SelectedItem = "ОЗУ";
        }

        public void AddRecordBtn_Click(object sender, EventArgs e)
        {
            var modal = _actionModal(ModalAction.Add, null);
            modal.ShowDialog(r => _fileModel.AddRecord(r));
        }

        abstract public void SetFileProvider();
        public void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            var value = _dataGrid.SelectedRows[0].Cells[0].Value;
            if (value != null)
            {
                _fileModel.RemoveRecord((int)value);
            }
        }

        public void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            var value = _dataGrid.SelectedRows[0].Cells[0].Value;
            if (value != null)
            {
                var id = (int)value;
                var resource = _fileModel.GetById(id);
                var modal = _actionModal(ModalAction.Update,resource);
                modal.ShowDialog(r => _fileModel.UpdateRecord(id, r));
            }
        }

        public void RepositoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileProvderStr = _client.comboBox1.SelectedItem as string;
            switch (fileProvderStr)
            {
                case "ОЗУ":
                    _fileModel.SetRepository(new FileRepository<T>());
                    break;
                case "БД":
                    _fileModel.SetRepository(new DbRepository<T>(() => new Context("Server=(localdb)\\mssqllocaldb;Database=systemProg;Trusted_Connection=True;")));
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
            var selectedOne = _dataGrid.SelectedRows.Count == 1;
            _client.deleteRecordBtn.Enabled = selectedOne;
            _client.updateRecordBtn.Enabled = selectedOne;
        }

        abstract public void UpdateTable(object sender, IList<T> resources);

        public void EnableBtnWorkWithFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            _client.fileTypeCB.SelectedIndexChanged -= EnableBtnWorkWithFile_SelectedIndexChanged;
            _client.loadFileBtn.Enabled = true;
            _client.unloadFileBtn.Enabled = true;
        }

        public override void Dispose()
        {
            _client.fileTypeCB.SelectedIndexChanged -= new EventHandler(EnableBtnWorkWithFile_SelectedIndexChanged);
            _client.loadFileBtn.Click -= new EventHandler(UnloadFileBtn_Click);
            _client.unloadFileBtn.Click -= new EventHandler(LoadFileBtn_Click);
            _client.addRecordBtn.Click -= new EventHandler(AddRecordBtn_Click);
            _client.updateRecordBtn.Click -= new EventHandler(UpdateRecordBtn_Click);
            _client.deleteRecordBtn.Click -= new EventHandler(DeleteRecordBtn_Click);
            _dataGrid.SelectionChanged -= new EventHandler(SelectedRowEvent);
            _client.comboBox1.SelectedValueChanged -= RepositoryType_SelectedIndexChanged;
            _client.comboBox1.SelectedIndexChanged -= new EventHandler(RepositoryType_SelectedIndexChanged);
            _fileModel.UpdateResourceHandler -= UpdateTable;
        }
    }


    public abstract class ClientPresenterFile : IDisposable
    {
        abstract public void Dispose();
    }
}
