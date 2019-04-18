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

namespace OnlineMag
{
    public partial class Collections : Form
    {
        public Collections()
        {
            InitializeComponent();
        }

        private void Collections_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;

            checkedListBox1.Items.Clear();
            List<String> Collection_List = SQLClass.Select("SELECT DISTINCT `Coll_text` FROM  " + Tables.COLLECTION);
            foreach (String list in Collection_List)
            {
                comboBox1.Items.Add(list);
               
            }
            
            List<String> ArticlesList = SQLClass.Select("SELECT Header FROM " + Tables.ARTICLES);
          
            foreach (String article in ArticlesList)
            {
                checkedListBox1.Items.Add(article);
            }
            New.Visible = false;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Новая")
            {
                New.Visible = true;
            }
            else
            {
                checkedListBox1.Items.Clear();
                List<String> stat = SQLClass.Select("SELECT Header, Artic_ID FROM `Articles1` WHERE " +
                       "Artic_ID IN (SELECT id_art FROM " + Tables.COLLECTION + " WHERE Coll_text = '" + comboBox1.Text + "')");

                List<String> Collection_List = SQLClass.Select("SELECT DISTINCT `Coll_text` FROM  " + Tables.COLLECTION);
                foreach (String list in Collection_List)
                {
                    comboBox1.Items.Add(list);

                }

                List<String> ArticlesList = SQLClass.Select("SELECT Header FROM " + Tables.ARTICLES);

                foreach (String article in ArticlesList)
                {
                    checkedListBox1.Items.Add(article, stat.Contains(article));
                }
            }


        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SQLClass.Delete("DELETE FROM " + Tables.COLLECTION + " WHERE Coll_Text = '" + comboBox1.Text + "'");

            for (int index = 0; index < checkedListBox1.CheckedItems.Count; index++)
            {
                String str = checkedListBox1.CheckedItems[index].ToString();

                SQLClass.Insert("INSERT INTO " + Tables.COLLECTION + "(Coll_Text, id_art) VALUES ('" + comboBox1.Text + "'," + 
                    "(SELECT artic_id FROM " + Tables.ARTICLES + " WHERE `Header` = '" + str + "'))");

                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.Insert("INSERT INTO " + Tables.COLLECTION + " (`id_art`, `Coll_text`) VALUES ('" + textBox1.Text + "', " + "'" + New.Text + "')");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLClass.Delete("DELETE FROM " + Tables.COLLECTION + " WHERE Coll_Text = '" + comboBox1.Text + "'");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
