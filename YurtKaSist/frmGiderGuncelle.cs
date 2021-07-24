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
    public partial class frmGiderGuncelle : Form
    {
        public frmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string elektirik, su, dogalgaz, gida, diger, internet, personel, id;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmGiderGuncelle_Load(object sender, EventArgs e)
        {
            textBox1.Text = elektirik;
            textBox2.Text = su;
            textBox3.Text = dogalgaz;
            textBox4.Text = internet;
            textBox5.Text = gida;
            textBox6.Text = personel;
            textBox7.Text = diger;
            textBox8.Text = id;

        }
    }
}
