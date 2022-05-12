using System.Windows.Forms;

namespace App.ActionModals
{
    interface IViewAction
    {
        Button OkBtn { get; set; }
        Button CancelBtn { get; set; }
        DialogResult DialogResult { get; set; }
        DialogResult ShowDialog();
        void Close();
    }
}
