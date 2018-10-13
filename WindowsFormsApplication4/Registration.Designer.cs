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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_about_me = new System.Windows.Forms.TextBox();
            this.checkBox_I_author = new System.Windows.Forms.CheckBox();
            this.checkBox_agree = new System.Windows.Forms.CheckBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_me = new System.Windows.Forms.Label();
            this.button_come = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(172, 26);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 1;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(172, 60);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_about_me
            // 
            this.textBox_about_me.Location = new System.Drawing.Point(12, 123);
            this.textBox_about_me.Multiline = true;
            this.textBox_about_me.Name = "textBox_about_me";
            this.textBox_about_me.Size = new System.Drawing.Size(248, 52);
            this.textBox_about_me.TabIndex = 3;
            this.textBox_about_me.TextChanged += new System.EventHandler(this.textBox_about_me_TextChanged);
            this.textBox_about_me.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_about_me_KeyDown);
            // 
            // checkBox_I_author
            // 
            this.checkBox_I_author.AutoSize = true;
            this.checkBox_I_author.Location = new System.Drawing.Point(13, 181);
            this.checkBox_I_author.Name = "checkBox_I_author";
            this.checkBox_I_author.Size = new System.Drawing.Size(66, 17);
            this.checkBox_I_author.TabIndex = 4;
            this.checkBox_I_author.Text = "Я автор";
            this.checkBox_I_author.UseVisualStyleBackColor = true;
            // 
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.Location = new System.Drawing.Point(109, 181);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(157, 17);
            this.checkBox_agree.TabIndex = 5;
            this.checkBox_agree.Text = "Я соглашаюсь блаблабла";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(131, 33);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(38, 13);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(124, 63);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 13);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "Пароль";
            // 
            // label_me
            // 
            this.label_me.AutoSize = true;
            this.label_me.Location = new System.Drawing.Point(13, 97);
            this.label_me.Name = "label_me";
            this.label_me.Size = new System.Drawing.Size(42, 13);
            this.label_me.TabIndex = 8;
            this.label_me.Text = "О себе";
            // 
            // button_come
            // 
            this.button_come.Location = new System.Drawing.Point(16, 204);
            this.button_come.Name = "button_come";
            this.button_come.Size = new System.Drawing.Size(244, 23);
            this.button_come.TabIndex = 9;
            this.button_come.Text = "Зарегистрироваться";
            this.button_come.UseVisualStyleBackColor = true;
            this.button_come.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.button_come);
            this.Controls.Add(this.label_me);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.checkBox_agree);
            this.Controls.Add(this.checkBox_I_author);
            this.Controls.Add(this.textBox_about_me);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_about_me;
        private System.Windows.Forms.CheckBox checkBox_I_author;
        private System.Windows.Forms.CheckBox checkBox_agree;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_me;
        private System.Windows.Forms.Button button_come;
    }
}