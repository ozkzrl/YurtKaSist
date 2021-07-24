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
    public partial class frmGider : Form
    {
        public frmGider()
        {
            InitializeComponent();
        }
        Sqlbaglantim bgl = new Sqlbaglantim();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            SqlCommand komut = new SqlCommand("insert into Giderler(Elektirik, Su, Dogalgaz, İnternet, Gıda, Personel, Diger) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.Parameters.AddWithValue("@p5", textBox5.Text);
            komut.Parameters.AddWithValue("@p6", textBox6.Text);
            komut.Parameters.AddWithValue("@p7", textBox7.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
                MessageBox.Show("Yeni Kayıt Eklendi.");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata, yeniden deneyin.");
            }
            
           
        }
    }
}
