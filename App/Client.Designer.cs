
namespace App
{
    partial class Client
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.unloadFileBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.fileTypeCB = new System.Windows.Forms.ComboBox();
            this.updateRecordBtn = new System.Windows.Forms.Button();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGrid3 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.inputVS = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputVS = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.logtext = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.unloadFileBtn);
            this.tabPage1.Controls.Add(this.loadFileBtn);
            this.tabPage1.Controls.Add(this.fileTypeCB);
            this.tabPage1.Controls.Add(this.updateRecordBtn);
            this.tabPage1.Controls.Add(this.addRecordBtn);
            this.tabPage1.Controls.Add(this.deleteRecordBtn);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с файлами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // unloadFileBtn
            // 
            this.unloadFileBtn.Enabled = false;
            this.unloadFileBtn.Location = new System.Drawing.Point(623, 426);
            this.unloadFileBtn.Name = "unloadFileBtn";
            this.unloadFileBtn.Size = new System.Drawing.Size(129, 23);
            this.unloadFileBtn.TabIndex = 4;
            this.unloadFileBtn.Text = "Открыть";
            this.unloadFileBtn.UseVisualStyleBackColor = true;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Enabled = false;
            this.loadFileBtn.Location = new System.Drawing.Point(623, 397);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(129, 23);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Сохранить";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // fileTypeCB
            // 
            this.fileTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileTypeCB.Enabled = false;
            this.fileTypeCB.FormattingEnabled = true;
            this.fileTypeCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fileTypeCB.Items.AddRange(new object[] {
            "CSV",
            "BINARY",
            "XML"});
            this.fileTypeCB.Location = new System.Drawing.Point(572, 370);
            this.fileTypeCB.Name = "fileTypeCB";
            this.fileTypeCB.Size = new System.Drawing.Size(220, 21);
            this.fileTypeCB.TabIndex = 2;
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.Enabled = false;
            this.updateRecordBtn.Location = new System.Drawing.Point(23, 417);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.updateRecordBtn.TabIndex = 7;
            this.updateRecordBtn.Text = "Редактировать";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(23, 359);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.addRecordBtn.TabIndex = 5;
            this.addRecordBtn.Text = "Добавить";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Enabled = false;
            this.deleteRecordBtn.Location = new System.Drawing.Point(23, 388);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.deleteRecordBtn.TabIndex = 6;
            this.deleteRecordBtn.Text = "Удалить";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(6, 38);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 315);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(778, 289);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Ресурсы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Address,
            this.IsOpen,
            this.AccessDate});
            this.dataGrid.Location = new System.Drawing.Point(6, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(766, 277);
            this.dataGrid.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // IsOpen
            // 
            this.IsOpen.HeaderText = "Открытось";
            this.IsOpen.Name = "IsOpen";
            this.IsOpen.ReadOnly = true;
            // 
            // AccessDate
            // 
            this.AccessDate.HeaderText = "Дата доступа";
            this.AccessDate.Name = "AccessDate";
            this.AccessDate.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGrid2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(778, 289);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Доступы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGrid2
            // 
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Location = new System.Drawing.Point(28, 22);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(240, 150);
            this.dataGrid2.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGrid3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(778, 289);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Файлы";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGrid3
            // 
            this.dataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3.Location = new System.Drawing.Point(74, 43);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.Size = new System.Drawing.Size(240, 150);
            this.dataGrid3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "БД",
            "ОЗУ"});
            this.comboBox1.Location = new System.Drawing.Point(16, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.inputVS);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.outputVS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализаторы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputVS
            // 
            this.inputVS.BackColor = System.Drawing.SystemColors.MenuText;
            this.inputVS.ForeColor = System.Drawing.SystemColors.Info;
            this.inputVS.Location = new System.Drawing.Point(37, 31);
            this.inputVS.Name = "inputVS";
            this.inputVS.Size = new System.Drawing.Size(743, 142);
            this.inputVS.TabIndex = 0;
            this.inputVS.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество иттераций:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // outputVS
            // 
            this.outputVS.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputVS.ForeColor = System.Drawing.SystemColors.Info;
            this.outputVS.Location = new System.Drawing.Point(37, 302);
            this.outputVS.Name = "outputVS";
            this.outputVS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputVS.Size = new System.Drawing.Size(353, 140);
            this.outputVS.TabIndex = 1;
            this.outputVS.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(798, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Низкий уровень";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.logtext);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(798, 461);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Логи";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // logtext
            // 
            this.logtext.BackColor = System.Drawing.SystemColors.InfoText;
            this.logtext.ForeColor = System.Drawing.SystemColors.Info;
            this.logtext.Location = new System.Drawing.Point(3, 14);
            this.logtext.Name = "logtext";
            this.logtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.logtext.Size = new System.Drawing.Size(756, 402);
            this.logtext.TabIndex = 2;
            this.logtext.Text = "";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 490);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.DataGridViewTextBoxColumn Id;
        public System.Windows.Forms.DataGridViewTextBoxColumn Address;
        public System.Windows.Forms.DataGridViewTextBoxColumn IsOpen;
        public System.Windows.Forms.DataGridViewTextBoxColumn AccessDate;
        public System.Windows.Forms.ComboBox fileTypeCB;
        public System.Windows.Forms.Button loadFileBtn;
        public System.Windows.Forms.Button unloadFileBtn;
        public System.Windows.Forms.Button addRecordBtn;
        public System.Windows.Forms.Button updateRecordBtn;
        public System.Windows.Forms.Button deleteRecordBtn;
        public System.Windows.Forms.RichTextBox outputVS;
        public System.Windows.Forms.RichTextBox inputVS;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage7;
        public System.Windows.Forms.TabPage tabPage6;
        public System.Windows.Forms.DataGridView dataGrid2;
        public System.Windows.Forms.DataGridView dataGrid3;
        public System.Windows.Forms.RichTextBox logtext;
    }
}

