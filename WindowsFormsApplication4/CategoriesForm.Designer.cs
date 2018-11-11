namespace WindowsFormsApplication4
{
    partial class CategoriesForm
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.articlesPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.catsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.articlesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.catsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(3, 342);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 32);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(84, 345);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 6;
            this.textBox_name.Visible = false;
            this.textBox_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_name_KeyDown);
            // 
            // articlesPanel
            // 
            this.articlesPanel.AutoScroll = true;
            this.articlesPanel.Controls.Add(this.label3);
            this.articlesPanel.Controls.Add(this.pictureBox1);
            this.articlesPanel.Controls.Add(this.label1);
            this.articlesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.articlesPanel.Location = new System.Drawing.Point(263, 0);
            this.articlesPanel.Name = "articlesPanel";
            this.articlesPanel.Size = new System.Drawing.Size(650, 377);
            this.articlesPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(406, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // catsPanel
            // 
            this.catsPanel.AutoScroll = true;
            this.catsPanel.Controls.Add(this.label2);
            this.catsPanel.Controls.Add(this.button_add);
            this.catsPanel.Controls.Add(this.textBox_name);
            this.catsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.catsPanel.Location = new System.Drawing.Point(0, 0);
            this.catsPanel.Name = "catsPanel";
            this.catsPanel.Size = new System.Drawing.Size(257, 377);
            this.catsPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статьи в этой категории";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 377);
            this.Controls.Add(this.catsPanel);
            this.Controls.Add(this.articlesPanel);
            this.Name = "CategoriesForm";
            this.Text = "Категории";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.articlesPanel.ResumeLayout(false);
            this.articlesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.catsPanel.ResumeLayout(false);
            this.catsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        public System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Panel articlesPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel catsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}