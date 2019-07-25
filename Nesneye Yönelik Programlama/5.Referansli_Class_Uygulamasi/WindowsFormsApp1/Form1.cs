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
using Ev;
namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        List<Ev.Ev1> Depo = new List<Ev.Ev1>();
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Ev.Ev1 yeni = new Ev.Ev1();
            yeni.KapıNo = kapinoText.Text;
            yeni.Isim = adText.Text;
            yeni.Adres = adresText.Text;
            sayac++;
            Depo.Add(yeni);
            kapinoText.Text = "";
            adText.Text = "";
            adresText.Text = "";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            foreach (Ev.Ev1 item in Depo)
            {
                listBox1.Items.Add("Sayaç : " + sayac);
                listBox1.Items.Add("İsim : " + item.Isim);
                listBox1.Items.Add("Adres : " + item.Adres);
                listBox1.Items.Add("Kapı No : " + item.KapıNo);
            }
            sayac = 0;
            //listBox1.Items.Clear();
        }
    }
}
