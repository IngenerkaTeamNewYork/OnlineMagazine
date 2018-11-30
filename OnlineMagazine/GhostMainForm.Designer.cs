
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
            this.components = new System.ComponentModel.Container();
            this.categories_linklabel = new System.Windows.Forms.LinkLabel();
            this.butto_search = new System.Windows.Forms.Button();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.reclamaPanel = new System.Windows.Forms.Panel();
            this.reclama3 = new System.Windows.Forms.PictureBox();
            this.reclama = new System.Windows.Forms.PictureBox();
            this.reclama2 = new System.Windows.Forms.PictureBox();
            this.adminPpanel = new System.Windows.Forms.Panel();
            this.AutButton = new System.Windows.Forms.Button();
            this.AdmButton = new System.Windows.Forms.Button();
            this.authorizationTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label_of_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.увеличитьПисюнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_login = new System.Windows.Forms.Button();
            this.link_of_registration = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Right_panel = new System.Windows.Forms.Panel();
            this.label_Author_header = new System.Windows.Forms.Label();
            this.lable_name_of_polzovatel = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.label_cats_header = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_add_reklama = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Centr_panel = new System.Windows.Forms.Panel();
            this.dalee = new System.Windows.Forms.Button();
            this.popularArticlesLabel = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Left_panel.SuspendLayout();
            this.reclamaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reclama3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclama2)).BeginInit();
            this.adminPpanel.SuspendLayout();
            this.authorizationTableLayoutPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.autButtonsTableLayoutPanel.SuspendLayout();
            this.Right_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Centr_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categories_linklabel
            // 
            this.categories_linklabel.AutoSize = true;
            this.categories_linklabel.Location = new System.Drawing.Point(10, 388);
            this.categories_linklabel.Name = "categories_linklabel";
            this.categories_linklabel.Size = new System.Drawing.Size(81, 13);
            this.categories_linklabel.TabIndex = 4;
            this.categories_linklabel.TabStop = true;
            this.categories_linklabel.Text = "Все категории";
            this.categories_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.categories_linklabel_LinkClicked);
            // 
            // butto_search
            // 
            this.butto_search.Location = new System.Drawing.Point(439, 3);
            this.butto_search.Name = "butto_search";
            this.butto_search.Size = new System.Drawing.Size(77, 44);
            this.butto_search.TabIndex = 0;
            this.butto_search.Text = "Найти";
            this.butto_search.UseVisualStyleBackColor = true;
            this.butto_search.Click += new System.EventHandler(this.butto_search_Click);
            this.butto_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.butto_search_KeyDown);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.reclamaPanel);
            this.Left_panel.Controls.Add(this.adminPpanel);
            this.Left_panel.Controls.Add(this.authorizationTableLayoutPanel);
            this.Left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_panel.Location = new System.Drawing.Point(0, 0);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(226, 579);
            this.Left_panel.TabIndex = 4;
            // 
            // reclamaPanel
            // 
            this.reclamaPanel.Controls.Add(this.reclama3);
            this.reclamaPanel.Controls.Add(this.reclama);
            this.reclamaPanel.Controls.Add(this.reclama2);
            this.reclamaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reclamaPanel.Location = new System.Drawing.Point(0, 114);
            this.reclamaPanel.Margin = new System.Windows.Forms.Padding(2);
            this.reclamaPanel.Name = "reclamaPanel";
            this.reclamaPanel.Size = new System.Drawing.Size(226, 437);
            this.reclamaPanel.TabIndex = 16;
            // 
            // reclama3
            // 
            this.reclama3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reclama3.Location = new System.Drawing.Point(0, 358);
            this.reclama3.Name = "reclama3";
            this.reclama3.Size = new System.Drawing.Size(226, 79);
            this.reclama3.TabIndex = 5;
            this.reclama3.TabStop = false;
            this.reclama3.Click += new System.EventHandler(this.reclama_Click);
            // 
            // reclama
            // 
            this.reclama.Dock = System.Windows.Forms.DockStyle.Top;
            this.reclama.Location = new System.Drawing.Point(0, 170);
            this.reclama.Name = "reclama";
            this.reclama.Size = new System.Drawing.Size(226, 188);
            this.reclama.TabIndex = 2;
            this.reclama.TabStop = false;
            this.reclama.Click += new System.EventHandler(this.reclama_Click);
            // 
            // reclama2
            // 
            this.reclama2.Dock = System.Windows.Forms.DockStyle.Top;
            this.reclama2.Location = new System.Drawing.Point(0, 0);
            this.reclama2.Name = "reclama2";
            this.reclama2.Size = new System.Drawing.Size(226, 170);
            this.reclama2.TabIndex = 4;
            this.reclama2.TabStop = false;
            this.reclama2.Click += new System.EventHandler(this.reclama_Click);
            // 
            // adminPpanel
            // 
            this.adminPpanel.Controls.Add(this.AutButton);
            this.adminPpanel.Controls.Add(this.AdmButton);
            this.adminPpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminPpanel.Location = new System.Drawing.Point(0, 551);
            this.adminPpanel.Margin = new System.Windows.Forms.Padding(2);
            this.adminPpanel.Name = "adminPpanel";
            this.adminPpanel.Size = new System.Drawing.Size(226, 28);
            this.adminPpanel.TabIndex = 0;
            // 
            // AutButton
            // 
            this.AutButton.Location = new System.Drawing.Point(0, 4);
            this.AutButton.Margin = new System.Windows.Forms.Padding(2);
            this.AutButton.Name = "AutButton";
            this.AutButton.Size = new System.Drawing.Size(100, 19);
            this.AutButton.TabIndex = 8;
            this.AutButton.Text = "Кабинет автора";
            this.AutButton.UseVisualStyleBackColor = true;
            this.AutButton.Visible = false;
            this.AutButton.Click += new System.EventHandler(this.AutButton_Click);
            // 
            // AdmButton
            // 
            this.AdmButton.Location = new System.Drawing.Point(114, 4);
            this.AdmButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdmButton.Name = "AdmButton";
            this.AdmButton.Size = new System.Drawing.Size(112, 19);
            this.AdmButton.TabIndex = 16;
            this.AdmButton.Text = "Кабинет админа";
            this.AdmButton.UseVisualStyleBackColor = true;
            this.AdmButton.Click += new System.EventHandler(this.AdmButton_Click);
            // 
            // authorizationTableLayoutPanel
            // 
            this.authorizationTableLayoutPanel.ColumnCount = 1;
            this.authorizationTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.authorizationTableLayoutPanel.Controls.Add(this.label_of_login, 0, 0);
            this.authorizationTableLayoutPanel.Controls.Add(this.textBox_login, 0, 1);
            this.authorizationTableLayoutPanel.Controls.Add(this.label_password, 0, 2);
            this.authorizationTableLayoutPanel.Controls.Add(this.textBox_password, 0, 3);
            this.authorizationTableLayoutPanel.Controls.Add(this.autButtonsTableLayoutPanel, 0, 4);
            this.authorizationTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorizationTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.authorizationTableLayoutPanel.Name = "authorizationTableLayoutPanel";
            this.authorizationTableLayoutPanel.RowCount = 5;
            this.authorizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.authorizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.authorizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.authorizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.authorizationTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.authorizationTableLayoutPanel.Size = new System.Drawing.Size(226, 114);
            this.authorizationTableLayoutPanel.TabIndex = 15;
            // 
            // label_of_login
            // 
            this.label_of_login.AutoSize = true;
            this.label_of_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_of_login.Location = new System.Drawing.Point(3, 0);
            this.label_of_login.Name = "label_of_login";
            this.label_of_login.Size = new System.Drawing.Size(220, 20);
            this.label_of_login.TabIndex = 12;
            this.label_of_login.Text = "Логин";
            this.label_of_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_login
            // 
            this.textBox_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_login.Location = new System.Drawing.Point(3, 23);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(220, 20);
            this.textBox_login.TabIndex = 9;
            this.textBox_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_login_KeyDown);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_password.Location = new System.Drawing.Point(3, 40);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(220, 20);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Пароль";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_password
            // 
            this.textBox_password.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox_password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_password.Location = new System.Drawing.Point(3, 63);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(220, 20);
            this.textBox_password.TabIndex = 10;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_login_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьПисюнToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 26);
            // 
            // увеличитьПисюнToolStripMenuItem
            // 
            this.увеличитьПисюнToolStripMenuItem.Name = "увеличитьПисюнToolStripMenuItem";
            this.увеличитьПисюнToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.увеличитьПисюнToolStripMenuItem.Text = "Увеличить писюн";
            this.увеличитьПисюнToolStripMenuItem.Click += new System.EventHandler(this.увеличитьПисюнToolStripMenuItem_Click);
            // 
            // autButtonsTableLayoutPanel
            // 
            this.autButtonsTableLayoutPanel.ColumnCount = 2;
            this.autButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.autButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.autButtonsTableLayoutPanel.Controls.Add(this.button_login, 0, 0);
            this.autButtonsTableLayoutPanel.Controls.Add(this.link_of_registration, 1, 0);
            this.autButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 80);
            this.autButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.autButtonsTableLayoutPanel.Name = "autButtonsTableLayoutPanel";
            this.autButtonsTableLayoutPanel.RowCount = 1;
            this.autButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.autButtonsTableLayoutPanel.Size = new System.Drawing.Size(226, 34);
            this.autButtonsTableLayoutPanel.TabIndex = 14;
            // 
            // button_login
            // 
            this.button_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_login.Location = new System.Drawing.Point(0, 0);
            this.button_login.Margin = new System.Windows.Forms.Padding(0);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(113, 34);
            this.button_login.TabIndex = 11;
            this.button_login.Text = "Войти";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            this.button_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_login_KeyDown);
            // 
            // link_of_registration
            // 
            this.link_of_registration.AutoSize = true;
            this.link_of_registration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_of_registration.Location = new System.Drawing.Point(113, 0);
            this.link_of_registration.Margin = new System.Windows.Forms.Padding(0);
            this.link_of_registration.Name = "link_of_registration";
            this.link_of_registration.Size = new System.Drawing.Size(113, 34);
            this.link_of_registration.TabIndex = 6;
            this.link_of_registration.TabStop = true;
            this.link_of_registration.Text = "Регистрация";
            this.link_of_registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "нет",
            "просмотры(по возрастанию)",
            "просмотры(по убыванию)",
            "рейтинг(по возрастанию)",
            "рейтинг(по убыванию)",
            "лайки(по возрастанию)",
            "лайки(по убыванию)"});
            this.comboBox1.Location = new System.Drawing.Point(229, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // Right_panel
            // 
            this.Right_panel.Controls.Add(this.label_Author_header);
            this.Right_panel.Controls.Add(this.lable_name_of_polzovatel);
            this.Right_panel.Controls.Add(this.categories_linklabel);
            this.Right_panel.Controls.Add(this.label_author);
            this.Right_panel.Controls.Add(this.label_cats_header);
            this.Right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_panel.Location = new System.Drawing.Point(558, 0);
            this.Right_panel.Name = "Right_panel";
            this.Right_panel.Size = new System.Drawing.Size(190, 579);
            this.Right_panel.TabIndex = 5;
            this.Right_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Right_panel_Paint);
            // 
            // label_Author_header
            // 
            this.label_Author_header.AutoSize = true;
            this.label_Author_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Author_header.Location = new System.Drawing.Point(2, 38);
            this.label_Author_header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Author_header.Name = "label_Author_header";
            this.label_Author_header.Size = new System.Drawing.Size(180, 20);
            this.label_Author_header.TabIndex = 8;
            this.label_Author_header.Text = "Популярные авторы";
            // 
            // lable_name_of_polzovatel
            // 
            this.lable_name_of_polzovatel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable_name_of_polzovatel.Location = new System.Drawing.Point(0, 0);
            this.lable_name_of_polzovatel.Name = "lable_name_of_polzovatel";
            this.lable_name_of_polzovatel.Size = new System.Drawing.Size(190, 23);
            this.lable_name_of_polzovatel.TabIndex = 6;
            this.lable_name_of_polzovatel.Text = "Имя пользователя";
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Location = new System.Drawing.Point(3, 138);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(66, 13);
            this.label_author.TabIndex = 2;
            this.label_author.Text = "Все авторы";
            this.label_author.Click += new System.EventHandler(this.label_author_Click);
            // 
            // label_cats_header
            // 
            this.label_cats_header.AutoSize = true;
            this.label_cats_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cats_header.Location = new System.Drawing.Point(8, 179);
            this.label_cats_header.Name = "label_cats_header";
            this.label_cats_header.Size = new System.Drawing.Size(98, 20);
            this.label_cats_header.TabIndex = 6;
            this.label_cats_header.Text = "Категории";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Шрифты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add_reklama
            // 
            this.button_add_reklama.Location = new System.Drawing.Point(3, 3);
            this.button_add_reklama.Name = "button_add_reklama";
            this.button_add_reklama.Size = new System.Drawing.Size(184, 42);
            this.button_add_reklama.TabIndex = 5;
            this.button_add_reklama.Text = "Предложить рекламу";
            this.button_add_reklama.UseVisualStyleBackColor = true;
            this.button_add_reklama.Click += new System.EventHandler(this.button_add_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_add_reklama, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 479);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 100);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // Centr_panel
            // 
            this.Centr_panel.AutoScroll = true;
            this.Centr_panel.Controls.Add(this.dalee);
            this.Centr_panel.Location = new System.Drawing.Point(232, 81);
            this.Centr_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Centr_panel.Name = "Centr_panel";
            this.Centr_panel.Size = new System.Drawing.Size(323, 498);
            this.Centr_panel.TabIndex = 6;
            this.Centr_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Centr_panel_Paint);
            // 
            // dalee
            // 
            this.dalee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dalee.Location = new System.Drawing.Point(0, 475);
            this.dalee.Name = "dalee";
            this.dalee.Size = new System.Drawing.Size(323, 23);
            this.dalee.TabIndex = 1;
            this.dalee.Text = "+ 3 статьи";
            this.dalee.UseVisualStyleBackColor = true;
            this.dalee.Click += new System.EventHandler(this.dalee_Click);
            // 
            // popularArticlesLabel
            // 
            this.popularArticlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularArticlesLabel.Location = new System.Drawing.Point(231, 50);
            this.popularArticlesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popularArticlesLabel.Name = "popularArticlesLabel";
            this.popularArticlesLabel.Size = new System.Drawing.Size(314, 31);
            this.popularArticlesLabel.TabIndex = 0;
            this.popularArticlesLabel.Text = "Популярные статьи";
            this.popularArticlesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(229, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(205, 20);
            this.textBox_search.TabIndex = 7;
            this.textBox_search.Text = "Поиск";
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // GhostMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.popularArticlesLabel);
            this.Controls.Add(this.Left_panel);
            this.Controls.Add(this.butto_search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Right_panel);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.Centr_panel);
            this.Name = "GhostMainForm";
            this.Text = "Онлайн-газета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GhostMainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Left_panel.ResumeLayout(false);
            this.reclamaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reclama3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reclama2)).EndInit();
            this.adminPpanel.ResumeLayout(false);
            this.authorizationTableLayoutPanel.ResumeLayout(false);
            this.authorizationTableLayoutPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.autButtonsTableLayoutPanel.ResumeLayout(false);
            this.autButtonsTableLayoutPanel.PerformLayout();
            this.Right_panel.ResumeLayout(false);
            this.Right_panel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Centr_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
      
        #endregion

        private System.Windows.Forms.Button butto_search;
        private System.Windows.Forms.PictureBox reclama;
        private System.Windows.Forms.PictureBox reclama2;
        private System.Windows.Forms.PictureBox reclama3;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Panel Right_panel;
        private System.Windows.Forms.Panel Centr_panel;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.LinkLabel categories_linklabel;
        public System.Windows.Forms.LinkLabel link_of_registration;
        private System.Windows.Forms.Button button_add_reklama;
        private System.Windows.Forms.TableLayoutPanel authorizationTableLayoutPanel;
        private System.Windows.Forms.Label label_of_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label popularArticlesLabel;
        private System.Windows.Forms.Label lable_name_of_polzovatel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button dalee;
        private System.Windows.Forms.Label label_cats_header;
        private System.Windows.Forms.Label label_Author_header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AdmButton;
        private System.Windows.Forms.Button AutButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem увеличитьПисюнToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel reclamaPanel;
        private System.Windows.Forms.Panel adminPpanel;
        private System.Windows.Forms.TableLayoutPanel autButtonsTableLayoutPanel;
    }
}