using System.Windows.Forms;

namespace App
{
    public interface IView
    {
        TabControl TabControl1 { get; set; }
        TabPage TabPage1 { get; set; }
        TabPage TabPage2 { get; set; }
        TabPage TabPage3 { get; set; }
        DataGridView DataGrid { get; set; }
        Button LoadFileBtn { get; set; }
        Button UnloadFileBtn { get; set; }
        Button AddRecordBtn { get; set; }
        Button UpdateRecordBtn { get; set; }
        Button DeleteRecordBtn { get; set; }
        RichTextBox OutputVS { get; set; }
        RichTextBox InputVS { get; set; }
        Button Button1 { get; set; }
        ComboBox ComboBox1 { get; set; }
        TabControl TabControl2 { get; set; }
        TabPage TabPage4 { get; set; }
        TabPage TabPage5 { get; set; }
        TabPage TabPage7 { get; set; }
        DataGridView DataGrid3 { get; set; }
        RichTextBox Logtext { get; set; }
        DataGridView DataGrid2 { get; set; }
        TabControl TabControl3 { get; set; }
        TextBox DoWhileTextBox { get; set; }
        TextBox IfTextBox { get; set; }
        TextBox TextBox3 { get; set; }
        TextBox TextBox2 { get; set; }
        TextBox TextBox1 { get; set; }
        Button Button4 { get; set; }
        Button Button3 { get; set; }
        Button Button2 { get; set; }
        TextBox TextBox4 { get; set; }
    }
}