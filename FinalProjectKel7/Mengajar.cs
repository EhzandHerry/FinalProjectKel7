﻿using System;
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
    public partial class Mengajar : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public Mengajar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            id.Text = "";
            im.Text = "";
            idosen.Text = "";
            id.Enabled = false;
            im.Enabled = false;
            idosen.Enabled = false;
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
            id.Enabled = true;
            im.Enabled = true;
            idosen.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            cbxim();
            cbxid();
        }

        private void cbxim()
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


            im.ValueMember = "id_matakul";
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


            idosen.ValueMember = "id_dosen";
            idosen.DataSource = dt;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_ngajar, id_matakul, id_dosen From dbo.mengajar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string iNgajar = id.Text;
            string iMatakul = im.Text;
            string iDosen = idosen.Text;

            if (iNgajar == "" || iMatakul == "" || iDosen == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.mengajar (id_ngajar, id_matakul, id_dosen) VALUES (@id_ngajar, @id_matakul, @id_dosen)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_ngajar", iNgajar));
                cmd.Parameters.Add(new SqlParameter("@id_matakul", iMatakul));
                cmd.Parameters.Add(new SqlParameter("@id_dosen", iDosen));

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_ngajar"].Value.ToString();
            string iMatkul = im.Text;
            string iDosen = idosen.Text;
           

            if (id == "")
            {
                MessageBox.Show("Id Ngajar tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iMatkul == "")
            {
                MessageBox.Show("Masukkan Id Matakuliah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (iDosen == "")
            {
                MessageBox.Show("Masukkan Dosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "UPDATE mengajar SET id_matakul = @id_matakul, id_dosen = @id_dosen WHERE id_ngajar = @id_ngajar";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_ngajar", id);
                command.Parameters.AddWithValue("@id_matakul", iMatkul);
                command.Parameters.AddWithValue("@id_dosen", iDosen);

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

            string id = dataGridView1.SelectedRows[0].Cells["id_ngajar"].Value.ToString();

            string sql = "DELETE FROM mengajar WHERE id_ngajar = @id_ngajar";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_ngajar", id);

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
