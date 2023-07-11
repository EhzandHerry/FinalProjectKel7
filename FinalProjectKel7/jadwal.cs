using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectKel7
{
    
    public partial class jadwal : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public jadwal()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void refreshform()
        {
            ij.Text = "";
            nh.Text = "";
            ij.Enabled = true;
            nh.Enabled = true;
            cbxMhs.Enabled = false;
            cbxD.Enabled = false;
            cbxMatkul.Enabled = false;
            cbxJ.Enabled = false;
            cbxG.Enabled = false;
            btnsv.Enabled = false;
            btnc.Enabled = false;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_gedung From dbo.gedung";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnView.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxmhs();
            cbxd();
            cbxmatkul();
        }

        private void cbxmhs()
        {
            koneksi.Open();
            string query = "SELECT id_mhs FROM mahasiswa";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_mhs");

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_mhs"] = reader["id_mhs"].ToString();
                dt.Rows.Add(row);
            }

            koneksi.Close();

            cbxMhs.DisplayMember = "id_mhs";
            cbxMhs.ValueMember = "id_mhs";
            cbxMhs.DataSource = dt;
        }

        private void cbxd()
        {
            koneksi.Open();
            string query = "SELECT id_dosen FROM dosen";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_dosen");

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_dosen"] = reader["id_dosen"].ToString();
                dt.Rows.Add(row);
            }

            koneksi.Close();

            cbxD.DisplayMember = "id_dosen";
            cbxD.ValueMember = "id_dosen";
            cbxD.DataSource = dt;
        }

        private void cbxmatkul()
        {
            koneksi.Open();
            string query = "SELECT id_matakul FROM matakuliah";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_matakul");

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_matakul"] = reader["id_matakul"].ToString();
                dt.Rows.Add(row);
            }

            koneksi.Close();

            cbxMatkul.DisplayMember = "id_matakul";
            cbxMatkul.ValueMember = "id_matakul";
            cbxMatkul.DataSource = dt;
        }

    }
}
