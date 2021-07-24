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
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }

        Sqlbaglantim bgl = new Sqlbaglantim();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

            SqlCommand komut = new SqlCommand("insert into Bolumler (BolumAdi) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("p1",textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
            MessageBox.Show("Yeni Kayıt Eklendi.");
            }
            catch 
            { 
                MessageBox.Show("Hata oluştu. Yeniden kayıt ekle.");
            }
            
        }

        private void frmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", textBox1.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata: İşlem geçekleşmedi.");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox1.Text = id;
            textBox2.Text = bolumad;



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut3 = new SqlCommand("update Bolumler set BolumAdi=@p1 where Bolumid=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", textBox1.Text);
                komut3.Parameters.AddWithValue("@p1", textBox2.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm güncellendi.");
                this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata:");
            }
        }
    }
}
