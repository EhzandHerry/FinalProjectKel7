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
    public partial class Form2 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=Act6;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            id.Text = "";
            nd.Text = "";
            nt.Text = "";
            ad.Text = "";
            id.Enabled = true;
            nd.Enabled = true;
            nt.Enabled = true;
            ad.Enabled = true;
            btnsv.Enabled = false;
            btnadd.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_dosen, nama_dosen, no_telp, alamat From dbo.dosen";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }
    }
}
