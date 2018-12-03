namespace WindowsFormsApplication4
{
    partial class StastisticsForm
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
            this.name_stiatii = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Views = new System.Windows.Forms.Label();
            this.DisLikes = new System.Windows.Forms.Label();
            this.Likes = new System.Windows.Forms.Label();
            this.ViewsCount = new System.Windows.Forms.Label();
            this.LikesCount = new System.Windows.Forms.Label();
            this.DisLikesCount = new System.Windows.Forms.Label();
            this.list_of_author = new System.Windows.Forms.ComboBox();
            this.authorsDGV = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_stiatii
            // 
            this.name_stiatii.AutoSize = true;
            this.name_stiatii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_stiatii.Location = new System.Drawing.Point(482, 231);
            this.name_stiatii.Name = "name_stiatii";
            this.name_stiatii.Size = new System.Drawing.Size(472, 39);
            this.name_stiatii.TabIndex = 12;
            this.name_stiatii.Text = "hjkhjkhgjk";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 889F));
            this.tableLayoutPanel1.Controls.Add(this.Views, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DisLikes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Likes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ViewsCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LikesCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DisLikesCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.list_of_author, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.name_stiatii, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 271);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Views
            // 
            this.Views.AutoSize = true;
            this.Views.BackColor = System.Drawing.SystemColors.Control;
            this.Views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Views.Location = new System.Drawing.Point(4, 1);
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(471, 187);
            this.Views.TabIndex = 0;
            this.Views.Text = "Просмотры";
            this.Views.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisLikes
            // 
            this.DisLikes.AutoSize = true;
            this.DisLikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisLikes.Location = new System.Drawing.Point(4, 210);
            this.DisLikes.Name = "DisLikes";
            this.DisLikes.Size = new System.Drawing.Size(471, 20);
            this.DisLikes.TabIndex = 6;
            this.DisLikes.Text = "Дизлайки";
            this.DisLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Likes
            // 
            this.Likes.AutoSize = true;
            this.Likes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Likes.Location = new System.Drawing.Point(4, 189);
            this.Likes.Name = "Likes";
            this.Likes.Size = new System.Drawing.Size(471, 20);
            this.Likes.TabIndex = 7;
            this.Likes.Text = "Лайки";
            this.Likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewsCount
            // 
            this.ViewsCount.AutoSize = true;
            this.ViewsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsCount.Location = new System.Drawing.Point(482, 1);
            this.ViewsCount.Name = "ViewsCount";
            this.ViewsCount.Size = new System.Drawing.Size(472, 187);
            this.ViewsCount.TabIndex = 8;
            this.ViewsCount.Text = "0";
            this.ViewsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LikesCount
            // 
            this.LikesCount.AutoSize = true;
            this.LikesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LikesCount.Location = new System.Drawing.Point(482, 189);
            this.LikesCount.Name = "LikesCount";
            this.LikesCount.Size = new System.Drawing.Size(472, 20);
            this.LikesCount.TabIndex = 9;
            this.LikesCount.Text = "0";
            this.LikesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisLikesCount
            // 
            this.DisLikesCount.AutoSize = true;
            this.DisLikesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisLikesCount.Location = new System.Drawing.Point(482, 210);
            this.DisLikesCount.Name = "DisLikesCount";
            this.DisLikesCount.Size = new System.Drawing.Size(472, 20);
            this.DisLikesCount.TabIndex = 10;
            this.DisLikesCount.Text = "0";
            this.DisLikesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_of_author
            // 
            this.list_of_author.FormattingEnabled = true;
            this.list_of_author.Location = new System.Drawing.Point(4, 234);
            this.list_of_author.Name = "list_of_author";
            this.list_of_author.Size = new System.Drawing.Size(34, 21);
            this.list_of_author.TabIndex = 11;
            this.list_of_author.SelectedIndexChanged += new System.EventHandler(this.list_of_author_SelectedIndexChanged);
            // 
            // authorsDGV
            // 
            this.authorsDGV.AllowUserToAddRows = false;
            this.authorsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.authorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.authorsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authorsDGV.Location = new System.Drawing.Point(3, 3);
            this.authorsDGV.Name = "authorsDGV";
            this.authorsDGV.RowHeadersVisible = false;
            this.authorsDGV.Size = new System.Drawing.Size(958, 271);
            this.authorsDGV.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 303);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.authorsDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Автор";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Просмотры";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Лайки";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дизлайки";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // StastisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "StastisticsForm";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StastisticsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Views;
        private System.Windows.Forms.Label DisLikes;
        private System.Windows.Forms.Label Likes;
        private System.Windows.Forms.Label ViewsCount;
        private System.Windows.Forms.Label LikesCount;
        private System.Windows.Forms.Label DisLikesCount;
        private System.Windows.Forms.ComboBox list_of_author;
        private System.Windows.Forms.Label name_stiatii;
        private System.Windows.Forms.DataGridView authorsDGV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;

    }
}