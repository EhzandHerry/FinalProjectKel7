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
    public partial class PengambilanMatkul : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public PengambilanMatkul()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ia.Text = "";
            im.Text = "";
            ido.Text = "";
            im2.Text = "";
            ia.Enabled = false;
            im.Enabled = false;
            ido.Enabled = false;
            im2.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnview.Enabled = false;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_ambil, id_mhs, id_dosen, id_matakul From dbo.pengambilanmatkul";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
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

        private void cbxid()
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


            ido.ValueMember = "id_dosen";
            ido.DataSource = dt;
        }

        private void cbxmatakul()
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


            im2.ValueMember = "id_matakul";
            im2.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iAmbil = ia.Text;
            string iMahasiswa = im.Text;
            string iDosen = ido.Text;
            string iMatakul = im2.Text;

            if (iAmbil == "" || iMahasiswa == "" || iDosen == "" || iMatakul == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.pengambilanmatkul (id_ambil, id_mhs, id_dosen, id_matakul) VALUES (@id_ambil, @id_mhs, @id_dosen, @id_matakul)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_ambil", iAmbil));
                cmd.Parameters.Add(new SqlParameter("@id_mhs", iMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@id_dosen", iDosen));
                cmd.Parameters.Add(new SqlParameter("@id_matakul", iMatakul));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ia.Enabled = true;
            im.Enabled = true;
            ido.Enabled = true;
            im2.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            cbxim();
            cbxid();
            cbxmatakul();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_ambil"].Value.ToString();
            string iMahasiswa = im.Text;
            string iDosen = ido.Text;
            string iMatkul = im2.Text;
            

            if (id == "")
            {
                MessageBox.Show("Id Ambil tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iMahasiswa == "")
            {
                MessageBox.Show("Masukkan Id Mahasiswa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iDosen == "")
            {
                MessageBox.Show("Masukkan Dosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iMatkul == "")
            {
                MessageBox.Show("Masukkan Matakuliah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE pengambilanmatkul SET id_mhs = @id_mhs, id_dosen = @id_dosen, id_matakul = @id_matakul WHERE id_ambil = @id_ambil";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_ambil", id);
                command.Parameters.AddWithValue("@id_mhs", iMahasiswa);
                command.Parameters.AddWithValue("@id_dosen", iDosen);
                command.Parameters.AddWithValue("@id_matakul", iMatkul);
              

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

            string id = dataGridView1.SelectedRows[0].Cells["id_ambil"].Value.ToString();

            string sql = "DELETE FROM pengambilanmatkul WHERE id_ambil = @id_ambil";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_ambil", id);

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
