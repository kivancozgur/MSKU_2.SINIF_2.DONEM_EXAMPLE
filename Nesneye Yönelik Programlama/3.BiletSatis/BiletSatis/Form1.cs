using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Sinema salon;
        private void olusturbutton_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(salontext.Text,Convert.ToInt32(koltuktext.Text));
                label3.Text = "Salon Oluşturuldu. Koltuk Numarası : " + salon.BosKoltukOgren(); 
            }
            catch
            {
                label3.Text = "Salon oluşturulamadı. Bilgileri kontrol edin.";
            }
        }

        private void satbutton_Click(object sender, EventArgs e)
        {
            salon.BiletSat(indirimlicheckBox.Checked);
            label3.Text = "Bilet Satıldı. Kalan Koltuk Sayısı : " + salon.BosKoltukOgren()+" Bakiye : "+salon.BakiyeOgren();
        }

        private void iptalbutton_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(indirimlicheckBox.Checked);
            label3.Text = "Bilet İptal Edildi. Kalan Koltuk Sayısı : " + salon.BosKoltukOgren() + " Bakiye : " + salon.BakiyeOgren()+" TL";
        }

        private void bakiyebutton_Click(object sender, EventArgs e)
        {
            label3.Text = "Şu an bakiye : " + salon.BakiyeOgren();
        }

        private void bosbutton_Click(object sender, EventArgs e)
        {
            label3.Text = "Kalan Boş Koltuk Sayısı : " + salon.BosKoltukOgren();
        }
    }
}
