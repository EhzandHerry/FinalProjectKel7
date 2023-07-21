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
    public partial class Bimbingan : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public Bimbingan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ib.Text = "";
            im.Text = "";
            ido.Text = "";
            h.Text = "";
            j.Text = "";
            h2.Text = "";
            ib.Enabled = false;
            im.Enabled = false;
            ido.Enabled = false;
            h.Enabled = false;
            j.Enabled = false;
            h2.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void im_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ib.Enabled = true;
            im.Enabled = true;
            ido.Enabled = true;
            h.Enabled = true;
            j.Enabled = true;
            h2.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            cbxim();
            cbxid();
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_bimbing, id_mhs, id_dosen, hari, jam, hasil From dbo.bimbingan";
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

        private void btnview_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnview.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iBimbing = ib.Text;
            string iMahasiswa = im.Text;
            string iDosen = ido.Text;
            string hari = h.Text;
            string jam = j.Text;
            string hasil = h2.Text;


            if (iBimbing == "" || iMahasiswa == "" || iDosen == "" || hari == "" || jam == "" || hasil == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.bimbingan (id_bimbing, id_mhs, id_dosen, hari, jam, hasil) VALUES (@id_bimbing, @id_mhs, @id_dosen, @hari, @jam, @hasil)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_bimbing", iBimbing));
                cmd.Parameters.Add(new SqlParameter("@id_mhs", iMahasiswa));
                cmd.Parameters.Add(new SqlParameter("@id_dosen", iDosen));
                cmd.Parameters.Add(new SqlParameter("@hari", hari));
                cmd.Parameters.Add(new SqlParameter("@jam", jam));
                cmd.Parameters.Add(new SqlParameter("@hasil", hasil));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void Bimbingan_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_bimbing"].Value.ToString();

            string sql = "DELETE FROM bimbingan WHERE id_bimbing = @id_bimbing";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_bimbing", id);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_bimbing"].Value.ToString();
            string iMahasiswa = im.Text;
            string iDosen = ido.Text;
            string hari = h.Text;
            string jam = j.Text;
            string hasil = h2.Text;

            if (id == "")
            {
                MessageBox.Show("Id Bimbing tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (hari == "")
            {
                MessageBox.Show("Masukkan Hari", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (jam == "")
            {
                MessageBox.Show("Masukkan Jam", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (hasil == "")
            {
                MessageBox.Show("Masukkan Hasil", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE bimbingan SET id_mhs = @id_mhs, id_dosen = @id_dosen, hari = @hari, jam = @jam, hasil = @hasil WHERE id_bimbing = @id_bimbing";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_bimbing", id);
                command.Parameters.AddWithValue("@id_mhs", iMahasiswa);
                command.Parameters.AddWithValue("@id_dosen", iDosen);
                command.Parameters.AddWithValue("@hari", hari);
                command.Parameters.AddWithValue("@jam", jam);
                command.Parameters.AddWithValue("@hasil", hasil);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
