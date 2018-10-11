using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class Spisok_reklamy : Form
    {
        public List<Reklama> mn_reklamy;
        public void AddOneDay_Click(object sender, EventArgs e)
        {
            foreach (Reklama i in mn_reklamy)
            {
                if (sender.Equals(i.AddOneDayButton))
                {
                    //MessageBox.Show(i.text);
                    //i.dateFrom = i.dateFrom.AddDays(1);
                    MySqlCommand cmd = new MySqlCommand(
                        "UPDATE Advertisment" +
                        " SET Data_to = '" + i.dateFrom.AddDays(1).ToString("dd.MM.yyyy") + "'" +
                        " WHERE id = " + i.id , SQLClass.CONN);
                    MessageBox.Show(cmd.CommandText);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    //UPDATE `Advertisment` SET Data_to = '1.6.2016' WHERE id = 5
                    //"UPDATE .. SET data = '" + textbox1.Text + "' "
                }
            }
        }

        public Spisok_reklamy(List<Reklama> mnogo_reklamy)
        {
            InitializeComponent();
            mn_reklamy = mnogo_reklamy;
            
            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.RowStyles.Clear();

            int id = 0;
            foreach (Reklama i in mnogo_reklamy)
            {
                i.AddOneDayButton.Click += new System.EventHandler(AddOneDay_Click);

                if (i.dateFrom <= DateTime.Now || i.n)
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


                    TableLayoutPanel tableLayoutPanel13 = new TableLayoutPanel();
                    tableLayoutPanel13.ColumnCount = 1;
                    tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
                    tableLayoutPanel13.Location = new System.Drawing.Point(345, 3);
                    tableLayoutPanel13.Name = "tableLayoutPanel13";
                    tableLayoutPanel13.RowCount = 2;
                    tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    tableLayoutPanel13.Size = new System.Drawing.Size(144, 122);


                    Label label1 = new Label();
                    label1.Location = new Point(103, 0);
                    label1.Name = "label1";
                    label1.Dock = DockStyle.Fill;
                    label1.Size = new Size(250, 13);;
                    label1.Text = i.text;


                    Label label2 = new Label();
                    label2.Location = new Point(103, 0);
                    label2.Name = "label1";
                    label2.Dock = DockStyle.Fill;
                    label2.Size = new Size(250, 13); ;
                    label2.Text = i.dateFrom.ToString(); 


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

                tableLayoutPanel12.Controls.Add(button1, 0, 1);
                tableLayoutPanel12.Controls.Add(button1, 0, 0);

                tableLayoutPanel13.Controls.Add(label2, 0, 0);
                tableLayoutPanel13.Controls.Add(i.AddOneDayButton, 0, 1);

                mainTableLayoutPanel.Controls.Add(label1, 0, id);
                mainTableLayoutPanel.Controls.Add(tableLayoutPanel13, 1, id);
                mainTableLayoutPanel.Controls.Add(tableLayoutPanel12, 2, id);
                panel1.Controls.Add(mainTableLayoutPanel);

                id++;
                }
            }

            
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
