using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Dostalo : Form
    {
        public Dostalo()
        {
            InitializeComponent();
        }


        private void dethArticle_Click(object sender, EventArgs e)
        {
            List<String> stat = SQLClass.Select("SELECT Header FROM " + Tables.ARTICLES);

            
            Random rnd = new Random();
            int v = rnd.Next(1, stat.Count);
            String authorstat = stat[v - 1];

            if (MessageBox.Show("Уничтожить статью  " + authorstat + "",
                "Вопрос",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQLClass.Delete("DELETE FROM " + Tables.READ_OF_ARTICLES + " WHERE name_of_article = '" + authorstat + "'");
                //SQLClass.Delete("DELETE FROM " + Tables.ARTICLES + " WHERE Header = '" + authorstat + "'");
            }

        }

        private void Dostalo_Load(object sender, EventArgs e)
        {

        }

        private void dethauthor_Click_1(object sender, EventArgs e)
        {
            List<String> autPics = SQLClass.Select("SELECT UserName FROM " + Tables.AUTHORS + " WHERE Pic != ''");

            Random rnd = new Random();
            int v = rnd.Next(1, autPics.Count);
            String authorLogin = autPics[v - 1];

            if (MessageBox.Show("Ограбить пользователя " + authorLogin + "",
                "Вопрос",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQLClass.Update("UPDATE " + Tables.BALANCE +
                    " SET Summa = 0 WHERE Author = '" + authorLogin + "'");
            }

        }

        private void Hohlov_is_dead_Click(object sender, EventArgs e)
        {
            List<String> autPics = SQLClass.Select("SELECT UserName FROM " + Tables.AUTHORS + " WHERE UserName IN ('Хохлов', 'УКРАIНЕЦ', 'Данил') ");

            Random rnd = new Random();
            int v = rnd.Next(1, autPics.Count);
            String authorLogin = autPics[v - 1];

            if (MessageBox.Show("УБЕЙ САЛОПОТРЕБИТЕЛЯ " + authorLogin + "",
                "Вопрос",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQLClass.Update("UPDATE " + Tables.BALANCE +
                    " SET Summa = 0 WHERE Author = '" + authorLogin + "'");
            }
        }

    }
}
