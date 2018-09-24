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
            this.Maintext = new System.Windows.Forms.Label();
            this.Kategoriatext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTextLabel = new System.Windows.Forms.Label();
            this.Stattext = new System.Windows.Forms.TextBox();
            this.Name_kategor_decoratrion = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Maintext
            // 
            this.Maintext.AutoSize = true;
            this.Maintext.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintext.Location = new System.Drawing.Point(172, 26);
            this.Maintext.MaximumSize = new System.Drawing.Size(500, 150);
            this.Maintext.MinimumSize = new System.Drawing.Size(50, 20);
            this.Maintext.Name = "Maintext";
            this.Maintext.Size = new System.Drawing.Size(115, 28);
            this.Maintext.TabIndex = 0;
            this.Maintext.Text = "Maintext";
            this.Maintext.Click += new System.EventHandler(this.Maintext_Click);
            // 
            // Kategoriatext
            // 
            this.Kategoriatext.AutoSize = true;
            this.Kategoriatext.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategoriatext.Location = new System.Drawing.Point(376, 9);
            this.Kategoriatext.MaximumSize = new System.Drawing.Size(100, 30);
            this.Kategoriatext.MinimumSize = new System.Drawing.Size(70, 30);
            this.Kategoriatext.Name = "Kategoriatext";
            this.Kategoriatext.Size = new System.Drawing.Size(99, 30);
            this.Kategoriatext.TabIndex = 1;
            this.Kategoriatext.Text = "Kategoriatext";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // mainTextLabel
            // 
            this.mainTextLabel.AutoSize = true;
            this.mainTextLabel.Location = new System.Drawing.Point(12, 283);
            this.mainTextLabel.Name = "mainTextLabel";
            this.mainTextLabel.Size = new System.Drawing.Size(77, 13);
            this.mainTextLabel.TabIndex = 6;
            this.mainTextLabel.Text = "Текст статьи:";
            // 
            // Stattext
            // 
            this.Stattext.BackColor = System.Drawing.SystemColors.Control;
            this.Stattext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stattext.Enabled = false;
            this.Stattext.Location = new System.Drawing.Point(111, 292);
            this.Stattext.Multiline = true;
            this.Stattext.Name = "Stattext";
            this.Stattext.Size = new System.Drawing.Size(250, 283);
            this.Stattext.TabIndex = 7;
            this.Stattext.TextChanged += new System.EventHandler(this.Stattext_TextChanged);
            // 
            // Name_kategor_decoratrion
            // 
            this.Name_kategor_decoratrion.AutoSize = true;
            this.Name_kategor_decoratrion.Location = new System.Drawing.Point(287, 9);
            this.Name_kategor_decoratrion.MaximumSize = new System.Drawing.Size(70, 10);
            this.Name_kategor_decoratrion.MinimumSize = new System.Drawing.Size(50, 15);
            this.Name_kategor_decoratrion.Name = "Name_kategor_decoratrion";
            this.Name_kategor_decoratrion.Size = new System.Drawing.Size(63, 15);
            this.Name_kategor_decoratrion.TabIndex = 8;
            this.Name_kategor_decoratrion.Text = "Категория:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(433, 72);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 503);
            this.vScrollBar1.TabIndex = 9;
            // 
            // StatiyaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 633);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Name_kategor_decoratrion);
            this.Controls.Add(this.Stattext);
            this.Controls.Add(this.mainTextLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Kategoriatext);
            this.Controls.Add(this.Maintext);
            this.Name = "StatiyaForm1";
            this.Text = "StatiyaForm1";
            this.Load += new System.EventHandler(this.StatiyaForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Maintext;
        private System.Windows.Forms.Label Kategoriatext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainTextLabel;
        private System.Windows.Forms.TextBox Stattext;
        private System.Windows.Forms.Label Name_kategor_decoratrion;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}