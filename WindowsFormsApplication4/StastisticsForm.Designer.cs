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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewsCount = new System.Windows.Forms.Label();
            this.LikesCount = new System.Windows.Forms.Label();
            this.DisLikesCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ViewsCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LikesCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DisLikesCount, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Просмотры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 82);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дизлайки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 82);
            this.label5.TabIndex = 7;
            this.label5.Text = "Лайки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewsCount
            // 
            this.ViewsCount.AutoSize = true;
            this.ViewsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsCount.Location = new System.Drawing.Point(145, 1);
            this.ViewsCount.Name = "ViewsCount";
            this.ViewsCount.Size = new System.Drawing.Size(135, 82);
            this.ViewsCount.TabIndex = 8;
            this.ViewsCount.Text = "0";
            this.ViewsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LikesCount
            // 
            this.LikesCount.AutoSize = true;
            this.LikesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LikesCount.Location = new System.Drawing.Point(145, 84);
            this.LikesCount.Name = "LikesCount";
            this.LikesCount.Size = new System.Drawing.Size(135, 82);
            this.LikesCount.TabIndex = 9;
            this.LikesCount.Text = "0";
            this.LikesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisLikesCount
            // 
            this.DisLikesCount.AutoSize = true;
            this.DisLikesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisLikesCount.Location = new System.Drawing.Point(145, 167);
            this.DisLikesCount.Name = "DisLikesCount";
            this.DisLikesCount.Size = new System.Drawing.Size(135, 82);
            this.DisLikesCount.TabIndex = 10;
            this.DisLikesCount.Text = "0";
            this.DisLikesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StastisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StastisticsForm";
            this.Text = "StastisticsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ViewsCount;
        private System.Windows.Forms.Label LikesCount;
        private System.Windows.Forms.Label DisLikesCount;

    }
}