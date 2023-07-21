using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectKel7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matakuliah m1 = new matakuliah();
            m1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruangan r1 = new ruangan();
            r1.Show();
            this.Hide();
        }

        

        private void mengajarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mengajar m1 = new Mengajar();
            m1.Show();
            this.Hide();
        }

        private void pemilihanGedungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilihGedung p1 = new PilihGedung();
            p1.Show();
            this.Hide();
        }

        private void pengambilanMatakuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengambilanMatkul p2 = new PengambilanMatkul();
            p2.Show();
            this.Hide();
        }

        private void bimbinganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bimbingan b1 = new Bimbingan();
            b1.Show();
            this.Hide();
        }

        private void pilihJurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilihJurusan p3 = new PilihJurusan();
            p3.Show();
            this.Hide();
        }
    }
}
