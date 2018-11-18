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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_stiatii
            // 
            this.name_stiatii.AutoSize = true;
            this.name_stiatii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_stiatii.Location = new System.Drawing.Point(194, 322);
            this.name_stiatii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_stiatii.Name = "name_stiatii";
            this.name_stiatii.Size = new System.Drawing.Size(180, 50);
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
            this.tableLayoutPanel1.Controls.Add(this.Views, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DisLikes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Likes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ViewsCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LikesCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DisLikesCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.list_of_author, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.name_stiatii, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 373);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Views
            // 
            this.Views.AutoSize = true;
            this.Views.BackColor = System.Drawing.SystemColors.Control;
            this.Views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Views.Location = new System.Drawing.Point(5, 1);
            this.Views.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(180, 106);
            this.Views.TabIndex = 0;
            this.Views.Text = "Просмотры";
            this.Views.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisLikes
            // 
            this.DisLikes.AutoSize = true;
            this.DisLikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisLikes.Location = new System.Drawing.Point(5, 215);
            this.DisLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisLikes.Name = "DisLikes";
            this.DisLikes.Size = new System.Drawing.Size(180, 106);
            this.DisLikes.TabIndex = 6;
            this.DisLikes.Text = "Дизлайки";
            this.DisLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Likes
            // 
            this.Likes.AutoSize = true;
            this.Likes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Likes.Location = new System.Drawing.Point(5, 108);
            this.Likes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Likes.Name = "Likes";
            this.Likes.Size = new System.Drawing.Size(180, 106);
            this.Likes.TabIndex = 7;
            this.Likes.Text = "Лайки";
            this.Likes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewsCount
            // 
            this.ViewsCount.AutoSize = true;
            this.ViewsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsCount.Location = new System.Drawing.Point(194, 1);
            this.ViewsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewsCount.Name = "ViewsCount";
            this.ViewsCount.Size = new System.Drawing.Size(180, 106);
            this.ViewsCount.TabIndex = 8;
            this.ViewsCount.Text = "0";
            this.ViewsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LikesCount
            // 
            this.LikesCount.AutoSize = true;
            this.LikesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LikesCount.Location = new System.Drawing.Point(194, 108);
            this.LikesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LikesCount.Name = "LikesCount";
            this.LikesCount.Size = new System.Drawing.Size(180, 106);
            this.LikesCount.TabIndex = 9;
            this.LikesCount.Text = "0";
            this.LikesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisLikesCount
            // 
            this.DisLikesCount.AutoSize = true;
            this.DisLikesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisLikesCount.Location = new System.Drawing.Point(194, 215);
            this.DisLikesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DisLikesCount.Name = "DisLikesCount";
            this.DisLikesCount.Size = new System.Drawing.Size(180, 106);
            this.DisLikesCount.TabIndex = 10;
            this.DisLikesCount.Text = "0";
            this.DisLikesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_of_author
            // 
            this.list_of_author.FormattingEnabled = true;
            this.list_of_author.Location = new System.Drawing.Point(5, 326);
            this.list_of_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_of_author.Name = "list_of_author";
            this.list_of_author.Size = new System.Drawing.Size(160, 24);
            this.list_of_author.TabIndex = 11;
            this.list_of_author.SelectedIndexChanged += new System.EventHandler(this.list_of_author_SelectedIndexChanged);
            // 
            // StastisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StastisticsForm";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StastisticsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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

    }
}