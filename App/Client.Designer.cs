
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
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.updateRecordBtn = new System.Windows.Forms.Button();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gropBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
            this.fileTypeCB.SelectedIndexChanged += new System.EventHandler(this.EnableBtnWorkWithFile_SelectedIndexChanged);
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Enabled = false;
            this.loadFileBtn.Location = new System.Drawing.Point(67, 81);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(129, 23);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Загрузить в файл";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.UnloadFileBtn_Click);
            // 
            // unloadFileBtn
            // 
            this.unloadFileBtn.Enabled = false;
            this.unloadFileBtn.Location = new System.Drawing.Point(67, 133);
            this.unloadFileBtn.Name = "unloadFileBtn";
            this.unloadFileBtn.Size = new System.Drawing.Size(129, 23);
            this.unloadFileBtn.TabIndex = 4;
            this.unloadFileBtn.Text = "Загрузить из файла";
            this.unloadFileBtn.UseVisualStyleBackColor = true;
            this.unloadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // gropBox1
            // 
            this.gropBox1.Controls.Add(this.addRecordBtn);
            this.gropBox1.Controls.Add(this.updateRecordBtn);
            this.gropBox1.Controls.Add(this.deleteRecordBtn);
            this.gropBox1.Location = new System.Drawing.Point(498, 6);
            this.gropBox1.Name = "gropBox1";
            this.gropBox1.Size = new System.Drawing.Size(246, 186);
            this.gropBox1.TabIndex = 8;
            this.gropBox1.TabStop = false;
            this.gropBox1.Text = "Действия";
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(69, 40);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.addRecordBtn.TabIndex = 5;
            this.addRecordBtn.Text = "Добавить";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.Enabled = false;
            this.updateRecordBtn.Location = new System.Drawing.Point(69, 127);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(127, 23);
            this.updateRecordBtn.TabIndex = 7;
            this.updateRecordBtn.Text = "Редактировать";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            this.updateRecordBtn.Click += new System.EventHandler(this.UpdateRecordBtn_Click);
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Enabled = false;
            this.deleteRecordBtn.Location = new System.Drawing.Point(67, 85);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(129, 23);
            this.deleteRecordBtn.TabIndex = 6;
            this.deleteRecordBtn.Text = "Удалить";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            this.deleteRecordBtn.Click += new System.EventHandler(this.DeleteRecordBtn_Click);
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
            this.dataGrid.SelectionChanged += new System.EventHandler(this.SelectedRowEvent);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализаторы";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox fileTypeCB;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button unloadFileBtn;
        private System.Windows.Forms.GroupBox gropBox1;
        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Button updateRecordBtn;
        private System.Windows.Forms.Button deleteRecordBtn;
    }
}

