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
    public struct Reklama
    {
        public DateTime dateFrom; 
        public string text;
    }

    public partial class AdminMainForm : Form
    {
        public List<Reklama> mnogo_reklamy = new List<Reklama>();

        public AdminMainForm()
        {
            InitializeComponent();

            Reklama rek = new Reklama();
            rek.text = "Все козлы. Купите деньги";
            rek.dateFrom = new DateTime(2018, 9, 6);
            mnogo_reklamy.Add(rek);
            Reklama rek2 = new Reklama();
            rek2.text = "Не все козлы. Но деньги купите";
            rek2.dateFrom = new DateTime(2018, 9, 23);
            mnogo_reklamy.Add(rek2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Spisok_reklamy sps = new Spisok_reklamy(mnogo_reklamy);
            sps.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Spisok_reklamy d = new Spisok_reklamy("gryzha");
            //d.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GhostMainForm dd = new GhostMainForm();
            dd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            New_stati fgf = new New_stati();
            fgf.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CategoriesForm form = new CategoriesForm();
            form.ShowDialog();
        }

        private void button_author_Click(object sender, EventArgs e)
        {
            FBIform form = new FBIform();
            form.ShowDialog();
        }

        private void button_statistika_Click(object sender, EventArgs e)
        {
            StastisticsForm form1 = new StastisticsForm(GhostMainForm.stat[0]);
            form1.ShowDialog();
        }

        private void button_list_of_mat_Click(object sender, EventArgs e)
        {

        }

        private void button_categories_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
