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
    public partial class SQLParamsForm : Form
    {
        public SQLParamsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLClass.CONNECTION_STRING =
                "SslMode=none;" +
                "Server=db4free.net;" +
                "database=ingenerka;" +
                "port=3306;" +
                "uid=" + textBox1.Text + ";" +
                "pwd=Beavis1989;" +
                "old guids=true;";
            Close();
        }

        private void SQLParamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.OpenConnection();
        }
    }
}
