
namespace App
{
    partial class ActionDllRecord
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 15;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(214, 182);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Enabled = false;
            this.okBtn.Location = new System.Drawing.Point(47, 182);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(101, 23);
            this.okBtn.TabIndex = 13;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "LastEditDate";
            // 
            // versionTextBox
            // 
            this.versionTextBox.AutoSize = true;
            this.versionTextBox.Location = new System.Drawing.Point(44, 81);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(39, 13);
            this.versionTextBox.TabIndex = 11;
            this.versionTextBox.Text = "Vesion";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AutoSize = true;
            this.nameTextBox.Location = new System.Drawing.Point(44, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(35, 13);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 18;
            // 
            // ActionDllRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 247);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ActionDllRecord";
            this.Text = "ActionDllRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label versionTextBox;
        public System.Windows.Forms.Label nameTextBox;
        public System.Windows.Forms.TextBox textBox2;
    }
}