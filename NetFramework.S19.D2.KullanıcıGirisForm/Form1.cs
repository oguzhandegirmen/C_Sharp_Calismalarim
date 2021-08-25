using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D2.KullanıcıGirisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textKullaniciAdi.Text;
            string sifre = textSifre.Text;

            if (kullaniciAdi == "admin" && sifre == "admin")
            {
                anaForm _anaform = new anaForm(kullaniciAdi);
                _anaform.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı bilgileri.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
