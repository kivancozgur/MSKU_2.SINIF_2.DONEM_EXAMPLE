using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float sonuc;
        void durum(float a,float b,float c, float d)
        {
            sonuc = (a * c) + (b * d);
            if (sonuc>70)
            {
                MessageBox.Show(sonuc + " Ortalama ile Geçti");
            }
            else
            {
                MessageBox.Show(sonuc + " Ortalama ile Kaldı");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float vize, final, kvize, kfinal;
            float kvize1, kfinal1;
            vize = Convert.ToInt32(vizetext.Text);
            final = Convert.ToInt32(finaltext.Text);
            kvize = Convert.ToInt32(kvizetext.Text);
            kfinal = Convert.ToInt32(kfinaltext.Text);
            kvize1 = kvize / 100;
            kfinal1 = kfinal / 100;
            durum(vize, final, kvize1, kfinal1);
        }
    }
}
