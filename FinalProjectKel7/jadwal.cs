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
    
    public partial class jadwal : Form
    {
        private string stringConnection = "Data Source=LAPTOP-G2F55ONU\\EHZANDHERRY;" + "database=DBJadwalAkademik;User ID=sa;Password=Conex999";
        private SqlConnection koneksi;

        public jadwal()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string str = "select id_gedung From dbo.gedung";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            koneksi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            button1.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
