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
    public partial class ruangan : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public ruangan()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ig.Text = "";
            ng.Text = "";
            rg.Text = "";
            ig.Enabled = true;
            ng.Enabled = true;
            rg.Enabled = true;
            btnsv.Enabled = false;
            btnc.Enabled = false;
        }

        

        private void ig_TextChanged(object sender, EventArgs e)
        {
            ig.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        

        private void btnc_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            string idGedung = ig.Text;
            string nGedung = ng.Text;
            string ruangan = rg.Text;


            if (idGedung == "" || nGedung == "" || ruangan == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.gedung (id_gedung, nama_gedung, ruangan) VALUES (@id_gedung, @nama_gedung, @ruangan)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_gedung", idGedung));
                cmd.Parameters.Add(new SqlParameter("@nama_gedung", nGedung));
                cmd.Parameters.Add(new SqlParameter("@ruangan", ruangan));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnview.Enabled = false;
        }

        private void ng_TextChanged(object sender, EventArgs e)
        {
            ng.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void rg_TextChanged(object sender, EventArgs e)
        {
            rg.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_gedung, nama_gedung, ruangan From dbo.gedung";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_gedung"].Value.ToString();

            string sql = "DELETE FROM gedung WHERE id_gedung = @id_gedung";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_gedung", id);

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

            string id = dataGridView1.SelectedRows[0].Cells["id_gedung"].Value.ToString();
            string nGedung = ng.Text;
            string ruangan = rg.Text;

            if (id == "")
            {
                MessageBox.Show("Id Gedung tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nGedung == "")
            {
                MessageBox.Show("Masukkan Nama Gedung", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ruangan == "")
            {
                MessageBox.Show("Masukkan Nama Ruangan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string sql = "UPDATE gedung SET nama_gedung = @nama_gedung, ruangan = @ruangan WHERE id_gedung = @id_gedung";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_gedung", id);
                command.Parameters.AddWithValue("@nama_gedung", nGedung);
                command.Parameters.AddWithValue("@ruangan", ruangan);

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
    }
}
