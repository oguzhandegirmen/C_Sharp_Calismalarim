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
    public partial class anaForm : Form
    {
        public anaForm(string kullaniciAdi)
        {
            InitializeComponent();
            lblFenerbahce.Text = kullaniciAdi;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
