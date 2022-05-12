using App.ActionModals;
using BLL.Entities;
using System;
using System.Windows.Forms;

namespace App.Presenters
{
    class ActionModalPresenterDllRecord : IActionModalPresenter<DllRecord>
    {
        DllRecord _record;
        readonly IViewActionDll _modal;
        public ActionModalPresenterDllRecord(ModalAction action, DllRecord record)
        {
            _modal = new ActionDllRecord();
            _record = record;
            Init();
            Execute(action, record);
        }

        private void Execute(ModalAction action, DllRecord record)
        {
            switch (action)
            {
                case ModalAction.Add:
                    InitFields(String.Empty, String.Empty, DateTime.Now);
                    break;
                case ModalAction.Update:
                    InitFields(record.Name, record.Version, record.LastEditDate);
                    break;
            }
        }

        private void InitFields(string name, string version, DateTime lastEditDate)
        {
            _modal.TextBox1.Text = name;

            _modal.TextBox2.Text = version;

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
                && !string.IsNullOrWhiteSpace(_modal.TextBox2.Text);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _modal.DialogResult = DialogResult.Cancel;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            _record = new DllRecord(
               _modal.TextBox1.Text,
               _modal.TextBox2.Text,
               _modal.DateTimePicker1.Value);
            _modal.DialogResult = DialogResult.OK;
        }

        public void ShowDialog(Action<DllRecord> ok, Action cancel = null)
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
