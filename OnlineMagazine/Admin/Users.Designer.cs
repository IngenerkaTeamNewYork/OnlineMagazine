namespace OnlineMag
{
    partial class Users
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_feel = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label_feel);
            this.panel1.Controls.Add(this.labelb);
            this.panel1.Controls.Add(this.name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 282);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Админы",
            "Пользователи",
            "Авторы"});
            this.comboBox1.Location = new System.Drawing.Point(4, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Вывести категорию";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_feel
            // 
            this.label_feel.AutoSize = true;
            this.label_feel.Location = new System.Drawing.Point(76, 4);
            this.label_feel.Name = "label_feel";
            this.label_feel.Size = new System.Drawing.Size(61, 13);
            this.label_feel.TabIndex = 2;
            this.label_feel.Text = "Состояние";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(201, 4);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(54, 13);
            this.labelb.TabIndex = 1;
            this.labelb.Text = "действия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(38, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Логин";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 282);
            this.Controls.Add(this.panel1);
            this.Name = "Users";
            this.Text = "Список пользователей";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label_feel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}