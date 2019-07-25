using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
namespace WindowsFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Araba yeniaraba = new Araba();
            yeniaraba.km =Convert.ToInt32(kmText.Text);
            yeniaraba.yakit =Convert.ToDouble(yakitText.Text);
            yeniaraba.yil =yilText.Text;
            yeniaraba.litrefiyat = Convert.ToDouble(fiyatText.Text);
            label1.Text = yeniaraba.Hesapla(yeniaraba).ToString();
        }
    }
}
