using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Spisok_reklamy : Form
    {
        public Spisok_reklamy(List<Reklama> mnogo_reklamy)
        {
            InitializeComponent();
            
            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.RowStyles.Clear();

            int id = 0;
            foreach (Reklama i in mnogo_reklamy)
            {

                if (mnogo_reklamy[id].dateFrom <= DateTime.Now || mnogo_reklamy[id].n)
                {
                mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                
                TableLayoutPanel tableLayoutPanel12 = new TableLayoutPanel();
                tableLayoutPanel12.ColumnCount = 1;
                tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
                tableLayoutPanel12.Location = new System.Drawing.Point(345, 3);
                tableLayoutPanel12.Name = "tableLayoutPanel12";
                tableLayoutPanel12.RowCount = 2;
                tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                tableLayoutPanel12.Size = new System.Drawing.Size(144, 122);



                Label label1 = new Label();
                label1.Location = new Point(103, 0);
                label1.Name = "label1";
                label1.Dock = DockStyle.Fill;
                label1.Size = new Size(250, 13);;
                label1.Text = i.text;


                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(3, 3);
                pictureBox1.Name = "pictureBox1";
                pictureBox1.Size = new System.Drawing.Size(94, 100);
                pictureBox1.TabStop = false;


                Button button1 = new Button();
                button1.Location = new System.Drawing.Point(3, 3);
                button1.Name = "button1";
                button1.Size = new System.Drawing.Size(75, 23);
                button1.TabIndex = 3;
                button1.Text = "ПРОЩАЙ";
                button1.UseVisualStyleBackColor = true;

                tableLayoutPanel12.Controls.Add(button1, 0, 0);


                    Button button3 = new Button();
                    button3.Location = new System.Drawing.Point(3, 64);
                    button3.Name = "button3";
                    button3.Size = new System.Drawing.Size(115, 23);
                    button3.TabIndex = 7;
                    button3.Text = "Продлить : +1 день";
                    button3.UseVisualStyleBackColor = true;

                    tableLayoutPanel12.Controls.Add(button3, 0, 1);
                


                mainTableLayoutPanel.Controls.Add(pictureBox1, 0, id);
                mainTableLayoutPanel.Controls.Add(label1, 1, id);
                mainTableLayoutPanel.Controls.Add(tableLayoutPanel12, 2, id);
                }

                id++;
            }

            panel1.Controls.Add(mainTableLayoutPanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Spisok_reklamy_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
