
using System.Windows.Forms;

namespace App
{
    partial class ApplicationUI : IView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.UnloadFileBtn = new System.Windows.Forms.Button();
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.UpdateRecordBtn = new System.Windows.Forms.Button();
            this.AddRecordBtn = new System.Windows.Forms.Button();
            this.DeleteRecordBtn = new System.Windows.Forms.Button();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DllRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.DataGrid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.DataGrid3 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.DoWhileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.IfTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.InputVS = new System.Windows.Forms.RichTextBox();
            this.OutputVS = new System.Windows.Forms.RichTextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Logtext = new System.Windows.Forms.RichTextBox();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).BeginInit();
            this.TabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid3)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.TabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(12, 2);
            this.TabControl1.Name = "tabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(806, 487);
            this.TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.TabPage1.Controls.Add(this.TextBox4);
            this.TabPage1.Controls.Add(this.UnloadFileBtn);
            this.TabPage1.Controls.Add(this.LoadFileBtn);
            this.TabPage1.Controls.Add(this.UpdateRecordBtn);
            this.TabPage1.Controls.Add(this.AddRecordBtn);
            this.TabPage1.Controls.Add(this.DeleteRecordBtn);
            this.TabPage1.Controls.Add(this.TabControl2);
            this.TabPage1.Controls.Add(this.ComboBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "tabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(798, 461);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Работа с Файлами";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(672, 51);
            this.TextBox4.Name = "textBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(100, 20);
            this.TextBox4.TabIndex = 11;
            // 
            // unloadFileBtn
            // 
            this.UnloadFileBtn.Location = new System.Drawing.Point(672, 128);
            this.UnloadFileBtn.Name = "unloadFileBtn";
            this.UnloadFileBtn.Size = new System.Drawing.Size(103, 23);
            this.UnloadFileBtn.TabIndex = 4;
            this.UnloadFileBtn.Text = "Открыть";
            this.UnloadFileBtn.UseVisualStyleBackColor = true;
            // 
            // loadFileBtn
            // 
            this.LoadFileBtn.Location = new System.Drawing.Point(672, 87);
            this.LoadFileBtn.Name = "loadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(103, 23);
            this.LoadFileBtn.TabIndex = 3;
            this.LoadFileBtn.Text = "Сохранить";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            // 
            // updateRecordBtn
            // 
            this.UpdateRecordBtn.Enabled = false;
            this.UpdateRecordBtn.Location = new System.Drawing.Point(35, 145);
            this.UpdateRecordBtn.Name = "updateRecordBtn";
            this.UpdateRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.UpdateRecordBtn.TabIndex = 7;
            this.UpdateRecordBtn.Text = "Редактировать";
            this.UpdateRecordBtn.UseVisualStyleBackColor = true;
            // 
            // addRecordBtn
            // 
            this.AddRecordBtn.Location = new System.Drawing.Point(35, 87);
            this.AddRecordBtn.Name = "addRecordBtn";
            this.AddRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.AddRecordBtn.TabIndex = 5;
            this.AddRecordBtn.Text = "Добавить";
            this.AddRecordBtn.UseVisualStyleBackColor = true;
            // 
            // deleteRecordBtn
            // 
            this.DeleteRecordBtn.Enabled = false;
            this.DeleteRecordBtn.Location = new System.Drawing.Point(35, 116);
            this.DeleteRecordBtn.Name = "deleteRecordBtn";
            this.DeleteRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.DeleteRecordBtn.TabIndex = 6;
            this.DeleteRecordBtn.Text = "Удалить";
            this.DeleteRecordBtn.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage4);
            this.TabControl2.Controls.Add(this.TabPage5);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Location = new System.Drawing.Point(178, 29);
            this.TabControl2.Name = "tabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(459, 315);
            this.TabControl2.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.TabPage4.Controls.Add(this.DataGrid);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "tabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(451, 289);
            this.TabPage4.TabIndex = 0;
            this.TabPage4.Text = "Записи о ресурсах";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Address,
            this.IsOpen,
            this.DllRecordDate});
            this.DataGrid.Location = new System.Drawing.Point(5, 0);
            this.DataGrid.Name = "dataGrid";
            this.DataGrid.Size = new System.Drawing.Size(443, 277);
            this.DataGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // IsOpen
            // 
            this.IsOpen.HeaderText = "IsOpen";
            this.IsOpen.Name = "IsOpen";
            this.IsOpen.ReadOnly = true;
            // 
            // DllRecordDate
            // 
            this.DllRecordDate.HeaderText = "AccessDate";
            this.DllRecordDate.Name = "DllRecordDate";
            this.DllRecordDate.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.TabPage5.Controls.Add(this.DataGrid2);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "tabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(451, 289);
            this.TabPage5.TabIndex = 1;
            this.TabPage5.Text = "Записи о файлах";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGrid2
            // 
            this.DataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Path,
            this.Column1,
            this.Column2});
            this.DataGrid2.Location = new System.Drawing.Point(9, 7);
            this.DataGrid2.Name = "dataGrid2";
            this.DataGrid2.Size = new System.Drawing.Size(779, 286);
            this.DataGrid2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Size";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LastEditDate";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tabPage7
            // 
            this.TabPage7.Controls.Add(this.DataGrid3);
            this.TabPage7.Location = new System.Drawing.Point(4, 22);
            this.TabPage7.Name = "tabPage7";
            this.TabPage7.Size = new System.Drawing.Size(451, 289);
            this.TabPage7.TabIndex = 2;
            this.TabPage7.Text = "Записи о dll";
            this.TabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGrid3
            // 
            this.DataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGrid3.Location = new System.Drawing.Point(3, 3);
            this.DataGrid3.Name = "dataGrid3";
            this.DataGrid3.Size = new System.Drawing.Size(769, 317);
            this.DataGrid3.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Version";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "LastEditDate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "БД",
            "ОЗУ"});
            this.ComboBox1.Location = new System.Drawing.Point(44, 18);
            this.ComboBox1.Name = "comboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(109, 21);
            this.ComboBox1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.TabPage2.Controls.Add(this.label2);
            this.TabPage2.Controls.Add(this.TabControl3);
            this.TabPage2.Controls.Add(this.Button1);
            this.TabPage2.Controls.Add(this.InputVS);
            this.TabPage2.Controls.Add(this.OutputVS);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "tabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(798, 461);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Работа с анализатором";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Информация";
            // 
            // tabControl3
            // 
            this.TabControl3.Controls.Add(this.tabPage8);
            this.TabControl3.Controls.Add(this.tabPage10);
            this.TabControl3.Location = new System.Drawing.Point(37, 322);
            this.TabControl3.Name = "tabControl3";
            this.TabControl3.SelectedIndex = 0;
            this.TabControl3.Size = new System.Drawing.Size(743, 132);
            this.TabControl3.TabIndex = 6;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.DoWhileTextBox);
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(735, 106);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "do while";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // doWhileTextBox
            // 
            this.DoWhileTextBox.Location = new System.Drawing.Point(319, 52);
            this.DoWhileTextBox.Name = "doWhileTextBox";
            this.DoWhileTextBox.ReadOnly = true;
            this.DoWhileTextBox.Size = new System.Drawing.Size(100, 20);
            this.DoWhileTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выполнится больше одного раза:";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.IfTextBox);
            this.tabPage10.Controls.Add(this.label4);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(735, 106);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "if";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // ifTextBox
            // 
            this.IfTextBox.Location = new System.Drawing.Point(297, 46);
            this.IfTextBox.Name = "ifTextBox";
            this.IfTextBox.ReadOnly = true;
            this.IfTextBox.Size = new System.Drawing.Size(100, 20);
            this.IfTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выполнилось:";
            // 
            // button1
            // 
            this.Button1.Location = new System.Drawing.Point(456, 28);
            this.Button1.Name = "button1";
            this.Button1.Size = new System.Drawing.Size(269, 49);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Run";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // inputVS
            // 
            this.InputVS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputVS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InputVS.Location = new System.Drawing.Point(37, 174);
            this.InputVS.Name = "inputVS";
            this.InputVS.Size = new System.Drawing.Size(743, 142);
            this.InputVS.TabIndex = 0;
            this.InputVS.Text = "";
            // 
            // outputVS
            // 
            this.OutputVS.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputVS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OutputVS.Location = new System.Drawing.Point(37, 28);
            this.OutputVS.Name = "outputVS";
            this.OutputVS.ReadOnly = true;
            this.OutputVS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutputVS.Size = new System.Drawing.Size(353, 140);
            this.OutputVS.TabIndex = 1;
            this.OutputVS.Text = "";
            // 
            // tabPage3
            // 
            this.TabPage3.Controls.Add(this.label6);
            this.TabPage3.Controls.Add(this.label5);
            this.TabPage3.Controls.Add(this.label1);
            this.TabPage3.Controls.Add(this.TextBox3);
            this.TabPage3.Controls.Add(this.TextBox2);
            this.TabPage3.Controls.Add(this.TextBox1);
            this.TabPage3.Controls.Add(this.Button4);
            this.TabPage3.Controls.Add(this.Button3);
            this.TabPage3.Controls.Add(this.Button2);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "tabPage3";
            this.TabPage3.Size = new System.Drawing.Size(798, 461);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Работа с низким уровнем";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Результат операнд";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Второй операнд";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Первый операнд";
            // 
            // textBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(427, 254);
            this.TextBox3.Name = "textBox3";
            this.TextBox3.Size = new System.Drawing.Size(276, 20);
            this.TextBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(427, 101);
            this.TextBox2.Name = "textBox2";
            this.TextBox2.Size = new System.Drawing.Size(276, 20);
            this.TextBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(427, 50);
            this.TextBox1.Name = "textBox1";
            this.TextBox1.Size = new System.Drawing.Size(276, 20);
            this.TextBox1.TabIndex = 3;
            // 
            // button4
            // 
            this.Button4.Location = new System.Drawing.Point(26, 226);
            this.Button4.Name = "button4";
            this.Button4.Size = new System.Drawing.Size(286, 74);
            this.Button4.TabIndex = 2;
            this.Button4.Text = "Побитовое И";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.Button3.Location = new System.Drawing.Point(26, 123);
            this.Button3.Name = "button3";
            this.Button3.Size = new System.Drawing.Size(286, 74);
            this.Button3.TabIndex = 1;
            this.Button3.Text = "Сравнить";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.Button2.Location = new System.Drawing.Point(26, 22);
            this.Button2.Name = "button2";
            this.Button2.Size = new System.Drawing.Size(286, 74);
            this.Button2.TabIndex = 0;
            this.Button2.Text = "Целочисленное деление";
            this.Button2.UseVisualStyleBackColor = true;
            // 
            // logtext
            // 
            this.Logtext.BackColor = System.Drawing.SystemColors.InfoText;
            this.Logtext.ForeColor = System.Drawing.SystemColors.Info;
            this.Logtext.Location = new System.Drawing.Point(16, 491);
            this.Logtext.Name = "logtext";
            this.Logtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Logtext.Size = new System.Drawing.Size(798, 138);
            this.Logtext.TabIndex = 2;
            this.Logtext.Text = "";
            // 
            // ApplicationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 641);
            this.Controls.Add(this.Logtext);
            this.Controls.Add(this.TabControl1);
            this.Name = "ApplicationUI";
            this.Text = "Form1";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.TabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).EndInit();
            this.TabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid3)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button unloadFileBtn;
        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Button updateRecordBtn;
        private System.Windows.Forms.Button deleteRecordBtn;
        private System.Windows.Forms.RichTextBox outputVS;
        private System.Windows.Forms.RichTextBox inputVS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGrid3;
        private System.Windows.Forms.RichTextBox logtext;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TextBox doWhileTextBox;
        private System.Windows.Forms.TextBox ifTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DllRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

        public TabControl TabControl1 { get => tabControl1; set => tabControl1 = value; }
        public TabPage TabPage1 { get => tabPage1; set => tabPage1 = value; }
        public TabPage TabPage2 { get => tabPage2; set => tabPage2 = value; }
        public TabPage TabPage3 { get => tabPage3; set => tabPage3 = value; }
        public DataGridView DataGrid { get => dataGrid; set => dataGrid = value; }
        public Button LoadFileBtn { get => loadFileBtn; set => loadFileBtn = value; }
        public Button UnloadFileBtn { get => unloadFileBtn; set => unloadFileBtn = value; }
        public Button AddRecordBtn { get => addRecordBtn; set => addRecordBtn = value; }
        public Button UpdateRecordBtn { get => updateRecordBtn; set => updateRecordBtn = value; }
        public Button DeleteRecordBtn { get => deleteRecordBtn; set => deleteRecordBtn = value; }
        public RichTextBox OutputVS { get => outputVS; set => outputVS = value; }
        public RichTextBox InputVS { get => inputVS; set => inputVS = value; }
        public Button Button1 { get => button1; set => button1 = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public TabControl TabControl2 { get => tabControl2; set => tabControl2 = value; }
        public TabPage TabPage4 { get => tabPage4; set => tabPage4 = value; }
        public TabPage TabPage5 { get => tabPage5; set => tabPage5 = value; }
        public TabPage TabPage7 { get => tabPage7; set => tabPage7 = value; }
        public DataGridView DataGrid3 { get => dataGrid3; set => dataGrid3 = value; }
        public RichTextBox Logtext { get => logtext; set => logtext = value; }
        public DataGridView DataGrid2 { get => dataGrid2; set => dataGrid2 = value; }
        public TabControl TabControl3 { get => tabControl3; set => tabControl3 = value; }
        public TextBox DoWhileTextBox { get => doWhileTextBox; set => doWhileTextBox = value; }
        public TextBox IfTextBox { get => ifTextBox; set => ifTextBox = value; }
        public TextBox TextBox3 { get => textBox3; set => textBox3 = value; }
        public TextBox TextBox2 { get => textBox2; set => textBox2 = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public Button Button4 { get => button4; set => button4 = value; }
        public Button Button3 { get => button3; set => button3 = value; }
        public Button Button2 { get => button2; set => button2 = value; }
        public TextBox TextBox4 { get => textBox4; set => textBox4 = value; }
    }
}

