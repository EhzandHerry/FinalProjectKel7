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
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
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
            string str = "select id_mhs, nama_mhs, jenis_kelamin, no_telp, alamat From dbo.mahasiswa";
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
                string str = "insert into dbo.mahasiswa (id_mhs, nama_mhs, jenis_kelamin, no_telp, alamat) VALUES (@id_mhs, @nama_mhs, @jenis_kelamin, @no_telp, @alamat)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_mhs", iMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@nama_mhs", nmMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@jenis_kelamin", jkMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@no_telp", ntMahasiswa));
                cmd.Parameters.Add(new SqlParameter("alamat", almtMahasiswa));
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

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_mhs"].Value.ToString();

            string sql = "DELETE FROM mahasiswa WHERE id_mhs = @id_mhs";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_mhs", id);

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        dataGridView1_CellContentClick();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
