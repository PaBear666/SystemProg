
using App.ActionModals;
using System.Windows.Forms;

namespace App
{
    partial class ActionFileRecord : IViewActionFile
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
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(129, 127);
            this.DateTimePicker1.Name = "dateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(129, 28);
            this.TextBox1.Name = "textBox1";
            this.TextBox1.Size = new System.Drawing.Size(127, 20);
            this.TextBox1.TabIndex = 15;
            // 
            // cancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(214, 185);
            this.CancelBtn.Name = "cancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 23);
            this.CancelBtn.TabIndex = 14;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.OkBtn.Enabled = false;
            this.OkBtn.Location = new System.Drawing.Point(47, 185);
            this.OkBtn.Name = "okBtn";
            this.OkBtn.Size = new System.Drawing.Size(101, 23);
            this.OkBtn.TabIndex = 13;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LastEditDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Path";
            // 
            // textBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(129, 81);
            this.TextBox2.Name = "textBox2";
            this.TextBox2.Size = new System.Drawing.Size(127, 20);
            this.TextBox2.TabIndex = 18;
            // 
            // ActionFileRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 236);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActionFileRecord";
            this.Text = "ActionFileRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;

        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public TextBox TextBox2 { get => textBox2; set => textBox2 = value; }
        public Button CancelBtn { get => cancelBtn; set => cancelBtn = value; }
        public Button OkBtn { get => okBtn; set => okBtn = value; }
    }
}