namespace WindowsFormsApplication4
{
    partial class List_of_author
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_statistik = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1_statistik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 270);
            this.panel1.TabIndex = 0;
            // 
            // button1_statistik
            // 
            this.button1_statistik.Location = new System.Drawing.Point(16, 235);
            this.button1_statistik.Name = "button1_statistik";
            this.button1_statistik.Size = new System.Drawing.Size(75, 23);
            this.button1_statistik.TabIndex = 1;
            this.button1_statistik.Text = "Статистика";
            this.button1_statistik.UseVisualStyleBackColor = true;
            this.button1_statistik.Click += new System.EventHandler(this.button1_Click);
            // 
            // List_of_author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.panel1);
            this.Name = "List_of_author";
            this.Text = "Список авторов";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1_statistik;
    }
}