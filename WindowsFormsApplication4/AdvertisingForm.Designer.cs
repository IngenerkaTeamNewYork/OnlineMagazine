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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(17, 16);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(266, 150);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(331, 46);
            this.textBox_adress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(241, 22);
            this.textBox_adress.TabIndex = 1;
            // 
            // text_na_reklame
            // 
            this.text_na_reklame.Location = new System.Drawing.Point(331, 101);
            this.text_na_reklame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_na_reklame.Multiline = true;
            this.text_na_reklame.Name = "text_na_reklame";
            this.text_na_reklame.Size = new System.Drawing.Size(240, 197);
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
            this.checkedListBox_categories.Location = new System.Drawing.Point(29, 194);
            this.checkedListBox_categories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBox_categories.Name = "checkedListBox_categories";
            this.checkedListBox_categories.Size = new System.Drawing.Size(159, 106);
            this.checkedListBox_categories.TabIndex = 3;
            // 
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_agree.Location = new System.Drawing.Point(29, 319);
            this.checkBox_agree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(398, 21);
            this.checkBox_agree.TabIndex = 4;
            this.checkBox_agree.Text = "Я прочел и соглашаюсь пожертвовать вам свою печень";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            // 
            // checkBox_agree2
            // 
            this.checkBox_agree2.AutoSize = true;
            this.checkBox_agree2.Location = new System.Drawing.Point(29, 347);
            this.checkBox_agree2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_agree2.Name = "checkBox_agree2";
            this.checkBox_agree2.Size = new System.Drawing.Size(303, 21);
            this.checkBox_agree2.TabIndex = 5;
            this.checkBox_agree2.Text = "На пожизненное рабство также согласен";
            this.checkBox_agree2.UseVisualStyleBackColor = true;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(269, 375);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(303, 49);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "Отправить админу на рассмотрение";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(327, 16);
            this.label_adress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(57, 17);
            this.label_adress.TabIndex = 7;
            this.label_adress.Text = "Ссылка";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(327, 81);
            this.label_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(126, 17);
            this.label_text.TabIndex = 8;
            this.label_text.Text = "Текст на рекламе";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdvertisingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 425);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.checkBox_agree2);
            this.Controls.Add(this.checkBox_agree);
            this.Controls.Add(this.checkedListBox_categories);
            this.Controls.Add(this.text_na_reklame);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}