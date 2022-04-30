using App.Entities;
using System;
using System.Windows.Forms;

namespace App.Presenters
{
    class ActionModalPresenterDllRecord : IActionModalPresenter<DllRecord>
    {
        DllRecord _record;
        readonly ActionDllRecord _modal;
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
            _modal.textBox1.Text = name;

            _modal.textBox2.Text = version;

            _modal.dateTimePicker1.Value = lastEditDate;
        }

        private void Init()
        {
            _modal.okBtn.Click += new System.EventHandler(this.OKBtn_Click);
            _modal.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            _modal.textBox1.TextChanged += new System.EventHandler(this.OKBtnEnableEvent);
            _modal.textBox2.TextChanged += new System.EventHandler(this.OKBtnEnableEvent);
        }

        private void OKBtnEnableEvent(object sender, EventArgs e)
        {
            _modal.okBtn.Enabled = !string.IsNullOrWhiteSpace(_modal.textBox1.Text)
                && !string.IsNullOrWhiteSpace(_modal.textBox2.Text)
                && !string.IsNullOrWhiteSpace(_modal.textBox2.Text);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _modal.DialogResult = DialogResult.Cancel;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            _record = new DllRecord(
               _modal.textBox1.Text,
               _modal.textBox2.Text,
               _modal.dateTimePicker1.Value);
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
