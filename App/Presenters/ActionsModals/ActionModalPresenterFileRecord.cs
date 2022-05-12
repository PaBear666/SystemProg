using App.ActionModals;
using BLL.Entities;
using System;
using System.Windows.Forms;

namespace App.Presenters
{
    class ActionModalPresenterFileRecord : IActionModalPresenter<FileRecord>
    {
        FileRecord _record;
        readonly IViewActionFile _modal;
        public ActionModalPresenterFileRecord(ModalAction action, FileRecord record)
        {
            _modal = new ActionFileRecord();
            _record = record;
            Init();
            Execute(action, record);
        }

        private void Execute(ModalAction action, FileRecord record)
        {
            switch (action)
            {
                case ModalAction.Add:
                    InitFields(String.Empty, 0, DateTime.Now);
                    break;
                case ModalAction.Update:
                    InitFields(record.Path, record.Size, record.LastEditDate);
                    break;
            }
        }

        private void InitFields(string path, int size, DateTime lastEditDate)
        {
            _modal.TextBox1.Text = path;

            _modal.TextBox2.Text = size.ToString();

            _modal.DateTimePicker1.Value = lastEditDate;
        }

        private void Init()
        {
            _modal.OkBtn.Click += new System.EventHandler(this.OKBtn_Click);
            _modal.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            _modal.TextBox1.TextChanged += new System.EventHandler(this.OKBtnEnableEvent);
            _modal.TextBox2.TextChanged += new System.EventHandler(this.OKBtnEnableEvent);
        }

        private void OKBtnEnableEvent(object sender, EventArgs e)
        {
            _modal.OkBtn.Enabled = !string.IsNullOrWhiteSpace(_modal.TextBox1.Text)
                && !string.IsNullOrWhiteSpace(_modal.TextBox2.Text)
                && int.TryParse(_modal.TextBox2.Text, out int result)
                && result > 0;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _modal.DialogResult = DialogResult.Cancel;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            _record = new FileRecord(
               _modal.TextBox1.Text,
               int.Parse(_modal.TextBox2.Text),
               _modal.DateTimePicker1.Value);
            _modal.DialogResult = DialogResult.OK;
        }

        public void ShowDialog(Action<FileRecord> ok, Action cancel = null)
        {
            _modal.ShowDialog();
            switch (_modal.DialogResult)
            {
                case DialogResult.OK:
                    ok(_record);
                    break;

                case DialogResult.Cancel:
                    cancel?.Invoke();
                    break;
            }
            _modal.Close();
        }
    }
}
