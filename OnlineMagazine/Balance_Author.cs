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
            name = author;
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

            label4.Text = "0";
            
        }

        private void Vyuvod_Denyak_Click(object sender, EventArgs e)
        {
           // UPDATE `Balance` SET `Summa` = 10 WHERE Author = 'Еж'
            SQLClass.Update("UPDATE `Balance` SET `Summa` = 0 WHERE Author = '" + name + "'");
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

