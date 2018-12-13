namespace WindowsFormsApplication4
{
    partial class Registration
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
            this.textBox_about_me = new System.Windows.Forms.TextBox();
            this.checkBox_I_author = new System.Windows.Forms.CheckBox();
            this.checkBox_agree = new System.Windows.Forms.CheckBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_me = new System.Windows.Forms.Label();
            this.button_come = new System.Windows.Forms.Button();
            this.textBox_pic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_zapas = new System.Windows.Forms.Label();
            this.textBox_zapas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(53, 6);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(53, 40);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_about_me
            // 
            this.textBox_about_me.Location = new System.Drawing.Point(12, 157);
            this.textBox_about_me.Multiline = true;
            this.textBox_about_me.Name = "textBox_about_me";
            this.textBox_about_me.Size = new System.Drawing.Size(248, 52);
            this.textBox_about_me.TabIndex = 3;
            this.textBox_about_me.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_about_me_KeyDown);
            // 
            // checkBox_I_author
            // 
            this.checkBox_I_author.AutoSize = true;
            this.checkBox_I_author.Location = new System.Drawing.Point(12, 215);
            this.checkBox_I_author.Name = "checkBox_I_author";
            this.checkBox_I_author.Size = new System.Drawing.Size(66, 17);
            this.checkBox_I_author.TabIndex = 4;
            this.checkBox_I_author.Text = "Я автор";
            this.checkBox_I_author.UseVisualStyleBackColor = true;
            // 
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.Location = new System.Drawing.Point(106, 215);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(157, 17);
            this.checkBox_agree.TabIndex = 5;
            this.checkBox_agree.Text = "Я соглашаюсь блаблабла";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            this.checkBox_agree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox_agree_KeyDown);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(9, 9);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(38, 13);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(2, 40);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 13);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Пароль";
            // 
            // label_me
            // 
            this.label_me.AutoSize = true;
            this.label_me.Location = new System.Drawing.Point(12, 141);
            this.label_me.Name = "label_me";
            this.label_me.Size = new System.Drawing.Size(42, 13);
            this.label_me.TabIndex = 8;
            this.label_me.Text = "О себе";
            // 
            // button_come
            // 
            this.button_come.Location = new System.Drawing.Point(12, 238);
            this.button_come.Name = "button_come";
            this.button_come.Size = new System.Drawing.Size(244, 23);
            this.button_come.TabIndex = 9;
            this.button_come.Text = "Зарегистрироваться";
            this.button_come.UseVisualStyleBackColor = true;
            this.button_come.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pic
            // 
            this.textBox_pic.Location = new System.Drawing.Point(118, 111);
            this.textBox_pic.Name = "textBox_pic";
            this.textBox_pic.Size = new System.Drawing.Size(151, 20);
            this.textBox_pic.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ссылка на картинку";
            // 
            // label_zapas
            // 
            this.label_zapas.AutoSize = true;
            this.label_zapas.Location = new System.Drawing.Point(2, 63);
            this.label_zapas.Name = "label_zapas";
            this.label_zapas.Size = new System.Drawing.Size(163, 13);
            this.label_zapas.TabIndex = 12;
            this.label_zapas.Text = "Слово восстонавления пароля";
            // 
            // textBox_zapas
            // 
            this.textBox_zapas.Location = new System.Drawing.Point(5, 80);
            this.textBox_zapas.Name = "textBox_zapas";
            this.textBox_zapas.Size = new System.Drawing.Size(160, 20);
            this.textBox_zapas.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(166, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Проверить Pic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Начальные данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_zapas);
            this.Controls.Add(this.label_zapas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pic);
            this.Controls.Add(this.button_come);
            this.Controls.Add(this.label_me);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.checkBox_agree);
            this.Controls.Add(this.checkBox_I_author);
            this.Controls.Add(this.textBox_about_me);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "Registration";
            this.Text = "Зарегистрироваться";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_about_me;
        private System.Windows.Forms.CheckBox checkBox_I_author;
        private System.Windows.Forms.CheckBox checkBox_agree;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_me;
        private System.Windows.Forms.Button button_come;
        private System.Windows.Forms.TextBox textBox_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_zapas;
        private System.Windows.Forms.TextBox textBox_zapas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}