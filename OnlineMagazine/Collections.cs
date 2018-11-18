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
            List<String> ArticlesList = SQLClass.Select("SELECT Header FROM " + Tables.ARTICLES);
            foreach (String article in ArticlesList)
            {
                checkedListBox1.Items.Add(article);
            }
        }
    }
}
