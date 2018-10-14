namespace WindowsFormsApplication4
{
    partial class GhostMainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.categories_linklabel = new System.Windows.Forms.LinkLabel();
            this.butto_search = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.link_of_come = new System.Windows.Forms.LinkLabel();
            this.link_of_registration = new System.Windows.Forms.LinkLabel();
            this.Реклама3 = new System.Windows.Forms.PictureBox();
            this.Реклама2 = new System.Windows.Forms.PictureBox();
            this.Реклама = new System.Windows.Forms.PictureBox();
            this.Right_panel = new System.Windows.Forms.Panel();
            this.button_add_reklama = new System.Windows.Forms.Button();
            this.label_popular = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.Centr_panel = new System.Windows.Forms.Panel();
            this.articleTextBox_statii = new System.Windows.Forms.TextBox();
            this.label_name_statya = new System.Windows.Forms.Label();
            this.label_kategoriya_statii = new System.Windows.Forms.Label();
            this.vScrollBar1_centr = new System.Windows.Forms.VScrollBar();
            this.Image_statii = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.checkBox_imadmin = new System.Windows.Forms.CheckBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_of_login = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама)).BeginInit();
            this.Right_panel.SuspendLayout();
            this.Centr_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_statii)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // categories_linklabel
            // 
            this.categories_linklabel.AutoSize = true;
            this.categories_linklabel.Location = new System.Drawing.Point(25, 121);
            this.categories_linklabel.Name = "categories_linklabel";
            this.categories_linklabel.Size = new System.Drawing.Size(60, 13);
            this.categories_linklabel.TabIndex = 4;
            this.categories_linklabel.TabStop = true;
            this.categories_linklabel.Text = "Категории";
            this.categories_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.categories_linklabel_LinkClicked);
            // 
            // butto_search
            // 
            this.butto_search.Location = new System.Drawing.Point(462, 12);
            this.butto_search.Name = "butto_search";
            this.butto_search.Size = new System.Drawing.Size(54, 23);
            this.butto_search.TabIndex = 0;
            this.butto_search.Text = "Найти";
            this.butto_search.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 523);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.tableLayoutPanel1);
            this.Left_panel.Controls.Add(this.textBox1);
            this.Left_panel.Controls.Add(this.link_of_come);
            this.Left_panel.Controls.Add(this.link_of_registration);
            this.Left_panel.Controls.Add(this.Реклама3);
            this.Left_panel.Controls.Add(this.Реклама2);
            this.Left_panel.Controls.Add(this.radioButton1);
            this.Left_panel.Controls.Add(this.Реклама);
            this.Left_panel.Location = new System.Drawing.Point(3, 12);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(226, 555);
            this.Left_panel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 496);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 56);
            this.textBox1.TabIndex = 8;
            // 
            // link_of_come
            // 
            this.link_of_come.AutoSize = true;
            this.link_of_come.Location = new System.Drawing.Point(10, 504);
            this.link_of_come.Name = "link_of_come";
            this.link_of_come.Size = new System.Drawing.Size(37, 13);
            this.link_of_come.TabIndex = 7;
            this.link_of_come.TabStop = true;
            this.link_of_come.Text = "Войти";
            this.link_of_come.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // link_of_registration
            // 
            this.link_of_registration.AutoSize = true;
            this.link_of_registration.Location = new System.Drawing.Point(10, 484);
            this.link_of_registration.Name = "link_of_registration";
            this.link_of_registration.Size = new System.Drawing.Size(72, 13);
            this.link_of_registration.TabIndex = 6;
            this.link_of_registration.TabStop = true;
            this.link_of_registration.Text = "Регистрация";
            this.link_of_registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Реклама3
            // 
            this.Реклама3.Location = new System.Drawing.Point(23, 363);
            this.Реклама3.Name = "Реклама3";
            this.Реклама3.Size = new System.Drawing.Size(172, 114);
            this.Реклама3.TabIndex = 5;
            this.Реклама3.TabStop = false;
            // 
            // Реклама2
            // 
            this.Реклама2.Location = new System.Drawing.Point(23, 239);
            this.Реклама2.Name = "Реклама2";
            this.Реклама2.Size = new System.Drawing.Size(172, 102);
            this.Реклама2.TabIndex = 4;
            this.Реклама2.TabStop = false;
            this.Реклама2.Click += new System.EventHandler(this.Реклама2_Click);
            // 
            // Реклама
            // 
            this.Реклама.Location = new System.Drawing.Point(13, 138);
            this.Реклама.Name = "Реклама";
            this.Реклама.Size = new System.Drawing.Size(199, 95);
            this.Реклама.TabIndex = 2;
            this.Реклама.TabStop = false;
            // 
            // Right_panel
            // 
            this.Right_panel.Controls.Add(this.button_add_reklama);
            this.Right_panel.Controls.Add(this.categories_linklabel);
            this.Right_panel.Controls.Add(this.label_popular);
            this.Right_panel.Controls.Add(this.label_author);
            this.Right_panel.Location = new System.Drawing.Point(522, 10);
            this.Right_panel.Name = "Right_panel";
            this.Right_panel.Size = new System.Drawing.Size(217, 567);
            this.Right_panel.TabIndex = 5;
            // 
            // button_add_reklama
            // 
            this.button_add_reklama.Location = new System.Drawing.Point(28, 475);
            this.button_add_reklama.Name = "button_add_reklama";
            this.button_add_reklama.Size = new System.Drawing.Size(150, 23);
            this.button_add_reklama.TabIndex = 5;
            this.button_add_reklama.Text = "Предложить рекламу";
            this.button_add_reklama.UseVisualStyleBackColor = true;
            this.button_add_reklama.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_popular
            // 
            this.label_popular.AutoSize = true;
            this.label_popular.Location = new System.Drawing.Point(25, 94);
            this.label_popular.Name = "label_popular";
            this.label_popular.Size = new System.Drawing.Size(68, 13);
            this.label_popular.TabIndex = 3;
            this.label_popular.Text = "Популярное";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(22, 147);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(45, 13);
            this.label_author.TabIndex = 2;
            this.label_author.Text = "Авторы";
            this.label_author.Click += new System.EventHandler(this.label_author_Click);
            // 
            // Centr_panel
            // 
            this.Centr_panel.Controls.Add(this.articleTextBox_statii);
            this.Centr_panel.Controls.Add(this.label_name_statya);
            this.Centr_panel.Controls.Add(this.label_kategoriya_statii);
            this.Centr_panel.Controls.Add(this.vScrollBar1_centr);
            this.Centr_panel.Controls.Add(this.Image_statii);
            this.Centr_panel.Location = new System.Drawing.Point(245, 42);
            this.Centr_panel.Name = "Centr_panel";
            this.Centr_panel.Size = new System.Drawing.Size(255, 534);
            this.Centr_panel.TabIndex = 6;
            // 
            // articleTextBox_statii
            // 
            this.articleTextBox_statii.BackColor = System.Drawing.SystemColors.Control;
            this.articleTextBox_statii.Enabled = false;
            this.articleTextBox_statii.ForeColor = System.Drawing.Color.Black;
            this.articleTextBox_statii.Location = new System.Drawing.Point(36, 290);
            this.articleTextBox_statii.Multiline = true;
            this.articleTextBox_statii.Name = "articleTextBox_statii";
            this.articleTextBox_statii.Size = new System.Drawing.Size(171, 157);
            this.articleTextBox_statii.TabIndex = 5;
            this.articleTextBox_statii.TextChanged += new System.EventHandler(this.articleTextBox_TextChanged);
            // 
            // label_name_statya
            // 
            this.label_name_statya.AutoSize = true;
            this.label_name_statya.Location = new System.Drawing.Point(92, 34);
            this.label_name_statya.Name = "label_name_statya";
            this.label_name_statya.Size = new System.Drawing.Size(38, 13);
            this.label_name_statya.TabIndex = 2;
            this.label_name_statya.Text = "Класс";
            // 
            // label_kategoriya_statii
            // 
            this.label_kategoriya_statii.AutoSize = true;
            this.label_kategoriya_statii.Location = new System.Drawing.Point(12, 18);
            this.label_kategoriya_statii.Name = "label_kategoriya_statii";
            this.label_kategoriya_statii.Size = new System.Drawing.Size(35, 13);
            this.label_kategoriya_statii.TabIndex = 4;
            this.label_kategoriya_statii.Text = "label6";
            // 
            // vScrollBar1_centr
            // 
            this.vScrollBar1_centr.Location = new System.Drawing.Point(238, 4);
            this.vScrollBar1_centr.Name = "vScrollBar1_centr";
            this.vScrollBar1_centr.Size = new System.Drawing.Size(17, 524);
            this.vScrollBar1_centr.TabIndex = 1;
            // 
            // Image_statii
            // 
            this.Image_statii.Location = new System.Drawing.Point(36, 62);
            this.Image_statii.Name = "Image_statii";
            this.Image_statii.Size = new System.Drawing.Size(171, 208);
            this.Image_statii.TabIndex = 0;
            this.Image_statii.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(260, 13);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(205, 20);
            this.textBox_search.TabIndex = 7;
            this.textBox_search.Text = "Поиск";
            // 
            // checkBox_imadmin
            // 
            this.checkBox_imadmin.AutoSize = true;
            this.checkBox_imadmin.Location = new System.Drawing.Point(3, 3);
            this.checkBox_imadmin.Name = "checkBox_imadmin";
            this.checkBox_imadmin.Size = new System.Drawing.Size(69, 17);
            this.checkBox_imadmin.TabIndex = 14;
            this.checkBox_imadmin.Text = "Я админ";
            this.checkBox_imadmin.UseVisualStyleBackColor = true;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(3, 40);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 13);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Пароль";
            // 
            // label_of_login
            // 
            this.label_of_login.AutoSize = true;
            this.label_of_login.Location = new System.Drawing.Point(3, 0);
            this.label_of_login.Name = "label_of_login";
            this.label_of_login.Size = new System.Drawing.Size(38, 13);
            this.label_of_login.TabIndex = 12;
            this.label_of_login.Text = "Логин";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(113, 3);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(96, 40);
            this.button_login.TabIndex = 11;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(3, 63);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 10;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(3, 23);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_of_login, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_login, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_password, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_password, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 132);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox_imadmin, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_login, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(220, 46);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // GhostMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.Left_panel);
            this.Controls.Add(this.Right_panel);
            this.Controls.Add(this.Centr_panel);
            this.Controls.Add(this.butto_search);
            this.Name = "GhostMainForm";
            this.Text = "Общий вид";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GhostMainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Left_panel.ResumeLayout(false);
            this.Left_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама)).EndInit();
            this.Right_panel.ResumeLayout(false);
            this.Right_panel.PerformLayout();
            this.Centr_panel.ResumeLayout(false);
            this.Centr_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_statii)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butto_search;
        private System.Windows.Forms.PictureBox Реклама;
        private System.Windows.Forms.PictureBox Реклама2;
        private System.Windows.Forms.PictureBox Реклама3;
        private System.Windows.Forms.Label label_popular;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_name_statya;
        private System.Windows.Forms.Label label_kategoriya_statii;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Panel Right_panel;
        private System.Windows.Forms.Panel Centr_panel;
        private System.Windows.Forms.VScrollBar vScrollBar1_centr;
        private System.Windows.Forms.PictureBox Image_statii;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.LinkLabel categories_linklabel;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.LinkLabel link_of_registration;
        public System.Windows.Forms.LinkLabel link_of_come;
        protected System.Windows.Forms.TextBox articleTextBox_statii;
        private System.Windows.Forms.Button button_add_reklama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_of_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox_imadmin;
        private System.Windows.Forms.Button button_login;
    }
}

