using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKaSist
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }

        private void öğrenciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrListe ogrlist = new frmOgrListe();
            ogrlist.ShowDialog();

        }

        private void iSTATİSTİKLERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaform_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet1.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.yurtKayitDataSet1.Ogrenci);
            timer1.Start();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Mspaint.exe");
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://radyo.itu.edu.tr/ITU_Radio_Classic.asx";
        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://cast1.taksim.fm:8000";
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://88.255.140.50:88/broadware.m3u?src=1&rate=1";
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 gr = new Form1();
            gr.ShowDialog();
        }

        private void öğrenciListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrListe lst = new frmOgrListe();
            lst.ShowDialog();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumler blmlr = new frmBolumler();
            blmlr.ShowDialog();

        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumler blm = new frmBolumler();
            blm.ShowDialog();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÖdemeler odm = new frmÖdemeler();
            odm.ShowDialog();

        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGider gdr = new frmGider();
            gdr.ShowDialog();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderlerListesi gdrlist = new frmGiderlerListesi();
            gdrlist.ShowDialog();

        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirİstatistik frmglrist = new frmGelirİstatistik();
            frmglrist.ShowDialog();
        }
        
        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYöneticiİslemleri ynt = new frmYöneticiİslemleri();
            ynt.ShowDialog();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonel prs = new frmPersonel();
            prs.ShowDialog();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetinEkle frmmtekle = new frmMetinEkle();
            frmmtekle.ShowDialog();
        }
    }
}
