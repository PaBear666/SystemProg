using System.Windows.Forms;

namespace App.ActionModals
{
    interface IViewActionDll : IViewAction
    {
         DateTimePicker DateTimePicker1 { get; set; }
         TextBox TextBox2 { get; set; }
         TextBox TextBox1 { get; set; }
    }
}
