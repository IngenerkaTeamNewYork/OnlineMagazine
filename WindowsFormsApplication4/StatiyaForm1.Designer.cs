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
            this.Stattext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Maintext
            // 
            this.Maintext.AutoSize = true;
            this.Maintext.Location = new System.Drawing.Point(207, 32);
            this.Maintext.MaximumSize = new System.Drawing.Size(50, 20);
            this.Maintext.Name = "Maintext";
            this.Maintext.Size = new System.Drawing.Size(47, 13);
            this.Maintext.TabIndex = 0;
            this.Maintext.Text = "Maintext";
            this.Maintext.Click += new System.EventHandler(this.Maintext_Click);
            // 
            // Kategoriatext
            // 
            this.Kategoriatext.AutoSize = true;
            this.Kategoriatext.Location = new System.Drawing.Point(350, 9);
            this.Kategoriatext.Name = "Kategoriatext";
            this.Kategoriatext.Size = new System.Drawing.Size(69, 13);
            this.Kategoriatext.TabIndex = 1;
            this.Kategoriatext.Text = "Kategoriatext";
            // 
            // Stattext
            // 
            this.Stattext.AutoSize = true;
            this.Stattext.Location = new System.Drawing.Point(219, 299);
            this.Stattext.Name = "Stattext";
            this.Stattext.Size = new System.Drawing.Size(43, 13);
            this.Stattext.TabIndex = 3;
            this.Stattext.Text = "Stattext";
            // 
            // StatiyaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 633);
            this.Controls.Add(this.Stattext);
            this.Controls.Add(this.Kategoriatext);
            this.Controls.Add(this.Maintext);
            this.Name = "StatiyaForm1";
            this.Text = "StatiyaForm1";
            this.Load += new System.EventHandler(this.StatiyaForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Maintext;
        private System.Windows.Forms.Label Kategoriatext;
        private System.Windows.Forms.Label Stattext;
    }
}