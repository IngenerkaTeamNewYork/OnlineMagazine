﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class Add_Statia : Form
    {
        public string avtor1;
        public string id;
        public Add_Statia(string avtor)
        {
            avtor1 = avtor;
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
              
              //INSERT INTO `Articles`(`Header`, `Text`, `Author`, `Picture`, `Artic_ID`, `Category`, `new`) 
               // VALUES ('fdgdfgdfg', 'fdsgdfsgsdfghsh', 'fdg', 'null', 4, 'Животные', 1)
            MySqlCommand gd = new MySqlCommand("SELECT MAX(Artic_ID + 1) FROM Articles", SQLClass.CONN);
            MySqlDataReader g = gd.ExecuteReader();
            while(g.Read())
            {
                id = Convert.ToString(g[0]);
            }
            g.Close();

            MySqlCommand cmd = new MySqlCommand(
                       "INSERT INTO Articles" + "(Header, Text, Author, Picture, Artic_ID, Category, new)" +
                       " VALUES ('" + textBox2.Text + "'," +
                        "'" +  textBox1.Text + "'," +
                        "'" + avtor1 + "'," +
                        "' null'," +
                        "" + id + "," +
                        "'" + comboBox1.Text + "'," +
                        " 1)", SQLClass.CONN);


            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
             
        }

        private void Add_Statia_Load(object sender, EventArgs e)
        {

        }
         
    }
}