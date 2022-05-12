
using App.ActionModals;
using System.Windows.Forms;

namespace App
{
    partial class ActionResource : IViewActionResource
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IsOpen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AccessDate";
            // 
            // okBtn
            // 
            this.OkBtn.Enabled = false;
            this.OkBtn.Location = new System.Drawing.Point(46, 178);
            this.OkBtn.Name = "okBtn";
            this.OkBtn.Size = new System.Drawing.Size(101, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(213, 178);
            this.CancelBtn.Name = "cancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(128, 21);
            this.TextBox1.Name = "textBox1";
            this.TextBox1.Size = new System.Drawing.Size(127, 20);
            this.TextBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "true",
            "false"});
            this.ComboBox1.Location = new System.Drawing.Point(128, 69);
            this.ComboBox1.Name = "comboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(127, 21);
            this.ComboBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(128, 120);
            this.DateTimePicker1.Name = "dateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 9;
            // 
            // ActionResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 226);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActionResource";
            this.Text = "ActionResource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        public Button OkBtn { get => okBtn; set => okBtn = value; }
        public Button CancelBtn { get => cancelBtn; set => cancelBtn = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
    }
}