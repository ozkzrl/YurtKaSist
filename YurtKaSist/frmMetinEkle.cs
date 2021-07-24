using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YurtKaSist
{
    public partial class frmMetinEkle : Form
    {
        public frmMetinEkle()
        {
            InitializeComponent();
        }

        private void frmMetinEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Yeri Seçin.";
            saveFileDialog1.Filter = "Metin Dosyası | *.txt";
            saveFileDialog1.InitialDirectory = "‪C:\\Notlar";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Kayıt eklendi.");
        }
    }
}
