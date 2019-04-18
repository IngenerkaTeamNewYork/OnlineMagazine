namespace OnlineMag
{
    partial class Add_Statia
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
            this.comboBox_kategorii = new System.Windows.Forms.ComboBox();
            this.textBox_txtStat = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_image = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.textBox_ssulka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_kategorii
            // 
            this.comboBox_kategorii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kategorii.FormattingEnabled = true;
            this.comboBox_kategorii.Location = new System.Drawing.Point(437, 36);
            this.comboBox_kategorii.Name = "comboBox_kategorii";
            this.comboBox_kategorii.Size = new System.Drawing.Size(147, 21);
            this.comboBox_kategorii.TabIndex = 0;
            // 
            // textBox_txtStat
            // 
            this.textBox_txtStat.Location = new System.Drawing.Point(12, 125);
            this.textBox_txtStat.Multiline = true;
            this.textBox_txtStat.Name = "textBox_txtStat";
            this.textBox_txtStat.Size = new System.Drawing.Size(569, 451);
            this.textBox_txtStat.TabIndex = 1;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(15, 36);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(416, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(569, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Опубликовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(60, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Название:";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(434, 9);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(63, 13);
            this.label_Category.TabIndex = 6;
            this.label_Category.Text = "Категория:";
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Location = new System.Drawing.Point(9, 59);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(136, 13);
            this.label_image.TabIndex = 7;
            this.label_image.Text = "Ссылка на иллюстрацию:";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(12, 109);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(40, 13);
            this.label_text.TabIndex = 8;
            this.label_text.Text = "Текст:";
            // 
            // textBox_ssulka
            // 
            this.textBox_ssulka.Location = new System.Drawing.Point(15, 86);
            this.textBox_ssulka.Name = "textBox_ssulka";
            this.textBox_ssulka.Size = new System.Drawing.Size(416, 20);
            this.textBox_ssulka.TabIndex = 9;
            // 
            // Add_Statia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 621);
            this.Controls.Add(this.textBox_ssulka);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_txtStat);
            this.Controls.Add(this.comboBox_kategorii);
            this.Name = "Add_Statia";
            this.Text = "Добавить статью";
            this.Load += new System.EventHandler(this.Add_Statia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_kategorii;
        private System.Windows.Forms.TextBox textBox_txtStat;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox textBox_ssulka;

    }
}