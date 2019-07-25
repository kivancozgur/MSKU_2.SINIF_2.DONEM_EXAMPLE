using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstact_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ornek yeni = new Calisma();
            yeni.X();
            yeni.Z();
            yeni.Y = 5;
            MessageBox.Show(yeni.sayi.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
