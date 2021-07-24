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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet9.Personeller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personellerTableAdapter.Fill(this.yurtKayitDataSet9.Personeller);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personeller (PersonelAdSoyad, PersonelDepartman) values (@p1, @p2) ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.personellerTableAdapter.Fill(this.yurtKayitDataSet9.Personeller);
            MessageBox.Show("Kayıt eklendi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from  Personeller where Personelid=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.personellerTableAdapter.Fill(this.yurtKayitDataSet9.Personeller);
            MessageBox.Show("Kayıt silindi.");
            

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, personelad, personelgorev;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            personelad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            personelgorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text = id;
            textBox2.Text = personelad;
            textBox3.Text = personelgorev;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personeller set PersonelAdSoyad=@p1, PersonelDepartman=@p2 where Personelid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox2.Text);
            komut.Parameters.AddWithValue("@p2",textBox3.Text);
            komut.Parameters.AddWithValue("@p3",textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi.");
            this.personellerTableAdapter.Fill(this.yurtKayitDataSet9.Personeller);
        }
    }
}
