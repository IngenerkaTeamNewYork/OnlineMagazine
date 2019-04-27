namespace OnlineMag
{
    partial class ArticlePreviewUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LikeCount = new System.Windows.Forms.Label();
            this.DisLikeCount = new System.Windows.Forms.Label();
            this.LikePB = new System.Windows.Forms.PictureBox();
            this.DisLikePB = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisLikePB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LikeCount
            // 
            this.LikeCount.AutoSize = true;
            this.LikeCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.LikeCount.Location = new System.Drawing.Point(284, 0);
            this.LikeCount.Name = "LikeCount";
            this.LikeCount.Size = new System.Drawing.Size(13, 13);
            this.LikeCount.TabIndex = 2;
            this.LikeCount.Text = "0";
            // 
            // DisLikeCount
            // 
            this.DisLikeCount.AutoSize = true;
            this.DisLikeCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisLikeCount.Location = new System.Drawing.Point(317, 0);
            this.DisLikeCount.Name = "DisLikeCount";
            this.DisLikeCount.Size = new System.Drawing.Size(13, 13);
            this.DisLikeCount.TabIndex = 3;
            this.DisLikeCount.Text = "0";
            // 
            // LikePB
            // 
            this.LikePB.Dock = System.Windows.Forms.DockStyle.Right;
            this.LikePB.Location = new System.Drawing.Point(264, 0);
            this.LikePB.Name = "LikePB";
            this.LikePB.Size = new System.Drawing.Size(20, 34);
            this.LikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LikePB.TabIndex = 4;
            this.LikePB.TabStop = false;
            // 
            // DisLikePB
            // 
            this.DisLikePB.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisLikePB.Location = new System.Drawing.Point(297, 0);
            this.DisLikePB.Name = "DisLikePB";
            this.DisLikePB.Size = new System.Drawing.Size(20, 34);
            this.DisLikePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DisLikePB.TabIndex = 5;
            this.DisLikePB.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LikePB);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.LikeCount);
            this.panel1.Controls.Add(this.DisLikePB);
            this.panel1.Controls.Add(this.DisLikeCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 34);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ArticlePreviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ArticlePreviewUserControl";
            this.Size = new System.Drawing.Size(330, 190);
            this.Load += new System.EventHandler(this.ArticlePreviewUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisLikePB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox LikePB;
        private System.Windows.Forms.PictureBox DisLikePB;
        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LikeCount;
        public System.Windows.Forms.Label DisLikeCount;
        private System.Windows.Forms.Panel panel1;
    }
}
