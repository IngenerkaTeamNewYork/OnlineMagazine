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
    public partial class StatiyaForm1 : Form
    {
        public StatiyaForm1(String maintext, String kategoriatext, String stattext)
        {
            InitializeComponent();

            
            Maintext.Text = maintext;
           
            Kategoriatext.Text = kategoriatext;
           
            Stattext.Text = stattext;


        }

        private void StatiyaForm1_Load(object sender, EventArgs e)
        {

        }

        private void Maintext_Click(object sender, EventArgs e)
        {

        }

        private void ImageMain_Click(object sender, EventArgs e)
        {
            

        }
    }
}
