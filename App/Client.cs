using System.Windows.Forms;
using App.Controllers;
using App.Controllers.Abstractions;
using System;
using DAL.Entities;

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
            _lowLevelContoller = new LowLevelContoller();
            _analyzerController = new AnalyzerController();
        }

        #region A/D/U Records

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Work with File



        #endregion

    }
}
