﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectKel7
{
    public partial class Form3 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=Act6;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ij.Text = "";
            nj.Text = "";
            ij.Enabled = true;
            nj.Enabled = true;
            btnsave.Enabled = false;
            btnadd.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
