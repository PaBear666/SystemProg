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



        #endregion

    }
}
