using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Balance_Author : Form
    {
        public string name;
        public Balance_Author(string author)
        {
            this.name = author;
            InitializeComponent();

            update();
        }

        private void Balance_Author_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
            label3.Font = Configs.ZAGOLOVOK_FONT;
            label2.Font = Configs.ZAGOLOVOK_FONT;

            label1.Text = name;
        }

        /// <summary>
        /// Вывод денег
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vyuvod_Denyak_Click(object sender, EventArgs e)
        {
            List<String> AuthorBalance = SQLClass.Select("SELECT Summa FROM " + Tables.BALANCE +
                " WHERE `Author` = '" + name + "'");
            if (AuthorBalance.Count > 0)
            {
                String value = "1";
                try
                {
                    value = SQLClass.Select("SELECT var FROM " + Tables.SETTINGS + " WHERE name='mavrodi'")[0];
                }
                catch (Exception) { }

                if (this.name != value)
                {
                    SQLClass.Update("UPDATE " + Tables.BALANCE +
                        " SET Summa = Summa +" + AuthorBalance[0].ToString() + " WHERE Author = '" + SQLClass.Select("SELECT var WHERE name='mavrodi'")[0] + "'");
                    SQLClass.Update("UPDATE " + Tables.BALANCE +
                        " SET Summa = 0 WHERE Author = '" + name + "'");
                }
            }

            update();
        }

        public void update()
        {
            List<String> AuthorBalance = SQLClass.Select("SELECT Summa FROM " + Tables.BALANCE +
                " WHERE `Author` = '" + name + "'");
            if (AuthorBalance.Count > 0)
            {
                label4.Text = AuthorBalance[0].ToString(); 
            }

            Balance_Author_Load(null, null);
         }
      }
 }

