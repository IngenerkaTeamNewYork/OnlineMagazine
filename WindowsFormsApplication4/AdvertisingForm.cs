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
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO Advertisment(Text, Pic, Date_From, Data_to, id, new)" +
                    " VALUES ('" + text_na_reklame.Text + "', '', '13.10.2018', '20.10.2018', '6', '1'", SQLClass.CONN);
                
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
            }
        }
    }
}
