using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKaSist
{
    public partial class frmÖdemeler : Form
    {
        public frmÖdemeler()
        {
            InitializeComponent();
        }

        Sqlbaglantim bgl = new Sqlbaglantim();
        private void frmÖdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet3.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtKayitDataSet3.Borclar);
            // TODO: Bu kod satırı 'yurtKayitDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
          //  this.borclarTableAdapter.Fill(this.yurtKayitDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan= dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBox1.Text = id;
            textBox2.Text = ad;
            textBox3.Text = soyad;
            textBox5.Text = kalan;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ödenen tutarı kalan tutardan düşme.
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(textBox4.Text);
            kalan = Convert.ToInt16(textBox5.Text);
            yeniborc = kalan - odenen;
            textBox5.Text = yeniborc.ToString();

            // Yeni tutarı veritabanına kaydetme.
            SqlCommand komut = new SqlCommand("Update Borclar set KalanBorc=@p1 where Ogrenciid=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            komut.Parameters.AddWithValue("@p1", textBox5.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç ödendi.");
            this.borclarTableAdapter1.Fill(this.yurtKayitDataSet3.Borclar);

            //Kasa Tablosuna Ekleme Yapma
            SqlCommand Komut2 = new SqlCommand("insert into Kasa (OdemeAy, OdemeMiktar) values(@k1, @k2)",bgl.baglanti());
            Komut2.Parameters.AddWithValue("@k1",textBox6.Text);
            Komut2.Parameters.AddWithValue("@k2",textBox4.Text);
            Komut2.ExecuteNonQuery();
            bgl.baglanti().Close();


        }
    }
}
