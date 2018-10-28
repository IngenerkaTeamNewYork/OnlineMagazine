﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication4
{

    public partial class StastisticsForm : Form
    {
        //public static List<AuthorStat> stat = new List<AuthorStat>();
        public StastisticsForm(String login) //AuthorStat stata)
        {
            InitializeComponent();


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `Authors`", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                list_of_author.Items.Add(rdr[0].ToString());
            }
            rdr.Close();

            list_of_author.Text = login;           
        }

        private void StastisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void list_of_author_SelectedIndexChanged(object sender, EventArgs e)
        {   
            MySqlCommand cmd = 
                new MySqlCommand("SELECT * FROM `Authors` WHERE UserName = '" + list_of_author.Text + "'", SQLClass.CONN);
            MySqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                ViewsCount.Text = rdr[1].ToString();
                LikesCount.Text = rdr[2].ToString();
                DisLikesCount.Text = rdr[3].ToString();
                name_stiatii.Text = list_of_author.Text;
            }
            rdr.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }



       
    }
}
