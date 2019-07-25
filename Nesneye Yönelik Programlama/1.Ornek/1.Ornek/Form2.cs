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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int deger;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < sayi; i++)
            {
                deger = rnd.Next(0, 100);
                checkedListBox1.Items.Add(deger);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
