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
                "Server=" + textBox3.Text + "" +
                "database=ingenerka;" +
                "port=3306;" +
                "uid=" + textBox1.Text + ";" +
                "pwd=" + textBox2.Text + ";" +
                "old guids=true;";
            Close();
        }

        private void SQLParamsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.OpenConnection();
        }

        private void SQLParamsForm_Load(object sender, EventArgs e)
        {
            String[] parts = SQLClass.CONNECTION_STRING.Split(new string[] { ";", "="}, StringSplitOptions.None);

            for (int index = 0; index < parts.Length; index = index + 1)
            {
                if (parts[index] == "uid")
                {
                    textBox1.Text = parts[index + 1];
                }
                
                if (parts[index] == "pwd")
                { 
                    textBox2.Text = parts[index + 1]; 
                }

                if (parts[index] == "Server") 
                {
                    textBox3.Text = parts[index + 1];
                }
            }
        }


    }
}
