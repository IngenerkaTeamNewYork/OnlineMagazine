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
            this.panel1 = new System.Windows.Forms.Panel();
            this.link_of_come = new System.Windows.Forms.LinkLabel();
            this.link_of_registration = new System.Windows.Forms.LinkLabel();
            this.Реклама3 = new System.Windows.Forms.PictureBox();
            this.Реклама2 = new System.Windows.Forms.PictureBox();
            this.Реклама = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.popular = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.label_of_like = new System.Windows.Forms.Label();
            this.label_of_name = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.link_of_come);
            this.panel1.Controls.Add(this.link_of_registration);
            this.panel1.Controls.Add(this.Реклама3);
            this.panel1.Controls.Add(this.Реклама2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.Реклама);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 555);
            this.panel1.TabIndex = 4;
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
            this.Реклама3.Location = new System.Drawing.Point(10, 272);
            this.Реклама3.Name = "Реклама3";
            this.Реклама3.Size = new System.Drawing.Size(172, 205);
            this.Реклама3.TabIndex = 5;
            this.Реклама3.TabStop = false;
            // 
            // Реклама2
            // 
            this.Реклама2.Location = new System.Drawing.Point(10, 92);
            this.Реклама2.Name = "Реклама2";
            this.Реклама2.Size = new System.Drawing.Size(172, 174);
            this.Реклама2.TabIndex = 4;
            this.Реклама2.TabStop = false;
            this.Реклама2.Click += new System.EventHandler(this.Реклама2_Click);
            // 
            // Реклама
            // 
            this.Реклама.Location = new System.Drawing.Point(9, 19);
            this.Реклама.Name = "Реклама";
            this.Реклама.Size = new System.Drawing.Size(182, 67);
            this.Реклама.TabIndex = 2;
            this.Реклама.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.categories_linklabel);
            this.panel2.Controls.Add(this.popular);
            this.panel2.Controls.Add(this.label_author);
            this.panel2.Location = new System.Drawing.Point(522, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 567);
            this.panel2.TabIndex = 5;
            // 
            // popular
            // 
            this.popular.AutoSize = true;
            this.popular.Location = new System.Drawing.Point(25, 94);
            this.popular.Name = "popular";
            this.popular.Size = new System.Drawing.Size(68, 13);
            this.popular.TabIndex = 3;
            this.popular.Text = "Популярное";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.articleTextBox);
            this.panel3.Controls.Add(this.label_of_like);
            this.panel3.Controls.Add(this.label_of_name);
            this.panel3.Controls.Add(this.vScrollBar1);
            this.panel3.Controls.Add(this.Image1);
            this.panel3.Location = new System.Drawing.Point(245, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 534);
            this.panel3.TabIndex = 6;
            // 
            // articleTextBox
            // 
            this.articleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.articleTextBox.Enabled = false;
            this.articleTextBox.ForeColor = System.Drawing.Color.Black;
            this.articleTextBox.Location = new System.Drawing.Point(36, 290);
            this.articleTextBox.Multiline = true;
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(171, 157);
            this.articleTextBox.TabIndex = 5;
            this.articleTextBox.TextChanged += new System.EventHandler(this.articleTextBox_TextChanged);
            // 
            // label_of_like
            // 
            this.label_of_like.AutoSize = true;
            this.label_of_like.Location = new System.Drawing.Point(92, 34);
            this.label_of_like.Name = "label_of_like";
            this.label_of_like.Size = new System.Drawing.Size(38, 13);
            this.label_of_like.TabIndex = 2;
            this.label_of_like.Text = "Класс";
            // 
            // label_of_name
            // 
            this.label_of_name.AutoSize = true;
            this.label_of_name.Location = new System.Drawing.Point(12, 18);
            this.label_of_name.Name = "label_of_name";
            this.label_of_name.Size = new System.Drawing.Size(35, 13);
            this.label_of_name.TabIndex = 4;
            this.label_of_name.Text = "label6";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(238, 4);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 524);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Image1
            // 
            this.Image1.Location = new System.Drawing.Point(36, 62);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(171, 208);
            this.Image1.TabIndex = 0;
            this.Image1.TabStop = false;
            this.Image1.Click += new System.EventHandler(this.image_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(260, 13);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(205, 20);
            this.textBox_search.TabIndex = 7;
            this.textBox_search.Text = "Поиск";
            // 
            // GhostMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.butto_search);
            this.Name = "GhostMainForm";
            this.Text = "Общий вид";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Реклама)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butto_search;
        private System.Windows.Forms.PictureBox Реклама;
        private System.Windows.Forms.PictureBox Реклама2;
        private System.Windows.Forms.PictureBox Реклама3;
        private System.Windows.Forms.Label popular;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_of_like;
        private System.Windows.Forms.Label label_of_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.LinkLabel categories_linklabel;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.LinkLabel link_of_registration;
        public System.Windows.Forms.LinkLabel link_of_come;
        protected System.Windows.Forms.TextBox articleTextBox;
    }
}

