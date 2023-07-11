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
    public partial class Form3 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            ij.Text = "";
            nj.Text = "";
            ij.Enabled = true;
            nj.Enabled = true;
            btnsave.Enabled = false;
            btnc.Enabled = false;
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void ij_TextChanged(object sender, EventArgs e)
        {
            ij.Enabled = true;
            btnsave.Enabled = true;
            btnc.Enabled = true;
        }








        private void btnc_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string idJurusan = ij.Text;
            string nJurusan = nj.Text;


            if (idJurusan == "" || nJurusan == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.jurusan (id_jurusan, nama_jurusan) VALUES (@id_jurusan, @nama_jurusan)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_jurusan", idJurusan));
                cmd.Parameters.Add(new SqlParameter("@nama_Jurusan", nJurusan));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick_1();
                refreshform();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick_1();
            btnview.Enabled = false;
        }

        private void nj_TextChanged(object sender, EventArgs e)
        {
            nj.Enabled = true;
            btnsave.Enabled = true;
            btnc.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1()
        {
            koneksi.Open();
            string str = "select id_jurusan, nama_jurusan From dbo.jurusan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_jurusan"].Value.ToString();

            string sql = "DELETE FROM jurusan WHERE id_jurusan = @id_jurusan";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_jurusan", id);

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        dataGridView1_CellContentClick_1();
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

            string id = dataGridView1.SelectedRows[0].Cells["id_jurusan"].Value.ToString();
            string nJurusan = nj.Text;

            if (id == "")
            {
                MessageBox.Show("Id Jurusan tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nJurusan == "")
            {
                MessageBox.Show("Masukkan NamaJurusan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            string sql = "UPDATE jurusan SET nama_jurusan = @nama_jurusan WHERE id_jurusan = @id_jurusan";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_jurusan", id);
                command.Parameters.AddWithValue("@nama_jurusan", nJurusan);

                try
                {
                    koneksi.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        koneksi.Close();
                        refreshform();
                        dataGridView1_CellContentClick_1();
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
