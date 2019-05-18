
namespace OnlineMag
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
            this.butto_search = new System.Windows.Forms.Button();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.reclamaPanel = new System.Windows.Forms.Panel();
            this.adminPpanel = new System.Windows.Forms.Panel();
            this.AutButton = new System.Windows.Forms.Button();
            this.AdmButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.увеличитьПисюнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Right_panel = new System.Windows.Forms.Panel();
            this.RightSubPanel = new System.Windows.Forms.Panel();
            this.RightTopPanel = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lable_name_of_polzovatel = new System.Windows.Forms.Label();
            this.linkLabel_collections = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_add_reklama = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Centr_panel = new System.Windows.Forms.Panel();
            this.dalee = new System.Windows.Forms.Button();
            this.popularArticlesLabel = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.UCContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьПараметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.докТопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticlecontextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.LabelContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Left_panel.SuspendLayout();
            this.adminPpanel.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Right_panel.SuspendLayout();
            this.RightTopPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Centr_panel.SuspendLayout();
            this.UCContextMenuStrip.SuspendLayout();
            this.LabelContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butto_search
            // 
            this.butto_search.Location = new System.Drawing.Point(585, 4);
            this.butto_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butto_search.Name = "butto_search";
            this.butto_search.Size = new System.Drawing.Size(103, 54);
            this.butto_search.TabIndex = 0;
            this.butto_search.Text = "Найти";
            this.butto_search.UseVisualStyleBackColor = true;
            this.butto_search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Left_panel
            // 
            this.Left_panel.Controls.Add(this.reclamaPanel);
            this.Left_panel.Controls.Add(this.adminPpanel);
            this.Left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_panel.Location = new System.Drawing.Point(0, 0);
            this.Left_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(301, 713);
            this.Left_panel.TabIndex = 4;
            // 
            // reclamaPanel
            // 
            this.reclamaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reclamaPanel.Location = new System.Drawing.Point(0, 0);
            this.reclamaPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reclamaPanel.Name = "reclamaPanel";
            this.reclamaPanel.Size = new System.Drawing.Size(301, 679);
            this.reclamaPanel.TabIndex = 16;
            this.reclamaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reclamaPanel_Paint);
            this.reclamaPanel.MouseLeave += new System.EventHandler(this.reclamaPanel_MouseLeave);
            // 
            // adminPpanel
            // 
            this.adminPpanel.Controls.Add(this.AutButton);
            this.adminPpanel.Controls.Add(this.AdmButton);
            this.adminPpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminPpanel.Location = new System.Drawing.Point(0, 679);
            this.adminPpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminPpanel.Name = "adminPpanel";
            this.adminPpanel.Size = new System.Drawing.Size(301, 34);
            this.adminPpanel.TabIndex = 0;
            // 
            // AutButton
            // 
            this.AutButton.Location = new System.Drawing.Point(0, 5);
            this.AutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutButton.Name = "AutButton";
            this.AutButton.Size = new System.Drawing.Size(133, 23);
            this.AutButton.TabIndex = 8;
            this.AutButton.Text = "Кабинет автора";
            this.AutButton.UseVisualStyleBackColor = true;
            this.AutButton.Visible = false;
            this.AutButton.Click += new System.EventHandler(this.AutButton_Click);
            // 
            // AdmButton
            // 
            this.AdmButton.Location = new System.Drawing.Point(152, 5);
            this.AdmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmButton.Name = "AdmButton";
            this.AdmButton.Size = new System.Drawing.Size(149, 23);
            this.AdmButton.TabIndex = 16;
            this.AdmButton.Text = "Кабинет админа";
            this.AdmButton.UseVisualStyleBackColor = true;
            this.AdmButton.Click += new System.EventHandler(this.AdmButton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(129, 28);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьПисюнToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 28);
            // 
            // увеличитьПисюнToolStripMenuItem
            // 
            this.увеличитьПисюнToolStripMenuItem.Name = "увеличитьПисюнToolStripMenuItem";
            this.увеличитьПисюнToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.увеличитьПисюнToolStripMenuItem.Text = "Показать/Скрыть пароль";
            this.увеличитьПисюнToolStripMenuItem.Click += new System.EventHandler(this.showPassToolStripMenuItem_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(305, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Сортировка статей";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Right_panel
            // 
            this.Right_panel.Controls.Add(this.RightSubPanel);
            this.Right_panel.Controls.Add(this.RightTopPanel);
            this.Right_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_panel.Location = new System.Drawing.Point(744, 0);
            this.Right_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Right_panel.Name = "Right_panel";
            this.Right_panel.Size = new System.Drawing.Size(253, 713);
            this.Right_panel.TabIndex = 5;
            // 
            // RightSubPanel
            // 
            this.RightSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSubPanel.Location = new System.Drawing.Point(0, 60);
            this.RightSubPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightSubPanel.Name = "RightSubPanel";
            this.RightSubPanel.Size = new System.Drawing.Size(253, 653);
            this.RightSubPanel.TabIndex = 1002;
            // 
            // RightTopPanel
            // 
            this.RightTopPanel.Controls.Add(this.comboBox2);
            this.RightTopPanel.Controls.Add(this.lable_name_of_polzovatel);
            this.RightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.RightTopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Size = new System.Drawing.Size(253, 60);
            this.RightTopPanel.TabIndex = 1001;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "нет",
            "просмотры(по возрастанию)",
            "просмотры(по убыванию)",
            "рейтинг(по возрастанию)",
            "рейтинг(по убыванию)",
            "лайки(по возрастанию)",
            "лайки(по убыванию)",
            "кол-во статей(по возрастанию)",
            "кол-во статей(по убыванию)"});
            this.comboBox2.Location = new System.Drawing.Point(0, 28);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 24);
            this.comboBox2.TabIndex = 1000;
            this.comboBox2.Text = "Сортировка авторов";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.Search_Click);
            // 
            // lable_name_of_polzovatel
            // 
            this.lable_name_of_polzovatel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable_name_of_polzovatel.Location = new System.Drawing.Point(0, 0);
            this.lable_name_of_polzovatel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable_name_of_polzovatel.Name = "lable_name_of_polzovatel";
            this.lable_name_of_polzovatel.Size = new System.Drawing.Size(253, 28);
            this.lable_name_of_polzovatel.TabIndex = 6;
            this.lable_name_of_polzovatel.Text = "Имя пользователя";
            // 
            // linkLabel_collections
            // 
            this.linkLabel_collections.AutoSize = true;
            this.linkLabel_collections.Location = new System.Drawing.Point(10, 420);
            this.linkLabel_collections.Name = "linkLabel_collections";
            this.linkLabel_collections.Size = new System.Drawing.Size(77, 13);
            this.linkLabel_collections.TabIndex = 10;
            this.linkLabel_collections.TabStop = true;
            this.linkLabel_collections.Text = "Все подборки";
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
            this.Centr_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Centr_panel.Controls.Add(this.dalee);
            this.Centr_panel.Location = new System.Drawing.Point(309, 100);
            this.Centr_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Centr_panel.Name = "Centr_panel";
            this.Centr_panel.Size = new System.Drawing.Size(431, 613);
            this.Centr_panel.TabIndex = 6;
            // 
            // dalee
            // 
            this.dalee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dalee.Location = new System.Drawing.Point(0, 585);
            this.dalee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dalee.Name = "dalee";
            this.dalee.Size = new System.Drawing.Size(431, 28);
            this.dalee.TabIndex = 1;
            this.dalee.Text = "+ 3 статьи";
            this.dalee.UseVisualStyleBackColor = true;
            this.dalee.Click += new System.EventHandler(this.dalee_Click);
            // 
            // popularArticlesLabel
            // 
            this.popularArticlesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popularArticlesLabel.Location = new System.Drawing.Point(308, 62);
            this.popularArticlesLabel.Name = "popularArticlesLabel";
            this.popularArticlesLabel.Size = new System.Drawing.Size(419, 38);
            this.popularArticlesLabel.TabIndex = 0;
            this.popularArticlesLabel.Text = "Популярные статьи";
            this.popularArticlesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(305, 4);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(272, 22);
            this.textBox_search.TabIndex = 7;
            this.textBox_search.Text = "Поиск";
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            this.textBox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_search_KeyDown);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // UCContextMenuStrip
            // 
            this.UCContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.UCContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.настроитьПараметрыToolStripMenuItem,
            this.докТопToolStripMenuItem,
            this.dockRightToolStripMenuItem,
            this.dockLeftToolStripMenuItem,
            this.dockFillToolStripMenuItem,
            this.dockBottomToolStripMenuItem,
            this.dockNoneToolStripMenuItem});
            this.UCContextMenuStrip.Name = "DeletecontextMenuStrip1";
            this.UCContextMenuStrip.Size = new System.Drawing.Size(235, 196);
            this.UCContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.UCContextMenuStrip_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // настроитьПараметрыToolStripMenuItem
            // 
            this.настроитьПараметрыToolStripMenuItem.Name = "настроитьПараметрыToolStripMenuItem";
            this.настроитьПараметрыToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.настроитьПараметрыToolStripMenuItem.Text = "Настроить параметры";
            this.настроитьПараметрыToolStripMenuItem.Click += new System.EventHandler(this.настроитьПараметрыToolStripMenuItem_Click);
            // 
            // докТопToolStripMenuItem
            // 
            this.докТопToolStripMenuItem.Name = "докТопToolStripMenuItem";
            this.докТопToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.докТопToolStripMenuItem.Text = "Dock.Top";
            this.докТопToolStripMenuItem.Click += new System.EventHandler(this.dockClick);
            // 
            // dockRightToolStripMenuItem
            // 
            this.dockRightToolStripMenuItem.Name = "dockRightToolStripMenuItem";
            this.dockRightToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.dockRightToolStripMenuItem.Text = "Dock.Right";
            this.dockRightToolStripMenuItem.Click += new System.EventHandler(this.dockClick);
            // 
            // dockLeftToolStripMenuItem
            // 
            this.dockLeftToolStripMenuItem.Name = "dockLeftToolStripMenuItem";
            this.dockLeftToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.dockLeftToolStripMenuItem.Text = "Dock.Left";
            this.dockLeftToolStripMenuItem.Click += new System.EventHandler(this.dockClick);
            // 
            // dockFillToolStripMenuItem
            // 
            this.dockFillToolStripMenuItem.Name = "dockFillToolStripMenuItem";
            this.dockFillToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.dockFillToolStripMenuItem.Text = "Dock.Fill";
            this.dockFillToolStripMenuItem.Click += new System.EventHandler(this.dockClick);
            // 
            // dockBottomToolStripMenuItem
            // 
            this.dockBottomToolStripMenuItem.Name = "dockBottomToolStripMenuItem";
            this.dockBottomToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.dockBottomToolStripMenuItem.Text = "Dock.Bottom";
            this.dockBottomToolStripMenuItem.Click += new System.EventHandler(this.dockClick);
            // 
            // dockNoneToolStripMenuItem
            // 
            this.dockNoneToolStripMenuItem.Name = "dockNoneToolStripMenuItem";
            this.dockNoneToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.dockNoneToolStripMenuItem.Text = "Dock.None";
            this.dockNoneToolStripMenuItem.Click += new System.EventHandler(this.dockClick);
            // 
            // ArticlecontextMenuStrip1
            // 
            this.ArticlecontextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ArticlecontextMenuStrip1.Name = "ArticlecontextMenuStrip1";
            this.ArticlecontextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Изменить стиль";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LabelContextMenuStrip1
            // 
            this.LabelContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LabelContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem});
            this.LabelContextMenuStrip1.Name = "LabelContextMenuStrip1";
            this.LabelContextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьToolStripMenuItem_Click);
            // 
            // GhostMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 713);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.popularArticlesLabel);
            this.Controls.Add(this.Left_panel);
            this.Controls.Add(this.butto_search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Right_panel);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.Centr_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(794, 728);
            this.Name = "GhostMainForm";
            this.Text = "Онлайн-газета";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GhostMainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.GhostMainForm_Resize);
            this.Left_panel.ResumeLayout(false);
            this.adminPpanel.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Right_panel.ResumeLayout(false);
            this.RightTopPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Centr_panel.ResumeLayout(false);
            this.UCContextMenuStrip.ResumeLayout(false);
            this.LabelContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button butto_search;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.Panel Right_panel;
        private System.Windows.Forms.Panel Centr_panel;
        public System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_add_reklama;
        private System.Windows.Forms.Label popularArticlesLabel;
        private System.Windows.Forms.Label lable_name_of_polzovatel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.LinkLabel linkLabel_collections;
        private System.Windows.Forms.Button dalee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AdmButton;
        private System.Windows.Forms.Button AutButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem увеличитьПисюнToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel reclamaPanel;
        private System.Windows.Forms.Panel adminPpanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Panel RightSubPanel;
        private System.Windows.Forms.Panel RightTopPanel;
        private System.Windows.Forms.ContextMenuStrip UCContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьПараметрыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ArticlecontextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem докТопToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockNoneToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip LabelContextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
    }
}