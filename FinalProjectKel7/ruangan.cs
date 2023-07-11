using System;
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
    public partial class ruangan : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=Act6;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public ruangan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ig.Text = "";
            ng.Text = "";
            rg.Text = "";
            ig.Enabled = true;
            ng.Enabled = true;
            rg.Enabled = true;
            btnsv.Enabled = false;
            btnadd.Enabled = false;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_gedung, nama_gedung, ruangan From dbo.Ruangan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void ig_TextChanged(object sender, EventArgs e)
        {
            ig.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruangan r1 = new ruangan();
            r1.Show();
            this.Hide();
        }
    }
}
