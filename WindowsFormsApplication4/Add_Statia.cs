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
    public partial class Add_Statia : Form
    {
        public string avtor1;
        public string id;
        public string ne_povtor = "";
        public Add_Statia(string avtor)
        {
            avtor1 = avtor;
            InitializeComponent();
        }
        public string[] gg = new string[50];
        private void button1_Click(object sender, EventArgs e)
        {

            if (ne_povtor == textBox_Name.Text)
            {
                MessageBox.Show("Скоре всего вы пытаетесь опубликовать ещё раз");
            }
            else
            {
                MySqlCommand gd = new MySqlCommand("SELECT MAX(Artic_ID + 1) FROM  " + Tables.ARTICLES, SQLClass.CONN);
                MySqlDataReader g = gd.ExecuteReader();
                while (g.Read())
                {
                    id = Convert.ToString(g[0]);
                }
                g.Close();

                MySqlCommand cmd = new MySqlCommand(
                           "INSERT INTO " + Tables.ARTICLES + "(Header, Text, Author, Picture, Artic_ID, Category, new)" +
                           " VALUES ('" + textBox_Name.Text + "'," +
                            "'" + textBox_txtStat.Text + "'," +
                            "'" + avtor1 + "'," +
                            "'" + textBox_ssulka.Text + "'," +
                            "" + id + "," +
                            "'" + comboBox_kategorii.Text + "'," +
                            " 1)", SQLClass.CONN);


                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                ne_povtor = textBox_Name.Text;
            }
             
        }
        public int uy = 0;
        private void Add_Statia_Load(object sender, EventArgs e)
        {
            comboBox_kategorii.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("SELECT name FROM Categories" , SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                comboBox_kategorii.Items.Add(rdr[0].ToString());
            }
            rdr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label_text_Click(object sender, EventArgs e)
        {

        }

        private void textBox_txtStat_TextChanged(object sender, EventArgs e)
        {

        }
         
    }
}
