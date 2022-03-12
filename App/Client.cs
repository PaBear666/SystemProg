using System.Windows.Forms;
using App.Controllers;
using App.Controllers.Abstractions;
using System;
using DAL.Entities;
using System.Collections.Generic;
using App.Infrastructure;
using DAL.Providers;

namespace App
{
    public partial class Client : Form
    {
        private readonly IFileController _fileController;
        private readonly ILowLevelController _lowLevelContoller;
        private readonly IAnalyzerController _analyzerController;
        private string _fileExtension;
        public Client()
        {         
            InitializeComponent();
            ILogger logger = new Logger();
            fileTypeCB.SelectedIndexChanged += FileTypeCB_SelectedIndexChanged;
            _fileController = new FileController(logger);
            _fileController.UpdateResourceHandler += UpdateTable;
            _lowLevelContoller = new LowLevelContoller();
            _analyzerController = new AnalyzerController(logger);
        }

        #region Records methods

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            var modal = new ActionModal(ModalAction.Add, null);
            modal.ShowDialog(r => _fileController.AddRecord(r));
        }

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            var value = dataGrid.SelectedRows[0].Cells[0].Value;
            if(value != null)
            {
                _fileController.RemoveRecord((int)value);
            }
        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            var value = dataGrid.SelectedRows[0].Cells[0].Value;
            if (value != null)
            {
                var id = (int)value;
                var resource = _fileController.GetById(id);
                var modal = new ActionModal(ModalAction.Update, resource);
                modal.ShowDialog(r => _fileController.UpdateRecord(id, r));
            }          
        }

        private void SelectedRowEvent(object sender, EventArgs e)
        {
            var selectedOne = dataGrid.SelectedRows.Count == 1;
            deleteRecordBtn.Enabled = selectedOne;
            updateRecordBtn.Enabled = selectedOne;
        }

        private void UpdateTable(object sender, IList<Resource> resources)
        {
            dataGrid.Rows.Clear();
            for (int i = 0; i < resources.Count; i++)
            {
                dataGrid.Rows.Add();
                var resource = resources[i];
                dataGrid.Rows[i].Cells[0].Value = resource.Id;
                dataGrid.Rows[i].Cells[1].Value = resource.Address;
                dataGrid.Rows[i].Cells[2].Value = resource.IsOpen;
                dataGrid.Rows[i].Cells[3].Value = resource.AccessDate;
            }
        }

        #endregion

        #region Work with File

        private void FileTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileProvderStr = fileTypeCB.SelectedItem as string;
            switch (fileProvderStr)
            {
                case "Plain Text":
                    _fileExtension = _fileController.SetFileProvider(new PlainTextProvider());
                    break;
                case "CSV":
                    _fileExtension = _fileController.SetFileProvider(new CSVProvider());
                    break;
            }
        }

        private void EnableBtnWorkWithFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileTypeCB.SelectedIndexChanged -= EnableBtnWorkWithFile_SelectedIndexChanged;
            loadFileBtn.Enabled = true;
            unloadFileBtn.Enabled = true;
        }
        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = $"All files of type|*.{_fileExtension}";
                dialog.FilterIndex = 1;

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    _fileController.LoadFromFile(dialog.FileName);
                }
            }
        }

        private void UnloadFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = $"All files of type|*.{_fileExtension}";
                dialog.FilterIndex = 1;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _fileController.UnloadToFile(dialog.FileName);
                }
            }
        }

        #endregion

        private void InputVS_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBoxBase;
            var result = _analyzerController.Execute(textBox.Text);
            if (!result.Compiled)
            {
                outputVS.Text = "Не скомпилировано";
                outputVS.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                outputVS.Text = "Cкомпилировано";
                outputVS.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
