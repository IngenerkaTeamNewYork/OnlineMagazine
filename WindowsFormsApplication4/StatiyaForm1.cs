﻿using System;
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
    public partial class StatiyaForm1 : Form
    {

        public StatiyaForm1(statiya stat)
        {
            InitializeComponent();

            Maintext.Text = stat.name_statiya;

            Kategoriatext.Text = stat.kategorita_statii;

            Stattext.Text = stat.text_statii;

            pictureBox1.Image = stat.kartinki_statii[0];

            Authortext.Text = stat.name_author;

            pictureBox1.Load(stat.picture);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Stattext_TextChanged(object sender, EventArgs e)
        {


        

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelreklama_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


