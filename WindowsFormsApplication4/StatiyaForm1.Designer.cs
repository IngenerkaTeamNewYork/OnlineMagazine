namespace WindowsFormsApplication4
{
    partial class StatiyaForm1
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
            this.Kategoriatext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelreklama = new System.Windows.Forms.Label();
            this.artTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Stattext = new System.Windows.Forms.TextBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Authortext = new System.Windows.Forms.Label();
            this.Maintext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.artTableLayoutPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kategoriatext
            // 
            this.Kategoriatext.AutoSize = true;
            this.Kategoriatext.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kategoriatext.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategoriatext.Location = new System.Drawing.Point(0, 0);
            this.Kategoriatext.MaximumSize = new System.Drawing.Size(100, 30);
            this.Kategoriatext.MinimumSize = new System.Drawing.Size(70, 30);
            this.Kategoriatext.Name = "Kategoriatext";
            this.Kategoriatext.Size = new System.Drawing.Size(99, 30);
            this.Kategoriatext.TabIndex = 1;
            this.Kategoriatext.Text = "Kategoriatext";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.09091F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.90909F));
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.artTableLayoutPanel, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(550, 633);
            this.mainTableLayoutPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.labelreklama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 627);
            this.panel1.TabIndex = 0;
            // 
            // labelreklama
            // 
            this.labelreklama.AutoSize = true;
            this.labelreklama.Location = new System.Drawing.Point(-3, 196);
            this.labelreklama.Name = "labelreklama";
            this.labelreklama.Size = new System.Drawing.Size(146, 13);
            this.labelreklama.TabIndex = 0;
            this.labelreklama.Text = "Сдеся Будет ваша реклама";
            // 
            // artTableLayoutPanel
            // 
            this.artTableLayoutPanel.ColumnCount = 1;
            this.artTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.artTableLayoutPanel.Controls.Add(this.Stattext, 0, 2);
            this.artTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 1);
            this.artTableLayoutPanel.Controls.Add(this.HeaderPanel, 0, 0);
            this.artTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artTableLayoutPanel.Location = new System.Drawing.Point(86, 3);
            this.artTableLayoutPanel.Name = "artTableLayoutPanel";
            this.artTableLayoutPanel.RowCount = 3;
            this.artTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.artTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.artTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.artTableLayoutPanel.Size = new System.Drawing.Size(461, 627);
            this.artTableLayoutPanel.TabIndex = 1;
            // 
            // Stattext
            // 
            this.Stattext.BackColor = System.Drawing.SystemColors.Control;
            this.Stattext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stattext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stattext.Enabled = false;
            this.Stattext.Location = new System.Drawing.Point(3, 366);
            this.Stattext.Multiline = true;
            this.Stattext.Name = "Stattext";
            this.Stattext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Stattext.Size = new System.Drawing.Size(455, 258);
            this.Stattext.TabIndex = 7;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.Authortext);
            this.HeaderPanel.Controls.Add(this.Maintext);
            this.HeaderPanel.Controls.Add(this.Kategoriatext);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(455, 94);
            this.HeaderPanel.TabIndex = 5;
            // 
            // Authortext
            // 
            this.Authortext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Authortext.AutoSize = true;
            this.Authortext.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold);
            this.Authortext.Location = new System.Drawing.Point(200, 0);
            this.Authortext.Name = "Authortext";
            this.Authortext.Size = new System.Drawing.Size(86, 19);
            this.Authortext.TabIndex = 3;
            this.Authortext.Text = "Authortext";
            // 
            // Maintext
            // 
            this.Maintext.BackColor = System.Drawing.SystemColors.Control;
            this.Maintext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Maintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maintext.Enabled = false;
            this.Maintext.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold);
            this.Maintext.Location = new System.Drawing.Point(0, 30);
            this.Maintext.Multiline = true;
            this.Maintext.Name = "Maintext";
            this.Maintext.Size = new System.Drawing.Size(455, 64);
            this.Maintext.TabIndex = 2;
            // 
            // StatiyaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 633);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "StatiyaForm1";
            this.Text = "Статья";
            this.Load += new System.EventHandler(this.StatiyaForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.artTableLayoutPanel.ResumeLayout(false);
            this.artTableLayoutPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Kategoriatext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel artTableLayoutPanel;
        private System.Windows.Forms.TextBox Stattext;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label labelreklama;
        private System.Windows.Forms.TextBox Maintext;
        private System.Windows.Forms.Label Authortext;
    }
}