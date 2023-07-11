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
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=Act6;User ID=sa;Password=Conex999";
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
            btnadd.Enabled = false;
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_gedung, nama_gedung, ruangan From dbo.Ruangan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            koneksi.Close();
        }

        private void ig_TextChanged(object sender, EventArgs e)
        {
            ig.Enabled = true;
            btnsv.Enabled = true;
            btnc.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruangan r1 = new ruangan();
            r1.Show();
            this.Hide();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            string idGedung = ig.Text;
            string nGedung = ng.Text;
            string ruangan = this.rg.Text;


            if (idGedung == "" || nGedung == "" || ruangan == "")
            {
                MessageBox.Show("Masukkan Semuanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.prodi (id_gedung, nama_gedung, ruangan) VALUES (@id_gedung, @nama_gedung, @ruangan)";
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
    }
}
