using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deger = 0, toplam = 0, carpim = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < sayi; i++)
            {
                deger = rnd.Next(0, 100);
                listBox1.Items.Add(deger);
                toplam = toplam + deger;
                carpim = carpim * deger;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                label1.Text = toplam.ToString();
            }
            else
            {
                label1.Text = carpim.ToString();
            }
        }
    }
}
