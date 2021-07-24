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
    public partial class frmOgrListe : Form
    {
        public frmOgrListe()
        {
            InitializeComponent();
        }

        private void frmOgrListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet11.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter3.Fill(this.yurtKayitDataSet11.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayitDataSet10.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter2.Fill(this.yurtKayitDataSet10.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayitDataSet5.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter1.Fill(this.yurtKayitDataSet5.Ogrenci);
            // TODO: Bu kod satırı 'yurtKayitDataSet4.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmOgrDuzenle fr = new frmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.veliad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
