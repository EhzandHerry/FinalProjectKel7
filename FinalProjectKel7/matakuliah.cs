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

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_matakul, nama_matkul, sks From dbo.Matakuliah";
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

        private void btnsv_Click(object sender, EventArgs e)
        {
            string idMatkul = im.Text;
            string nMatkul = nm.Text;
            string sks = this.sks.Text;


            if (idMatkul == "" || nMatkul == "" || sks == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.prodi (id_matkul, nama_matkul, sks) VALUES (@id_matkul, @nama_matkul, @sks)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_matkul", idMatkul));
                cmd.Parameters.Add(new SqlParameter("@nama_matkul", nMatkul));
                cmd.Parameters.Add(new SqlParameter("@sks", sks));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void sks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnview.Enabled = false;
        }

        private void nm_TextChanged(object sender, EventArgs e)
        {
            nm.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void sks_TextChanged(object sender, EventArgs e)
        {
            sks.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }
    }
}
