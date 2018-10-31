namespace WindowsFormsApplication4
{
    partial class Balance_Author
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
            this.list_Author = new System.Windows.Forms.ComboBox();
            this.Summa = new System.Windows.Forms.TextBox();
            this.Tenge = new System.Windows.Forms.Label();
            this.picture_Author = new System.Windows.Forms.PictureBox();
            this.Vyuvod_Denyak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Author)).BeginInit();
            this.SuspendLayout();
            // 
            // list_Author
            // 
            this.list_Author.FormattingEnabled = true;
            this.list_Author.Items.AddRange(new object[] {
            "dfgdfg",
            "dfgdfg4",
            "dfgdfgrty"});
            this.list_Author.Location = new System.Drawing.Point(12, 148);
            this.list_Author.Name = "list_Author";
            this.list_Author.Size = new System.Drawing.Size(222, 21);
            this.list_Author.TabIndex = 12;
            // 
            // Summa
            // 
            this.Summa.BackColor = System.Drawing.SystemColors.Control;
            this.Summa.Location = new System.Drawing.Point(55, 257);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(188, 20);
            this.Summa.TabIndex = 13;
            // 
            // Tenge
            // 
            this.Tenge.AutoSize = true;
            this.Tenge.Location = new System.Drawing.Point(0, 260);
            this.Tenge.Name = "Tenge";
            this.Tenge.Size = new System.Drawing.Size(40, 13);
            this.Tenge.TabIndex = 14;
            this.Tenge.Text = "Тенге:";
            // 
            // picture_Author
            // 
            this.picture_Author.Location = new System.Drawing.Point(12, 12);
            this.picture_Author.Name = "picture_Author";
            this.picture_Author.Size = new System.Drawing.Size(222, 130);
            this.picture_Author.TabIndex = 15;
            this.picture_Author.TabStop = false;
            // 
            // Vyuvod_Denyak
            // 
            this.Vyuvod_Denyak.Location = new System.Drawing.Point(240, 12);
            this.Vyuvod_Denyak.Name = "Vyuvod_Denyak";
            this.Vyuvod_Denyak.Size = new System.Drawing.Size(358, 265);
            this.Vyuvod_Denyak.TabIndex = 16;
            this.Vyuvod_Denyak.Text = "Вывести мои ДЕНЬГИ!";
            this.Vyuvod_Denyak.UseVisualStyleBackColor = true;
            // 
            // Balance_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 289);
            this.Controls.Add(this.Vyuvod_Denyak);
            this.Controls.Add(this.picture_Author);
            this.Controls.Add(this.Tenge);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.list_Author);
            this.Name = "Balance_Author";
            this.Text = "Дайте деняк";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox list_Author;
        private System.Windows.Forms.TextBox Summa;
        private System.Windows.Forms.Label Tenge;
        private System.Windows.Forms.PictureBox picture_Author;
        private System.Windows.Forms.Button Vyuvod_Denyak;
    }
}