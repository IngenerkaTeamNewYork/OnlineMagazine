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

    public struct users
    {
        public string login;
        public string password;
        public Boolean ban;
        public Button btn;
        public Button ras;
    }

    public partial class AdminMainForm : Form
    {
        public List<Reklama> mnogo_reklamy = new List<Reklama>();
        public List<AuthorStat> writer = new List<AuthorStat>();
        public AdminMainForm()
        {
            InitializeComponent();

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


                mnogo_reklamy.Add(rek);
            }
            rdr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Spisok_reklamy sps = new Spisok_reklamy(mnogo_reklamy);
            sps.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form ifr = Application.OpenForms[0];
            ifr.Left = this.Left;
            ifr.Top = this.Top;
            ifr.Show();
            this.Close();
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            FBIform form = new FBIform();
            form.ShowDialog();
        }

        private void button_statistika_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm("");
            form1.ShowDialog();
        }
        
        
        private void button_all_users_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.ShowDialog();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            AdminMainForm_FormClosed(null, null);
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifr = Application.OpenForms[0];
            ifr.Left = this.Left;
            ifr.Top = this.Top;
            ifr.Show();
        }
        private void button_statistika_Click_1(object sender, EventArgs e)
        {
            StastisticsForm t = new StastisticsForm("");
            t.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collections coll = new Collections();
            coll.ShowDialog();
        }

        private void button_new_staty_Click(object sender, EventArgs e)
        {
            NewPages np = new NewPages();
            np.ShowDialog();
        }

        private void button_categories_Click_1(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm(true);
            form.ShowDialog();
        }

        private void button_author_Click_1(object sender, EventArgs e)
        {
            List_of_author form = new List_of_author();
            form.ShowDialog();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogsReadForm t = new LogsReadForm();
            t.ShowDialog();
        }
    }
}