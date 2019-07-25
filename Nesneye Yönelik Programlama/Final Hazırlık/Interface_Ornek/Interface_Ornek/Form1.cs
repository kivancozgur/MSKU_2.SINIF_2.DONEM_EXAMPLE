using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        IKayit kayit = new Kayit();
        IKayit rehberkayit = new Rehber();
        private void button1_Click(object sender, EventArgs e)
        {
            kayit.Kaydet();
            rehberkayit.Kaydet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit.Guncelle();
            rehberkayit.Guncelle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayit.Sil();
            rehberkayit.Sil();
        }
    }
}
