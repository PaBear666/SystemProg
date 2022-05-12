using System.Windows.Forms;

namespace App.ActionModals
{
    interface IViewActionResource : IViewAction
    {
        TextBox TextBox1 { get; set; }
        ComboBox ComboBox1 { get; set; }
        DateTimePicker DateTimePicker1 { get; set; }
    }
}
