using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class LogsReadForm : Form
    {
        public LogsReadForm()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogsReadForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("database.sql", Encoding.UTF8);
            textBox2.Text = File.ReadAllText("ingenerka.sql", Encoding.UTF8);
        }
    }
}
