namespace WindowsFormsApplication4
{
    partial class Dostalo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dethauthor = new System.Windows.Forms.Button();
            this.dethArticle = new System.Windows.Forms.Button();
            this.Hohlov_is_dead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // dethauthor
            // 
            this.dethauthor.Location = new System.Drawing.Point(12, 26);
            this.dethauthor.Name = "dethauthor";
            this.dethauthor.Size = new System.Drawing.Size(108, 292);
            this.dethauthor.TabIndex = 1;
            this.dethauthor.Text = "Ограбь автора";
            this.dethauthor.UseVisualStyleBackColor = true;
            this.dethauthor.Click += new System.EventHandler(this.dethauthor_Click_1);
            // 
            // dethArticle
            // 
            this.dethArticle.Location = new System.Drawing.Point(126, 26);
            this.dethArticle.Name = "dethArticle";
            this.dethArticle.Size = new System.Drawing.Size(87, 292);
            this.dethArticle.TabIndex = 2;
            this.dethArticle.Text = "Удоли статью";
            this.dethArticle.UseVisualStyleBackColor = true;
            this.dethArticle.Click += new System.EventHandler(this.dethArticle_Click);
            // 
            // Hohlov_is_dead
            // 
            this.Hohlov_is_dead.Location = new System.Drawing.Point(219, 25);
            this.Hohlov_is_dead.Name = "Hohlov_is_dead";
            this.Hohlov_is_dead.Size = new System.Drawing.Size(128, 292);
            this.Hohlov_is_dead.TabIndex = 3;
            this.Hohlov_is_dead.Text = "Естественный отбор";
            this.Hohlov_is_dead.UseVisualStyleBackColor = true;
            this.Hohlov_is_dead.Click += new System.EventHandler(this.Hohlov_is_dead_Click);
            // 
            // Dostalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.Hohlov_is_dead);
            this.Controls.Add(this.dethArticle);
            this.Controls.Add(this.dethauthor);
            this.Controls.Add(this.label1);
            this.Name = "Dostalo";
            this.Text = "Достало сало";
            this.Load += new System.EventHandler(this.Dostalo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dethauthor;
        private System.Windows.Forms.Button dethArticle;
        private System.Windows.Forms.Button Hohlov_is_dead;
    }
}