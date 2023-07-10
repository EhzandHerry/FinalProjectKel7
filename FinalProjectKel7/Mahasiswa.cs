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
    public partial class Mahasiswa : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=Act6;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public Mahasiswa()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void refreshform()
        {
            nmhs.Text = "";
            imhs.Text = "";
            jk.Text = "";
            nt.Text = "";
            am.Text = "";
            imhs.Enabled = true;
            nmhs.Enabled = true;
            jk.Enabled = true;
            nt.Enabled = true;
            am.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }


    }
}
