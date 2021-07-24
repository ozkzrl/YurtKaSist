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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       Sqlbaglantim bgl=new Sqlbaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select BolumAdi from Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select OdaNo from Odalar where OdaKapasite !=OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBox2.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrAd, OgrSoyad, OgrTc, OgrTelefon, OgrDogum, OgrBolum, OgrMail, OgrOdaNo, OgrVeliAdSoyad, OgrVeliTelefon,  OgrVeliAdres) values (@OgrAd, @OgrSoyad, @OgrTc, @OgrTelefon, @OgrDogum, @OgrBolum, @OgrMail, @OgrOdaNo, @OgrVeliAdSoyad, @OgrVeliTelefon,  @OgrVeliAdres)", bgl.baglanti());
                komut.Parameters.AddWithValue("@OgrAd", textBox1.Text);
                komut.Parameters.AddWithValue("@OgrSoyad", textBox2.Text);
                komut.Parameters.AddWithValue("@OgrTc", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@OgrTelefon", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@OgrDogum", maskedTextBox3.Text);
                komut.Parameters.AddWithValue("@OgrBolum", comboBox1.Text);
                komut.Parameters.AddWithValue("@OgrMail", textBox3.Text);
                komut.Parameters.AddWithValue("@OgrOdaNo", comboBox2.Text);
                komut.Parameters.AddWithValue("@OgrVeliAdSoyad", textBox4.Text);
                komut.Parameters.AddWithValue("@OgrVeliTelefon", maskedTextBox4.Text);
                komut.Parameters.AddWithValue("@OgrVeliAdres", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi.");


                //Öğrenci id'yi Label'a Çekme.
                SqlCommand komut3 = new SqlCommand("Select Ogrid from Ogrenci",bgl.baglanti());
                SqlDataReader oku = komut3.ExecuteReader();
                while(oku.Read())
                {

                    label12.Text = oku[0].ToString();

                }

                    


         
                //Öğrenci Borç Alanı Oluşturma.
                SqlCommand komut2 = new SqlCommand("insert into Borclar (Ogrenciid, OgrAd, OgrSoyad) values(@p1, @p2, @P3)",bgl.baglanti());
                komut2.Parameters.AddWithValue("p1", label12.Text);
                komut2.Parameters.AddWithValue("p2", textBox1.Text);
                komut2.Parameters.AddWithValue("p3", textBox2.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Öğrenci Oda Kontejanı Arttırma.
                SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@Oda1", bgl.baglanti());
                komutoda.Parameters.AddWithValue("@Oda1",comboBox2.Text);
                komutoda.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi.");    
            }
           
        }
    }
}
