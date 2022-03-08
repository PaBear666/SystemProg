using System.Windows.Forms;
using App.Controllers;
using App.Controllers.Abstractions;
using System;
using DAL.Entities;
using System.Collections.Generic;

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
            _fileController = new FileController();
            _fileController.UpdateResourceHandler += UpdateTable;
            _lowLevelContoller = new LowLevelContoller();
            _analyzerController = new AnalyzerController();
        }

        #region Records methods

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            _fileController.AddRecord();
        }

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            
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
            var comboBox = sender as ComboBox;
            var fileProvderStr = comboBox.SelectedItem as string;
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
            var comboBox = sender as ComboBox;
            comboBox.SelectedIndexChanged -= EnableBtnWorkWithFile_SelectedIndexChanged;
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

        }

        #endregion

    }
}
