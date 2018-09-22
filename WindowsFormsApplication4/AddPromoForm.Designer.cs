namespace WindowsFormsApplication4
{
    partial class Добавить_картинку
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dobavit = new System.Windows.Forms.Button();
            this.otmena = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kartinka = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kartinka)).BeginInit();
            this.SuspendLayout();
            // 
            // dobavit
            // 
            this.dobavit.Location = new System.Drawing.Point(13, 13);
            this.dobavit.Name = "dobavit";
            this.dobavit.Size = new System.Drawing.Size(82, 36);
            this.dobavit.TabIndex = 1;
            this.dobavit.Tag = "";
            this.dobavit.Text = "Добавить";
            this.dobavit.UseVisualStyleBackColor = true;
            this.dobavit.Click += new System.EventHandler(this.dobavit_Click);
            // 
            // otmena
            // 
            this.otmena.Location = new System.Drawing.Point(111, 13);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(82, 36);
            this.otmena.TabIndex = 2;
            this.otmena.Tag = "";
            this.otmena.Text = "Удалить";
            this.otmena.UseVisualStyleBackColor = true;
            this.otmena.Click += new System.EventHandler(this.otmena_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(572, 38);
            this.button3.TabIndex = 3;
            this.button3.Tag = "";
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // kartinka
            // 
            this.kartinka.Location = new System.Drawing.Point(62, 55);
            this.kartinka.Name = "kartinka";
            this.kartinka.Size = new System.Drawing.Size(479, 296);
            this.kartinka.TabIndex = 3;
            this.kartinka.TabStop = false;
            this.kartinka.Click += new System.EventHandler(this.kartinka_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(117, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер картинки должен быть максимум (479; 296)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Добавить_картинку
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kartinka);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.dobavit);
            this.Name = "Добавить_картинку";
            this.Text = "Добавить картинку";
            this.Load += new System.EventHandler(this.Добавить_картинку_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kartinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dobavit;
        private System.Windows.Forms.Button otmena;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox kartinka;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

