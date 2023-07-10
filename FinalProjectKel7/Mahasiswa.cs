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

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_mhs, nama_mhs, jk_mhs, nt_mahasiswa, almt_mhs From dbo.mahasiswa";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmMahasiswa = nmhs.Text;
            string iMahasiswa = imhs.Text;
            string jkMahasiswa = jk.Text;
            string ntMahasiswa = nt.Text;
            string almtMahasiswa = am.Text;


            if (nmMahasiswa == "" || iMahasiswa == "" || jkMahasiswa == "" || ntMahasiswa == "" || almtMahasiswa == "")
            {
                MessageBox.Show("Masukkan Keduanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.prodi (id_mahasiswa, nama_mahasiswa, jk_mahasiswa, notelp_mahasiswa, alamat_mahasiswa) VALUES (@id_prodi, @nama_prodi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_mahasiswa", iMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@nama_mahasiswa", nmMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@jk_mahasiswa", jkMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@notelp_mahasiswa", ntMahasiswa));
                    cmd.Parameters.Add(new SqlParameter("alamat_mahasiswa", almtMahasiswa));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnView.Enabled = false;
        }

        private void imhs_TextChanged(object sender, EventArgs e)
        {
            imhs.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void nmhs_TextChanged(object sender, EventArgs e)
        {
            nmhs.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void jk_SelectedIndexChanged(object sender, EventArgs e)
        {
            jk.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void nt_TextChanged(object sender, EventArgs e)
        {
            nt.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void am_TextChanged(object sender, EventArgs e)
        {
            am.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }
    }
}
