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
    public partial class Designer : Form
    {
        public Designer()
        {
            InitializeComponent();
            Configs.read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null)
            {
                this.Close();
            }
            else 
            {
                try 
                {
                    Configs.KOL_VO_ELEMENTOV_Author = Convert.ToInt32(textBox4.Text);
                    Configs.KOL_VO_ELEMENTOV_Categoriya = Convert.ToInt32(textBox1.Text);
                    Configs.KOL_VO_ELEMENTOV_Podborka = Convert.ToInt32(textBox3.Text);
                    Configs.ChR = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Вводи число!");
                }
            }

            File.WriteAllText("Temp.txt", Configs.KOL_VO_ELEMENTOV_Author + Environment.NewLine +
                +Configs.KOL_VO_ELEMENTOV_Categoriya + Environment.NewLine +
                +Configs.KOL_VO_ELEMENTOV_Podborka + Environment.NewLine +
                +Configs.ChR + Environment.NewLine);
        }

        private void Designer_Load(object sender, EventArgs e)
        {

        }

        
    }
}
