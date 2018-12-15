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
            if (categoryTextBox.Text == null && 
                reklamatextBox.Text == null && 
                PodborkatextBox.Text == null && 
                authorsTextBox.Text == null && 
                textBox5.Text == null)
            {
                this.Close();
            }
            else 
            {
                try
                {
                    SQLClass.Update("UPDATE " + Tables.SETTINGS + " SET var = '" + textBox5.Text + "' WHERE name='mavrodi'");
        
                    Configs.KOL_VO_ELEMENTOV_Author = Convert.ToInt32(authorsTextBox.Text);
                    Configs.KOL_VO_ELEMENTOV_Categoriya = Convert.ToInt32(categoryTextBox.Text);
                    Configs.KOL_VO_ELEMENTOV_Podborka = Convert.ToInt32(PodborkatextBox.Text);
                    Configs.ChR = Convert.ToInt32(reklamatextBox.Text);              
                }
                catch
                {
                    MessageBox.Show("Вводи число!");
                }
            }

            File.WriteAllText("Temp.txt", 
                "AUTHOR = " + Configs.KOL_VO_ELEMENTOV_Author + Environment.NewLine +
                "CATEGORIES = " + Configs.KOL_VO_ELEMENTOV_Categoriya + Environment.NewLine +
                "COLLECTIONS = " + Configs.KOL_VO_ELEMENTOV_Podborka + Environment.NewLine +
                "CHR = " + Configs.ChR + Environment.NewLine);
        }

        private void Designer_Load(object sender, EventArgs e)
        {
            authorsTextBox.Text = Configs.KOL_VO_ELEMENTOV_Author.ToString();
            categoryTextBox.Text = Configs.KOL_VO_ELEMENTOV_Categoriya.ToString();
            PodborkatextBox.Text = Configs.KOL_VO_ELEMENTOV_Podborka.ToString();
            reklamatextBox.Text = Configs.ChR.ToString();


            textBox5.Text = "1";
            try
            {
                textBox5.Text = SQLClass.Select("SELECT var FROM " + Tables.SETTINGS + " WHERE name='mavrodi'")[0];
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void PodborkatextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
