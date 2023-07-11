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
    public partial class matakuliah : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=Act6;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public matakuliah()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            im.Text = "";
            nm.Text = "";
            sks.Text = "";
            im.Enabled = true;
            nm.Enabled = true;
            sks.Enabled = true;
            btnsv.Enabled = false;
            btnadd.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select id_matakul, nama_matkul From dbo.matakuliah";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            im.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            matakuliah m1 = new matakuliah();
            m1.Show();
            this.Hide();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
