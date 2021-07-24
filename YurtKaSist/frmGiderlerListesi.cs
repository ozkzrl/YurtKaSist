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
    public partial class frmGiderlerListesi : Form
    {
        public frmGiderlerListesi()
        {
            InitializeComponent();
        }

        private void frmGiderlerListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtKayitDataSet6.Giderler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderlerTableAdapter.Fill(this.yurtKayitDataSet6.Giderler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int secilen;
            frmGiderGuncelle frg = new frmGiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.elektirik= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.diger = dataGridView1.Rows[secilen].Cells[7 ].Value.ToString();
            frg.Show();
        }
    }
}
