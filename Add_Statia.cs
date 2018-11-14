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
        public string[] gg = new string[50];

        public Add_Statia(string avtor)
        {
            avtor1 = avtor;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ne_povtor == textBox_Name.Text)
            {
                MessageBox.Show("Скоре всего вы пытаетесь опубликовать ещё раз");
            }
            else
            {
                List<String> ids = SQLClass.Select("SELECT MAX(Artic_ID + 1) FROM  " + Tables.ARTICLES);
                id = ids[0];

                SQLClass.Insert("INSERT INTO " + Tables.ARTICLES + 
                    "(Header, Text, Author, Picture, Artic_ID, Category, new)" +
                    " VALUES ('" + textBox_Name.Text + "'," +
                    "'" + textBox_txtStat.Text + "'," +
                    "'" + avtor1 + "'," +
                    "'" + textBox_ssulka.Text + "'," +
                    "" + id + "," +
                    "'" + comboBox_kategorii.Text + "'," +
                    " 1)");
                ne_povtor = textBox_Name.Text;
            }             
        }

        private void Add_Statia_Load(object sender, EventArgs e)
        {
            comboBox_kategorii.Items.Clear();
            List<String> Categories = SQLClass.Select("SELECT name FROM " + Tables.CATEGORIES);
            foreach (String cat in Categories)
            {
                comboBox_kategorii.Items.Add(cat);
            }
        }
    }
}
