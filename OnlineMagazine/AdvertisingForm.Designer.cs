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
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.text_na_reklame = new System.Windows.Forms.TextBox();
            this.checkBox_agree = new System.Windows.Forms.CheckBox();
            this.checkBox_agree2 = new System.Windows.Forms.CheckBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(248, 37);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(182, 20);
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
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_agree.Location = new System.Drawing.Point(22, 259);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(312, 17);
            this.checkBox_agree.TabIndex = 4;
            this.checkBox_agree.Text = "Я прочел и соглашаюсь пожертвовать вам свою печень";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            // 
            // checkBox_agree2
            // 
            this.checkBox_agree2.AutoSize = true;
            this.checkBox_agree2.Location = new System.Drawing.Point(22, 282);
            this.checkBox_agree2.Name = "checkBox_agree2";
            this.checkBox_agree2.Size = new System.Drawing.Size(239, 17);
            this.checkBox_agree2.TabIndex = 5;
            this.checkBox_agree2.Text = "На пожизненное рабство также согласен";
            this.checkBox_agree2.UseVisualStyleBackColor = true;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(202, 305);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(227, 40);
            this.button_send.TabIndex = 6;
            this.button_send.Text = "Отправить админу на рассмотрение";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 142);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(188, 109);
            this.checkedListBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 101);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdvertisingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.checkBox_agree2);
            this.Controls.Add(this.checkBox_agree);
            this.Controls.Add(this.text_na_reklame);
            this.Controls.Add(this.textBox_adress);
            this.Name = "AdvertisingForm";
            this.Text = "Добавить рекламу";
            this.Load += new System.EventHandler(this.AdvertisingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox text_na_reklame;
        private System.Windows.Forms.CheckBox checkBox_agree;
        private System.Windows.Forms.CheckBox checkBox_agree2;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}