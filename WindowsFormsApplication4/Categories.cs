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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        public static List<String> CategoriesList = new List<string>(new string [] { });
        public string text;
        private void button1_Click(object sender, EventArgs e)
        {

            Label newlabel = new Label();
            newlabel.Top = 400;
            newlabel.Text = "dfgdfg";
            this.Controls.Add(newlabel);

            CategoriesList.Add(text);
        }
    }
}
