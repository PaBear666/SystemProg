using System;
using System.Windows.Forms;
using DAL.Entities;

namespace App
{
    public partial class ActionModal : Form
    {
        private Resource _record;

        public ActionModal(FileAction action, Resource record)
        {
            InitializeComponent();
            _record = record;
            Execute(action, record);
        }

        public void ShowDialog(Action<Resource> ok, Action<Resource> cancel)
        {
            ShowDialog();
            switch (DialogResult)
            {
                case DialogResult.OK:
                    ok(_record);
                    break;

                case DialogResult.Cancel:
                    cancel(_record);
                    break;
            }
            Close();
        }

        public Resource GetResult()
        {
            return _record;
        }

        private void Execute(FileAction action, Resource record)
        {
            switch (action)
            {
                case FileAction.Add:
                    InitFields(String.Empty, null, DateTime.Now);
                    break;
                case FileAction.Update:
                    InitFields(record.Address, record.IsOpen, record.AccessDate);
                    break;
            }
        }

        private void InitFields(string address, bool? isOpen, DateTime accessDate)
        {
            textBox1.Text = address;

            if(isOpen != null)
            {
                comboBox1.SelectedIndex = isOpen.Value ? 0 : 1;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }

            dateTimePicker1.Value = accessDate;
        }


        private void OKBtn_Click(object sender, EventArgs e)
        {
            _record = new Resource(
                textBox1.Text,
                comboBox1.SelectedIndex == 0,
                dateTimePicker1.Value);
            DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
