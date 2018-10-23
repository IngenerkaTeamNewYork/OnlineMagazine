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
    public partial class NewPages : Form
    {
        public struct newPage
        {
            public String Header;
            public Label Label_;
            public CheckBox CheckBox_;
        }

        public List<newPage> ListOfPages = new List<newPage>();

        public NewPages()
        {
            InitializeComponent();
        }

        void LoadPages()
        {
            this.Controls.Clear();
            this.Controls.Add(new Label() 
            { 
                Text = "Новый",
                Location = new Point(0,0),
                Size = new Size(50, 20)
            });
            this.Controls.Add(new Label()
            {
                Text = "Название",
                Location = new Point(100, 0)

            });

            MySqlCommand cmd = new MySqlCommand(
                        "SELECT header, new FROM " + Tables.ARTICLES, SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            int PosY = 20;
            while (rdr.Read())
            {
                newPage Page = new newPage();
                Page.Header = rdr[0].ToString();



                Page.CheckBox_ = new CheckBox();
                Page.CheckBox_.Location = new Point(10, PosY);
                Page.CheckBox_.Size = new Size(50, 30);
                Page.CheckBox_.Click += new System.EventHandler(cbnewpage);
                Page.CheckBox_.Checked = (rdr[1].ToString()=="1");


                Page.Label_ = new Label();
                Page.Label_.Location = new Point(100, PosY);
                Page.Label_.Size = new Size(250, 30);
                Page.Label_.Text = rdr[0].ToString();
                if (rdr[1].ToString()=="0")
                {
                    Page.Label_.ForeColor = System.Drawing.Color.Gray;
                }

                ListOfPages.Add(Page);
                this.Controls.Add(Page.CheckBox_);
                this.Controls.Add(Page.Label_);
                PosY += 30;
            }
            //textBox1.Text = String.Join(Environment.NewLine, names.ToArray());
            rdr.Close();
        }

        void cbnewpage(object sender, EventArgs e)
        {
            foreach (newPage a in ListOfPages)
            {
                if (sender.Equals(a.CheckBox_))
                {
                    if (a.Label_.ForeColor == System.Drawing.Color.Gray)
                    {
                        MySqlCommand cmd = new MySqlCommand(
                            "UPDATE " + Tables.ARTICLES +
                            " SET `new`=1 WHERE header = '" + a.Header + "'", SQLClass.CONN);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        rdr.Close();
                    }
                    else
                    {
                        MySqlCommand cmd = new MySqlCommand(
                           "UPDATE " + Tables.ARTICLES +
                           " SET `new`=0 WHERE header = '" + a.Header + "'", SQLClass.CONN);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        rdr.Close();
                    }
                }
            }
            LoadPages();
        }

        void NewPages_Load(object sender, EventArgs e)
        {
            LoadPages();
        }
            
    }
}
