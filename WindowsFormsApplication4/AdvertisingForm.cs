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
    public partial class AdvertisingForm : Form
    {
        public AdvertisingForm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void AdvertisingForm_Load(object sender, EventArgs e)
        {

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
            }
        }
    }
}
