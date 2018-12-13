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

    public struct Reklama
    {
        public int id;
        public DateTime date_to;
        public string text;
        public Boolean n;
        public Button AddOneDayButton;
        public Button prinitButton;
        public Button proshiyButton;
    }

    
    public partial class Spisok_reklamy : Form
    {
        public List<Reklama> mn_reklamy = new List<Reklama>();


        public void AddOneDay_Click(object sender, EventArgs e)
        {
            foreach (Reklama rekl in mn_reklamy)
            {
                if (sender.Equals(rekl.AddOneDayButton))
                {
                    SQLClass.Update(
                        "UPDATE " + Tables.ADVERTISMENT +
                        " SET Data_to = '" + rekl.date_to.AddDays(1).ToString("dd.MM.yyyy") + "'" +
                        " WHERE id = " + rekl.id);                    
                }
            }
        }


        public void prinit(object sender, EventArgs e)
        {
            foreach (Reklama rekl in mn_reklamy)
            {
                if (sender.Equals(rekl.prinitButton))
                {
                    SQLClass.Update(
                        "UPDATE " + Tables.ADVERTISMENT +
                        " SET New = '" + "0" + "'" +
                        " WHERE id = " + rekl.id);
                }
            }
        }

        public void proshiy(object sender, EventArgs e)
        {
            foreach (Reklama rekl in mn_reklamy)
            {
                if (sender.Equals(rekl.proshiyButton))
                {
                    SQLClass.Delete("DELETE FROM " + Tables.ADVERTISMENT +
                        " WHERE id = " + rekl.id);
                }
            }
        }

        public Spisok_reklamy(List<Reklama> mnogo_reklamy)
        {
            InitializeComponent();
        }        

        private void Spisok_reklamy_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
            zapolnenie();


            TableLayoutPanel mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.RowStyles.Clear();

            int id = 0;
            foreach (Reklama rekl in mn_reklamy)
            {
                rekl.AddOneDayButton.Click += new System.EventHandler(AddOneDay_Click);
                rekl.prinitButton.Click += new System.EventHandler(prinit);
                rekl.proshiyButton.Click += new System.EventHandler(proshiy);

                if (rekl.date_to <= DateTime.Now || rekl.n)
                {
                    mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                    TableLayoutPanel tableLayoutPanel12 = new TableLayoutPanel();
                    tableLayoutPanel12.ColumnCount = 1;
                    tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    tableLayoutPanel12.Dock = DockStyle.Fill;
                    tableLayoutPanel12.Location = new Point(345, 3);
                    tableLayoutPanel12.RowCount = 2;
                    tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    tableLayoutPanel12.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    tableLayoutPanel12.Size = new System.Drawing.Size(144, 122);


                    TableLayoutPanel tableLayoutPanel13 = new TableLayoutPanel();
                    tableLayoutPanel13.ColumnCount = 1;
                    tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    tableLayoutPanel13.Dock = DockStyle.Fill;
                    tableLayoutPanel13.Location = new Point(345, 3);
                    tableLayoutPanel13.Name = "tableLayoutPanel13";
                    tableLayoutPanel13.RowCount = 2;
                    tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    tableLayoutPanel13.Size = new Size(144, 122);


                    Label label_text = new Label();
                    label_text.Location = new Point(103, 0);
                    label_text.Dock = DockStyle.Fill;
                    label_text.Size = new Size(250, 13); ;
                    label_text.Text = rekl.text;


                    Label label_date_from = new Label();
                    label_date_from.Location = new Point(103, 0);
                    label_date_from.Dock = DockStyle.Fill;
                    label_date_from.Size = new Size(250, 13);
                    label_date_from.Text = rekl.date_to.ToString();


                    PictureBox pictureBox1 = new PictureBox();
                    pictureBox1.Location = new Point(3, 3);
                    pictureBox1.Size = new Size(94, 100);
                    pictureBox1.TabStop = false;






                    tableLayoutPanel12.Controls.Add(rekl.proshiyButton, 0, 1);
                    if (rekl.n)
                    { tableLayoutPanel12.Controls.Add(rekl.prinitButton, 0, 0); }
                    //tableLayoutPanel12.Controls.Add(rekl.prinitButton, 0, 0);

                    tableLayoutPanel13.Controls.Add(label_date_from, 0, 0);
                    if (rekl.date_to <= DateTime.Now)
                    { tableLayoutPanel13.Controls.Add(rekl.AddOneDayButton, 0, 1); }

                    mainTableLayoutPanel.Controls.Add(label_text, 0, id);
                    mainTableLayoutPanel.Controls.Add(tableLayoutPanel13, 1, id);
                    mainTableLayoutPanel.Controls.Add(tableLayoutPanel12, 2, id);
                    main_panel.Controls.Add(mainTableLayoutPanel);

                    id++;
                }
            }
        }

        private void zapolnenie ()
        {
            mn_reklamy.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT Text, data_to, new, id FROM Advertisment", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Reklama rek = new Reklama();

                rek.text = rdr[0].ToString();
                rek.date_to = Convert.ToDateTime(rdr[1].ToString());
                rek.n = Convert.ToBoolean(rdr[2].ToString());
                rek.id = Convert.ToInt32(rdr[3].ToString());

                rek.AddOneDayButton = new Button();
                rek.AddOneDayButton.Location = new System.Drawing.Point(3, 64); 
                rek.AddOneDayButton.Size = new System.Drawing.Size(115, 23);
                rek.AddOneDayButton.TabIndex = 7;
                rek.AddOneDayButton.Text = "Продлить : +1 день";//Add 1 day
                rek.AddOneDayButton.UseVisualStyleBackColor = true;


                rek.prinitButton = new Button();
                rek.prinitButton.Location = new System.Drawing.Point(3, 64);
                rek.prinitButton.Size = new System.Drawing.Size(115, 23);
                rek.prinitButton.TabIndex = 7;
                rek.prinitButton.Text = "Одобрить";
                rek.prinitButton.UseVisualStyleBackColor = true;


                rek.proshiyButton = new Button();
                rek.proshiyButton.Location = new System.Drawing.Point(3, 64);
                rek.proshiyButton.Size = new System.Drawing.Size(115, 23);
                rek.proshiyButton.TabIndex = 7;
                rek.proshiyButton.Text = "ПРОЩАЙ";
                rek.proshiyButton.UseVisualStyleBackColor = true;


                mn_reklamy.Add(rek);
            }
            rdr.Close();
        }

    }
}
