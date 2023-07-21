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
    public partial class PilihGedung : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public PilihGedung()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ig.Text = "";
            ig2.Text = "";
            ing.Text = "";
            ig.Enabled = false;
            ig2.Enabled = false;
            ing.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ig.Enabled = true;
            ig2.Enabled = true;
            ing.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            cbxg();
            cbxn();
        }

        private void cbxg()
        {
            koneksi.Open();
            string query = "SELECT id_gedung FROM gedung";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_gedung");


            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_gedung"] = reader["id_gedung"].ToString();

                dt.Rows.Add(row);
            }

            koneksi.Close();


            ig2.ValueMember = "id_gedung";
            ig2.DataSource = dt;
        }

        private void cbxn()
        {
            koneksi.Open();
            string query = "SELECT id_ngajar FROM mengajar";
            SqlCommand cmd = new SqlCommand(query, koneksi);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("id_ngajar");


            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["id_ngajar"] = reader["id_ngajar"].ToString();

                dt.Rows.Add(row);
            }

            koneksi.Close();


            ing.ValueMember = "id_ngajar";
            ing.DataSource = dt;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_gunakan, id_gedung, id_ngajar From dbo.menggunakangedung";
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
            string iGunakan = ig.Text;
            string iGedung = ig2.Text;
            string iNgajar = ing.Text;

            if (iGunakan == "" || iGedung == "" || iNgajar == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.menggunakangedung (id_gunakan, id_gedung, id_ngajar) VALUES (@id_gunakan, @id_gedung, @id_ngajar)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_gunakan", iGunakan));
                cmd.Parameters.Add(new SqlParameter("@id_gedung", iGedung));
                cmd.Parameters.Add(new SqlParameter("@id_ngajar", iNgajar));

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

            string id = dataGridView1.SelectedRows[0].Cells["id_gedung"].Value.ToString();
            string iGedung = ig2.Text;
            string iNgajar = ing.Text;
            
            if (id == "")
            {
                MessageBox.Show("Id Gunakan tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iGedung == "")
            {
                MessageBox.Show("Masukkan Id Gedung", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iNgajar == "")
            {
                MessageBox.Show("Masukkan Ngajar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            string sql = "UPDATE menggunakangedung SET id_gedung = @id_gedung, id_ngajar = @id_ngajar WHERE id_gunakan = @id_gunakan";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_gunakan", id);
                command.Parameters.AddWithValue("@id_gedung", iGedung);
                command.Parameters.AddWithValue("@id_ngajar", iNgajar);

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

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_gunakan"].Value.ToString();

            string sql = "DELETE FROM menggunakangedung WHERE id_gunakan = @id_gunakan";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_gunakan", id);

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
