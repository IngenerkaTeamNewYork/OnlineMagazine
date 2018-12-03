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
using System.IO;

using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication4
{
    /// <summary>
    /// Статистика по автору (лайки, просмотры)
    /// </summary>
    public partial class StastisticsForm : Form
    {
        public StastisticsForm(String login)
        {
            InitializeComponent();

            List<String> AuthorsList = SQLClass.Select("SELECT UserName FROM " + Tables.AUTHORS);
            foreach (String Author in AuthorsList)
            {
                list_of_author.Items.Add(Author);
            }

            list_of_author.Text = login;           
        }

        private void list_of_author_SelectedIndexChanged(object sender, EventArgs e)
        {   
            List<String> AuthorData = SQLClass.Select("SELECT * FROM " + Tables.AUTHORS + 
                " WHERE UserName = '" + list_of_author.Text + "'");
            if (AuthorData.Count > 3)
            {
                ViewsCount.Text = AuthorData[1].ToString();
                LikesCount.Text = AuthorData[2].ToString();
                DisLikesCount.Text = AuthorData[3].ToString();
                name_stiatii.Text = list_of_author.Text;
            }
        }

        private void StastisticsForm_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;this.ForeColor = Configs.USER_COLOR;
            List<String> AuthorsData = SQLClass.Select("SELECT UserName, Views, Likes, Dislikes " +	
                " FROM " + Tables.AUTHORS +	
                " ORDER BY UserName");	
            authorsDGV.Rows.Clear();	
            for (int index = 0; index < AuthorsData.Count; index += 4)	
            {	
                authorsDGV.Rows.Add();	
                authorsDGV.Rows[index / 4].Cells[0].Value = AuthorsData[index];	
                authorsDGV.Rows[index / 4].Cells[1].Value = AuthorsData[index + 1];	
                authorsDGV.Rows[index / 4].Cells[2].Value = AuthorsData[index + 2];	
                authorsDGV.Rows[index / 4].Cells[3].Value = AuthorsData[index + 3];	
            }	
             this.Controls.Clear();	
            if (true == true)	
            {	
                this.Controls.Add(authorsDGV);	
            }	
            else	
            {	
                this.Controls.Add(tableLayoutPanel1);	
            }
        }
    }
}
