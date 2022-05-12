using App.ActionModals;
using App.Presenters;
using BLL.Entities;
using System;
using System.Windows.Forms;

namespace App.Presenters
{
    class ActionModalPresenterResource : IActionModalPresenter<Resource>
    {
        private Resource _record;
        private IViewActionResource _actionModal;
        public ActionModalPresenterResource(ModalAction action, Resource record)
        {
            _actionModal = new ActionResource();
            _record = record;
            Init();
            Execute(action, record);
        }

        private void Init()
        {
            _actionModal.OkBtn.Click += new System.EventHandler(this.OKBtn_Click);
            _actionModal.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            _actionModal.TextBox1.TextChanged += new System.EventHandler(this.OKBtnEnableEvent);

        }

        public void ShowDialog(Action<Resource> ok, Action cancel = null)
        {
            _actionModal.ShowDialog();
            switch (_actionModal.DialogResult)
            {
                case DialogResult.OK:
                    ok(_record);
                    break;

                case DialogResult.Cancel:
                    cancel?.Invoke();
                    break;
            }
            _actionModal.Close();
        }

        private void Execute(ModalAction action, Resource record)
        {
            switch (action)
            {
                case ModalAction.Add:
                    InitFields(String.Empty, null, DateTime.Now);
                    break;
                case ModalAction.Update:
                    InitFields(record.Address, record.IsOpen, record.AccessDate);
                    break;
            }
        }

        private void InitFields(string address, bool? isOpen, DateTime accessDate)
        {
            _actionModal.TextBox1.Text = address;

            if (isOpen != null)
            {
                _actionModal.ComboBox1.SelectedIndex = isOpen.Value ? 0 : 1;
            }
            else
            {
                _actionModal.ComboBox1.SelectedIndex = -1;
            }

            _actionModal.DateTimePicker1.Value = accessDate;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            _record = new Resource(
                _actionModal.TextBox1.Text,
                _actionModal.ComboBox1.SelectedIndex == 0,
                _actionModal.DateTimePicker1.Value);
            _actionModal.DialogResult = DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _actionModal.DialogResult = DialogResult.Cancel;
        }

        private void OKBtnEnableEvent(object sender, EventArgs e)
        {
            _actionModal.OkBtn.Enabled = !string.IsNullOrWhiteSpace(_actionModal.TextBox1.Text);
        }
    }
}
