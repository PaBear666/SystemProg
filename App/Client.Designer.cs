
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gropBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gropBox1);
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1027, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Работа с файлами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fileTypeCB);
            this.groupBox2.Controls.Add(this.loadFileBtn);
            this.groupBox2.Controls.Add(this.unloadFileBtn);
            this.groupBox2.Location = new System.Drawing.Point(664, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(328, 231);
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
            this.fileTypeCB.Location = new System.Drawing.Point(27, 49);
            this.fileTypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.fileTypeCB.Name = "fileTypeCB";
            this.fileTypeCB.Size = new System.Drawing.Size(292, 24);
            this.fileTypeCB.TabIndex = 2;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Enabled = false;
            this.loadFileBtn.Location = new System.Drawing.Point(89, 100);
            this.loadFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(172, 28);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Сохранить";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            // 
            // unloadFileBtn
            // 
            this.unloadFileBtn.Enabled = false;
            this.unloadFileBtn.Location = new System.Drawing.Point(89, 164);
            this.unloadFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.unloadFileBtn.Name = "unloadFileBtn";
            this.unloadFileBtn.Size = new System.Drawing.Size(172, 28);
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
            this.gropBox1.Location = new System.Drawing.Point(664, 7);
            this.gropBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gropBox1.Name = "gropBox1";
            this.gropBox1.Padding = new System.Windows.Forms.Padding(4);
            this.gropBox1.Size = new System.Drawing.Size(328, 251);
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
            this.comboBox1.Location = new System.Drawing.Point(27, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(89, 95);
            this.addRecordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(169, 28);
            this.addRecordBtn.TabIndex = 5;
            this.addRecordBtn.Text = "Добавить";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.Enabled = false;
            this.updateRecordBtn.Location = new System.Drawing.Point(89, 202);
            this.updateRecordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(169, 28);
            this.updateRecordBtn.TabIndex = 7;
            this.updateRecordBtn.Text = "Редактировать";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Enabled = false;
            this.deleteRecordBtn.Location = new System.Drawing.Point(87, 150);
            this.deleteRecordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(172, 28);
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
            this.dataGrid.Location = new System.Drawing.Point(31, 20);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(591, 450);
            this.dataGrid.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // IsOpen
            // 
            this.IsOpen.HeaderText = "Открытось";
            this.IsOpen.MinimumWidth = 6;
            this.IsOpen.Name = "IsOpen";
            this.IsOpen.ReadOnly = true;
            this.IsOpen.Width = 125;
            // 
            // AccessDate
            // 
            this.AccessDate.HeaderText = "Дата доступа";
            this.AccessDate.MinimumWidth = 6;
            this.AccessDate.Name = "AccessDate";
            this.AccessDate.ReadOnly = true;
            this.AccessDate.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.inputVS);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.outputVS);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализаторы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputVS
            // 
            this.inputVS.BackColor = System.Drawing.SystemColors.MenuText;
            this.inputVS.ForeColor = System.Drawing.SystemColors.Info;
            this.inputVS.Location = new System.Drawing.Point(49, 38);
            this.inputVS.Margin = new System.Windows.Forms.Padding(4);
            this.inputVS.Name = "inputVS";
            this.inputVS.Size = new System.Drawing.Size(451, 377);
            this.inputVS.TabIndex = 0;
            this.inputVS.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество иттераций:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(824, 220);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // outputVS
            // 
            this.outputVS.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputVS.ForeColor = System.Drawing.SystemColors.Info;
            this.outputVS.Location = new System.Drawing.Point(584, 38);
            this.outputVS.Margin = new System.Windows.Forms.Padding(4);
            this.outputVS.Name = "outputVS";
            this.outputVS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.outputVS.Size = new System.Drawing.Size(372, 130);
            this.outputVS.TabIndex = 1;
            this.outputVS.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1027, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Низкий уровень";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(342, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(192, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(374, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Частное";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(221, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Делитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Делимое";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(315, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Целочисленное деление без знака";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(379, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(226, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(78, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(78, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 57);
            this.button2.TabIndex = 0;
            this.button2.Text = "Деление";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

