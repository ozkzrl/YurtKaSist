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
    public partial class frmYöneticiİslemleri : Form
    {
        public frmYöneticiİslemleri()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();

        private void frmYöneticiİslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet7.Admin' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminTableAdapter.Fill(this.yurtKayitDataSet7.Admin);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Admin (YoneticiAd, YoneticiSifre) values (@p1, @p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2",textBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Kayıt Eklendi.");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet7.Admin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where Yoneticiid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Kayıt Silindi.");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet7.Admin);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text = id;
            textBox2.Text = ad;
            textBox3.Text = sifre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1, YoneticiSifre=@p2 where Yoneticiid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p3", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme gerçekleşti.");
            this.adminTableAdapter.Fill(this.yurtKayitDataSet7.Admin);
        }
    }
}
