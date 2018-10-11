namespace WindowsFormsApplication4
{
    partial class AdvertisingForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.text_na_reklame = new System.Windows.Forms.TextBox();
            this.checkedListBox_categories = new System.Windows.Forms.CheckedListBox();
            this.checkBox_agree = new System.Windows.Forms.CheckBox();
            this.checkBox_agree2 = new System.Windows.Forms.CheckBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(13, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 122);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(248, 43);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(100, 20);
            this.textBox_adress.TabIndex = 1;
            // 
            // text_na_reklame
            // 
            this.text_na_reklame.Location = new System.Drawing.Point(248, 82);
            this.text_na_reklame.Multiline = true;
            this.text_na_reklame.Name = "text_na_reklame";
            this.text_na_reklame.Size = new System.Drawing.Size(181, 161);
            this.text_na_reklame.TabIndex = 2;
            // 
            // checkedListBox_categories
            // 
            this.checkedListBox_categories.FormattingEnabled = true;
            this.checkedListBox_categories.Items.AddRange(new object[] {
            "Животные",
            "Техника",
            "Популярное",
            "Наука",
            "Новости"});
            this.checkedListBox_categories.Location = new System.Drawing.Point(22, 158);
            this.checkedListBox_categories.Name = "checkedListBox_categories";
            this.checkedListBox_categories.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_categories.TabIndex = 3;
            // 
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.Location = new System.Drawing.Point(22, 259);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(240, 17);
            this.checkBox_agree.TabIndex = 4;
            this.checkBox_agree.Text = "Я прочел и соглашаюсь блаблаблаблабла";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            // 
            // checkBox_agree2
            // 
            this.checkBox_agree2.AutoSize = true;
            this.checkBox_agree2.Location = new System.Drawing.Point(22, 282);
            this.checkBox_agree2.Name = "checkBox_agree2";
            this.checkBox_agree2.Size = new System.Drawing.Size(260, 17);
            this.checkBox_agree2.TabIndex = 5;
            this.checkBox_agree2.Text = "аналогично, только с другим бла соглашаюсь";
            this.checkBox_agree2.UseVisualStyleBackColor = true;
            this.checkBox_agree2.CheckedChanged += new System.EventHandler(this.checkBox_agree2_CheckedChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(202, 305);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(227, 40);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "Отправить админу на рассмотрение";
            this.button_send.UseVisualStyleBackColor = true;
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(245, 13);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(46, 13);
            this.label_adress.TabIndex = 7;
            this.label_adress.Text = "Ссылка";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(245, 66);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(99, 13);
            this.label_text.TabIndex = 8;
            this.label_text.Text = "Текст на рекламе";
            // 
            // AdvertisingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 345);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.checkBox_agree2);
            this.Controls.Add(this.checkBox_agree);
            this.Controls.Add(this.checkedListBox_categories);
            this.Controls.Add(this.text_na_reklame);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.pictureBox);
            this.Name = "AdvertisingForm";
            this.Text = "Добавить рекламу";
            this.Load += new System.EventHandler(this.AdvertisingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox text_na_reklame;
        private System.Windows.Forms.CheckedListBox checkedListBox_categories;
        private System.Windows.Forms.CheckBox checkBox_agree;
        private System.Windows.Forms.CheckBox checkBox_agree2;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_text;
    }
}