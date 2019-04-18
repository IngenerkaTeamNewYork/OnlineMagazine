namespace OnlineMag
{
    partial class CategoriesUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_cats_header = new System.Windows.Forms.Label();
            this.categories_linklabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_cats_header
            // 
            this.label_cats_header.AutoSize = true;
            this.label_cats_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_cats_header.Location = new System.Drawing.Point(0, 0);
            this.label_cats_header.Name = "label_cats_header";
            this.label_cats_header.Size = new System.Drawing.Size(72, 13);
            this.label_cats_header.TabIndex = 0;
            this.label_cats_header.Text = "КАТЕГОРИИ";
            // 
            // categories_linklabel
            // 
            this.categories_linklabel.AutoSize = true;
            this.categories_linklabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categories_linklabel.Location = new System.Drawing.Point(0, 232);
            this.categories_linklabel.Name = "categories_linklabel";
            this.categories_linklabel.Size = new System.Drawing.Size(81, 13);
            this.categories_linklabel.TabIndex = 5;
            this.categories_linklabel.TabStop = true;
            this.categories_linklabel.Text = "Все категории";
            this.categories_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.categories_linklabel_LinkClicked);
            // 
            // CategoriesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.categories_linklabel);
            this.Controls.Add(this.label_cats_header);
            this.Name = "CategoriesUserControl";
            this.Size = new System.Drawing.Size(282, 245);
            this.Load += new System.EventHandler(this.CategoriesUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_cats_header;
        public System.Windows.Forms.LinkLabel categories_linklabel;
    }
}
