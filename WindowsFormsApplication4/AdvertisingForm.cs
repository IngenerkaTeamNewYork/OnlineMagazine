using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class AdvertisingForm : Form
    {
        public AdvertisingForm()
        {
            InitializeComponent();
        }

        

        private void AdvertisingForm_Load(object sender, EventArgs e)
        {
            List<String> catsList = SQLClass.Select("SELECT Name FROM " + Tables.CATEGORIES + " LIMIT 0, 7");
            
            for (int artIndex = 0; artIndex < catsList.Count; artIndex++)
            {
               
                checkedListBox1.Items.Add(catsList[artIndex].ToString());
            }
            List<String> s = Advertising.GetRandom();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.LoadAsync(s[0]);
            pictureBox1.Tag = s[1];
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (checkBox_agree.Checked && checkBox_agree2.Checked)          
            {
                MySqlCommand Dcmd = new MySqlCommand("SELECT MAX(id+1) FROM Advertisment", SQLClass.CONN);
                MySqlDataReader Drdr = Dcmd.ExecuteReader();
                
                String NewAdvId = "";
                while (Drdr.Read())
                {
                    NewAdvId = Drdr[0].ToString();
                }                
                Drdr.Close();

                SQLClass.Insert("INSERT INTO " + Tables.ADVERTISMENT +
                    "(Text, Pic, Date_From, Data_to, id, new)" +
                    " VALUES (" +
                    "'" + text_na_reklame.Text + "'" +
                    ", '" + textBox_adress.Text + "'" +
                    ", '13.10.2018', '20.10.2018', '" + NewAdvId + "', '1')");

                foreach (String item in checkedListBox1.CheckedItems)
                {
                    SQLClass.Insert("INSERT INTO " + Tables.PROMO_CATEGORIES_LINK +
                        "(id_promo, category, money)" +
                        " VALUES (" + NewAdvId + ",'" +item +"', 1)");
                }            
             }
            MessageBox.Show("Ваша реклама отправлена на рассмотрение");
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((PictureBox)sender).Tag.ToString());
            }
            catch (Exception)
            {
                Process.Start("https://www.yandex.ru");
            }
        }
    }
}
