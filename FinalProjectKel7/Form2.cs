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
    public partial class Form2 : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            id.Text = "";
            nd.Text = "";
            nt.Text = "";
            ad.Text = "";
            id.Enabled = true;
            nd.Enabled = true;
            nt.Enabled = true;
            ad.Enabled = true;
            btnsv.Enabled = false;
            btnc.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_dosen, nama_dosen, no_telp, alamat From dbo.dosen";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            string idDosen = id.Text;
            string nDosen = nd.Text;
            string ntDosen = nt.Text;
            string aDosen = ad.Text;


            if (idDosen == "" || nDosen == "" || ntDosen == "" || aDosen == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.dosen (id_dosen, nama_dosen, no_telp, alamat) VALUES (@id_dosen, @nama_dosen, @no_telp, @alamat)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id_dosen", idDosen));
                cmd.Parameters.Add(new SqlParameter("@nama_dosen", nDosen));
                cmd.Parameters.Add(new SqlParameter("@no_telp", ntDosen));
                cmd.Parameters.Add(new SqlParameter("@alamat", aDosen));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                dataGridView1_CellContentClick();
                refreshform();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnview.Enabled = false;
        }

        private void nd_TextChanged(object sender, EventArgs e)
        {
            nd.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void nt_TextChanged(object sender, EventArgs e)
        {
            nt.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void ad_TextChanged(object sender, EventArgs e)
        {
            ad.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.SelectedRows[0].Cells["id_dosen"].Value.ToString();

            string sql = "DELETE FROM dosen WHERE id_dosen = @id_dosen";
            using (SqlCommand command = new SqlCommand(sql, koneksi))
            {
                command.Parameters.AddWithValue("@id_dosen", id);

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
