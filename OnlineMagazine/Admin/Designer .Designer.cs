namespace OnlineMag
{
    partial class Designer
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
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reklamatextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.podborkaLabel = new System.Windows.Forms.Label();
            this.PodborkatextBox = new System.Windows.Forms.TextBox();
            this.authorsTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Location = new System.Drawing.Point(3, 0);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(83, 13);
            this.AuthorsLabel.TabIndex = 0;
            this.AuthorsLabel.Text = "Число авторов";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(179, 41);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.categoryTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reklamatextBox
            // 
            this.reklamatextBox.Location = new System.Drawing.Point(179, 117);
            this.reklamatextBox.Name = "reklamatextBox";
            this.reklamatextBox.Size = new System.Drawing.Size(100, 20);
            this.reklamatextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Число рекламы ";
            // 
            // podborkaLabel
            // 
            this.podborkaLabel.AutoSize = true;
            this.podborkaLabel.Location = new System.Drawing.Point(3, 76);
            this.podborkaLabel.Name = "podborkaLabel";
            this.podborkaLabel.Size = new System.Drawing.Size(93, 13);
            this.podborkaLabel.TabIndex = 5;
            this.podborkaLabel.Text = "Число подборок ";
            // 
            // PodborkatextBox
            // 
            this.PodborkatextBox.Location = new System.Drawing.Point(179, 79);
            this.PodborkatextBox.Name = "PodborkatextBox";
            this.PodborkatextBox.Size = new System.Drawing.Size(100, 20);
            this.PodborkatextBox.TabIndex = 6;
            this.PodborkatextBox.TextChanged += new System.EventHandler(this.PodborkatextBox_TextChanged);
            // 
            // authorsTextBox
            // 
            this.authorsTextBox.Location = new System.Drawing.Point(179, 3);
            this.authorsTextBox.Name = "authorsTextBox";
            this.authorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorsTextBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 38);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(94, 13);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Число категорий";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AuthorsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.authorsTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.reklamatextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PodborkatextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.podborkaLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(352, 230);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 155);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя человека, которому преводятся деньги";
            // 
            // Designer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 230);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Designer";
            this.Text = "Настройки внешнего вида и Мавроди";
            this.Load += new System.EventHandler(this.Designer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AuthorsLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox reklamatextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label podborkaLabel;
        private System.Windows.Forms.TextBox PodborkatextBox;
        private System.Windows.Forms.TextBox authorsTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
    }
}