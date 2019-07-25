using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Threading;
namespace Cinema
{
    public partial class BiletAlFormu : MaterialForm
    {
        public BiletAlFormu()
        {
            InitializeComponent();
        }

        Sinemalar bilet;
        string koltukno;
        string seansno;
        private void BiletAlFormu_Load(object sender, EventArgs e)
        {
            bilet = new Sinemalar(radioSalon1.Text, 16);

        }

        private void BiletSatButton_Click(object sender, EventArgs e)
        {
            bilet.BiletSat(radioIndirimli.Checked);
            KoltukNoOgren();
            SeansOgren();
            BiletSat();

        }


        void SeansOgren()
        {
            if (radioSeans1.Checked == true)
            {
                seansno = "09:30";
            }
            else if (radioSeans2.Checked == true)
            {
                seansno = "13:30";
            }
            else if (radioSeans3.Checked == true)
            {
                seansno = "16:00";
            }
            else if (radioSeans4.Checked == true)
            {
                seansno = "19:00";
            }
            else
            {
                MessageBox.Show("Lütfen Seans Seçiniz..");
            }
        }
        void KoltukNoOgren()
        {
                if (koltuk1.Checked==true)
                {
                    koltukno = "1";
                    koltuk1.Enabled = false;
                    koltuk1.Checked = false;
                }
                else if (koltuk2.Checked == true)
                {
                    koltukno = "2";
                    koltuk2.Enabled = false;
                    koltuk2.Checked = false;
                }
                else if (koltuk3.Checked == true)
                {
                    koltukno = "3";
                    koltuk3.Enabled = false;
                    koltuk3.Checked = false;
                }
                else if (koltuk4.Checked == true)
                {
                    koltukno = "4";
                    koltuk4.Enabled = false;
                    koltuk4.Checked = false;
                }
                else if (koltuk5.Checked == true)
                {
                    koltukno = "5";
                    koltuk5.Enabled = false;
                    koltuk5.Checked = false;
                }
                else if (koltuk6.Checked == true)
                {
                    koltukno = "6";
                    koltuk6.Enabled = false;
                    koltuk6.Checked = false;
                }
                else if (koltuk7.Checked == true)
                {
                    koltukno = "7";
                    koltuk7.Enabled = false;
                    koltuk7.Checked = false;
                }
                else if (koltuk8.Checked == true)
                {
                    koltukno = "8";
                    koltuk8.Enabled = false;
                    koltuk8.Checked = false;
                }
                else if (koltuk9.Checked == true)
                {
                    koltukno = "9";
                    koltuk9.Enabled = false;
                    koltuk9.Checked = false;
                }
                else if (koltuk10.Checked == true)
                {
                    koltukno = "10";
                    koltuk10.Enabled = false;
                    koltuk10.Checked = false;
                }
                else if (koltuk11.Checked == true)
                {
                    koltukno = "11";
                    koltuk11.Enabled = false;
                    koltuk11.Checked = false;
                }
                else if (koltuk12.Checked == true)
                {
                    koltukno = "12";
                    koltuk12.Enabled = false;
                    koltuk12.Checked = false;
                }
                else if (koltuk13.Checked == true)
                {
                    koltukno = "13";
                    koltuk13.Enabled = false;
                    koltuk13.Checked = false;
                }
                else if (koltuk14.Checked == true)
                {
                    koltukno = "14";
                    koltuk14.Enabled = false;
                    koltuk14.Checked = false;
                }
                else if (koltuk15.Checked == true)
                {
                    koltukno = "15";
                    koltuk15.Enabled = false;
                    koltuk15.Checked = false;
                }
                else if(koltuk16.Checked == true)
                {
                    koltukno = "16";
                    koltuk16.Enabled = false;
                    koltuk16.Checked = false;
                }
                else
                {
                BiletIptal();
                MessageBox.Show("Lütfen Koltuk Seçiniz..");
                }

               
            }
        void BiletIptal()
        {
            bilet.BiletIptal(radioIndirimli.Checked);

        }
        void BiletSat()
        {
            if (bilet.bosKoltukSayisi <= 0)
            {
                ListBoxTemizle();
                listBoxBiletBilgileri.Items.Add("Biletler Tükendi.");
            }
            else if (bilet.bosKoltukSayisi >= 16)
            {
                ListBoxTemizle();
                listBoxBiletBilgileri.Items.Add("Daha Fazla Bilet iptal edilemez!!");
            }
            else
            {
                ListBoxTemizle();
                listBoxBiletBilgileri.Items.Add("Bilet Satıldı. ");
                listBoxBiletBilgileri.Items.Add("Kalan Koltuk Sayısı : " + bilet.BosKoltukOgren());
                listBoxBiletBilgileri.Items.Add("Bilet Tutarı : " + bilet.BakiyeOgren() + " TL ");
                listBoxBiletBilgileri.Items.Add("Koltuk Numarası : " + koltukno);
                listBoxBiletBilgileri.Items.Add("Seans : " + seansno);
            }
        }
        void ListBoxTemizle()
        {
            listBoxBiletBilgileri.Items.Clear();
        }
        }
    }
