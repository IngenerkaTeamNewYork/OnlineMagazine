﻿namespace WindowsFormsApplication4
{
    partial class To_come_in
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_come = new System.Windows.Forms.Button();
            this.label_of_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(35, 34);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(35, 73);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // button_come
            // 
            this.button_come.Location = new System.Drawing.Point(35, 124);
            this.button_come.Name = "button_come";
            this.button_come.Size = new System.Drawing.Size(75, 23);
            this.button_come.TabIndex = 2;
            this.button_come.Text = "Войти";
            this.button_come.UseVisualStyleBackColor = true;
            this.button_come.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_of_login
            // 
            this.label_of_login.AutoSize = true;
            this.label_of_login.Location = new System.Drawing.Point(32, 18);
            this.label_of_login.Name = "label_of_login";
            this.label_of_login.Size = new System.Drawing.Size(38, 13);
            this.label_of_login.TabIndex = 3;
            this.label_of_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(32, 57);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Пароль";
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Location = new System.Drawing.Point(12, 101);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(69, 17);
            this.checkBox_admin.TabIndex = 5;
            this.checkBox_admin.Text = "Я админ";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // To_come_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 159);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_of_login);
            this.Controls.Add(this.button_come);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "To_come_in";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_come;
        private System.Windows.Forms.Label label_of_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.CheckBox checkBox_admin;
    }
}