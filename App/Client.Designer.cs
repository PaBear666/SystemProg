
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileTypeCB = new System.Windows.Forms.ComboBox();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.unloadFileBtn = new System.Windows.Forms.Button();
            this.gropBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.updateRecordBtn = new System.Windows.Forms.Button();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.inputVS = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputVS = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gropBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gropBox1);
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с файлами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileTypeCB);
            this.groupBox2.Controls.Add(this.loadFileBtn);
            this.groupBox2.Controls.Add(this.unloadFileBtn);
            this.groupBox2.Location = new System.Drawing.Point(498, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 188);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Файл";
            // 
            // fileTypeCB
            // 
            this.fileTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileTypeCB.FormattingEnabled = true;
            this.fileTypeCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fileTypeCB.Items.AddRange(new object[] {
            "Plain Text",
            "CSV"});
            this.fileTypeCB.Location = new System.Drawing.Point(20, 40);
            this.fileTypeCB.Name = "fileTypeCB";
            this.fileTypeCB.Size = new System.Drawing.Size(220, 21);
            this.fileTypeCB.TabIndex = 2;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Enabled = false;
            this.loadFileBtn.Location = new System.Drawing.Point(67, 81);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(129, 23);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Сохранить";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // unloadFileBtn
            // 
            this.unloadFileBtn.Enabled = false;
            this.unloadFileBtn.Location = new System.Drawing.Point(67, 133);
            this.unloadFileBtn.Name = "unloadFileBtn";
            this.unloadFileBtn.Size = new System.Drawing.Size(129, 23);
            this.unloadFileBtn.TabIndex = 4;
            this.unloadFileBtn.Text = "Открыть";
            this.unloadFileBtn.UseVisualStyleBackColor = true;
            // 
            // gropBox1
            // 
            this.gropBox1.Controls.Add(this.comboBox1);
            this.gropBox1.Controls.Add(this.addRecordBtn);
            this.gropBox1.Controls.Add(this.updateRecordBtn);
            this.gropBox1.Controls.Add(this.deleteRecordBtn);
            this.gropBox1.Location = new System.Drawing.Point(498, 6);
            this.gropBox1.Name = "gropBox1";
            this.gropBox1.Size = new System.Drawing.Size(246, 204);
            this.gropBox1.TabIndex = 8;
            this.gropBox1.TabStop = false;
            this.gropBox1.Text = "Действия";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "БД",
            "ОЗУ"});
            this.comboBox1.Location = new System.Drawing.Point(20, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(67, 77);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.addRecordBtn.TabIndex = 5;
            this.addRecordBtn.Text = "Добавить";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.Enabled = false;
            this.updateRecordBtn.Location = new System.Drawing.Point(67, 164);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.updateRecordBtn.TabIndex = 7;
            this.updateRecordBtn.Text = "Редактировать";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Enabled = false;
            this.deleteRecordBtn.Location = new System.Drawing.Point(65, 122);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(129, 23);
            this.deleteRecordBtn.TabIndex = 6;
            this.deleteRecordBtn.Text = "Удалить";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Address,
            this.IsOpen,
            this.AccessDate});
            this.dataGrid.Location = new System.Drawing.Point(23, 16);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(443, 366);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.inputVS);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.outputVS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализаторы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 242);
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
            this.inputVS.Size = new System.Drawing.Size(339, 307);
            this.inputVS.TabIndex = 0;
            this.inputVS.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество иттераций:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // outputVS
            // 
            this.outputVS.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputVS.ForeColor = System.Drawing.SystemColors.Info;
            this.outputVS.Location = new System.Drawing.Point(438, 31);
            this.outputVS.Name = "outputVS";
            this.outputVS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputVS.Size = new System.Drawing.Size(280, 106);
            this.outputVS.TabIndex = 1;
            this.outputVS.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Низкий уровень";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Client";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gropBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox fileTypeCB;
        public System.Windows.Forms.Button loadFileBtn;
        public System.Windows.Forms.Button unloadFileBtn;
        public System.Windows.Forms.GroupBox gropBox1;
        public System.Windows.Forms.Button addRecordBtn;
        public System.Windows.Forms.Button updateRecordBtn;
        public System.Windows.Forms.Button deleteRecordBtn;
        public System.Windows.Forms.RichTextBox outputVS;
        public System.Windows.Forms.RichTextBox inputVS;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

