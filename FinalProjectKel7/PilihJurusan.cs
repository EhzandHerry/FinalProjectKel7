using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectKel7
{
    public partial class PilihJurusan : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public PilihJurusan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ip.Text = "";
            im.Text = "";
            ij.Text = "";
            ip.Enabled = false;
            im.Enabled = false;
            ip.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void PilihJurusan_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ip.Enabled = true;
            im.Enabled = true;
            ij.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            cbxim();
            cbxj();
        }

        private void cbxim()
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


            im.ValueMember = "id_mhs";
            im.DataSource = dt;
        }
        private void cbxj()
        {
            koneksi.Open();
            string query = "SELECT id_jurusan FROM jurusan";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_jurusan");


            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_jurusan"] = reader["id_jurusan"].ToString();

                dt.Rows.Add(row);
            }

            koneksi.Close();


            ij.ValueMember = "id_jurusan";
            ij.DataSource = dt;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_pilih, id_mhs, id_jurusan From dbo.pilihjurusan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnview.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iPilih = ip.Text;
            string iMahasiswa = im.Text;
            string iJurusan = ij.Text;

            if (iPilih == "" || iMahasiswa == "" || iJurusan == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.pilihjurusan (id_pilih, id_mhs, id_jurusan) VALUES (@id_pilih, @id_mhs, @id_jurusan)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_pilih", iPilih));
                cmd.Parameters.Add(new SqlParameter("@id_mhs", iMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@id_jurusan", iJurusan));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_pilih"].Value.ToString();
            string iMahasiswa = im.Text;
            string iJurusan = ij.Text;
            

            if (id == "")
            {
                MessageBox.Show("Id pilih tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iMahasiswa == "")
            {
                MessageBox.Show("Masukkan Id Mahasiswa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iJurusan == "")
            {
                MessageBox.Show("Masukkan Jurusan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            string sql = "UPDATE pilihjurusan SET id_mhs = @id_mhs, id_jurusan = @id_jurusan WHERE id_pilih = @id_pilih";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_pilih", id);
                command.Parameters.AddWithValue("@id_mhs", iMahasiswa);
                command.Parameters.AddWithValue("@id_jurusan", iJurusan);
            

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        dataGridView1_CellContentClick();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_pilih"].Value.ToString();

            string sql = "DELETE FROM pilihjurusan WHERE id_pilih = @id_pilih";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_pilih", id);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
