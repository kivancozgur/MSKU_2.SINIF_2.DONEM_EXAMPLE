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
using MySql.Data.MySqlClient;

namespace Cinema
{
    public partial class SinemaForm : MaterialForm
    {
        public SinemaForm()
        {
            InitializeComponent();
        }

        int filmSayaci = 0;

        string FilmKonu,FilmKonu1,FilmKonu2,FilmKonu3,FilmAdi;

        void YeniFilm1Ayari()
        {
            pictureBox5.ImageLocation = openFileDialog1.FileName;
            labeltur1.Visible = true;
            labelfilm1.Visible = true;
            pictureBox5.Visible = true;
            yenipanel1.Visible = true;
        }
        void YeniFilm2Ayari()
        {
            pictureBox6.ImageLocation = openFileDialog1.FileName;
            labeltur2.Visible = true;
            labelfilm2.Visible = true;
            pictureBox6.Visible = true;
            yenipanel2.Visible = true;

        }
        void YeniFilm3Ayari()
        {
            pictureBox7.ImageLocation = openFileDialog1.FileName;
            labeltur3.Visible = true;
            labelfilm3.Visible = true;
            pictureBox7.Visible = true;
            yenipanel3.Visible = true;
        }
        void YeniFilm4Ayari()
        {
            pictureBox8.ImageLocation = openFileDialog1.FileName;
            labeltur4.Visible = true;
            labelfilm4.Visible = true;
            pictureBox8.Visible = true;
            yenipanel4.Visible = true;

        }
        void FormTemizle()
        {
            textFilmAdi.Text = "";
            comboBoxtur.Text = "";
            KonuText.Text = "";
            AfisButton.Enabled = true;
            pictureBox9.ImageLocation = "";
        }
        void FilmKaydet()
        {
            Aksiyon a = new Aksiyon();
            a.FilminTuru();
            BilimKurgu bk = new BilimKurgu();
            bk.FilminTuru();
            Biyografi b = new Biyografi();
            b.FilminTuru();
            Dram d = new Dram();
            d.FilminTuru();
            Fantastik f = new Fantastik();
            f.FilminTuru();
            Komedi k = new Komedi();
            k.FilminTuru();
            Macera m = new Macera();
            m.FilminTuru();

            if (filmSayaci == 0)
            {
                if (comboBoxtur.Text == a.tur)
                {
                    a.FilmAdi = textFilmAdi.Text;
                    a.tur = comboBoxtur.Text;
                    labelfilm1.Text = a.FilmAdi;
                    labeltur1.Text = a.tur;
                    FilmKonu=KonuText.Text;
                    YeniFilm1Ayari();

                }
                else if (comboBoxtur.Text == b.tur)
                {
                    b.FilmAdi = textFilmAdi.Text;
                    b.tur = comboBoxtur.Text;
                    labelfilm1.Text = b.FilmAdi;
                    labeltur1.Text = b.tur;
                    FilmKonu = KonuText.Text;
                    YeniFilm1Ayari();

                }
                else if (comboBoxtur.Text == bk.tur)
                {
                    bk.FilmAdi = textFilmAdi.Text;
                    bk.tur = comboBoxtur.Text;
                    labelfilm1.Text = bk.FilmAdi;
                    labeltur1.Text = bk.tur;
                    FilmKonu = KonuText.Text;
                    YeniFilm1Ayari();
                }
                else if (comboBoxtur.Text == d.tur)
                {
                    d.FilmAdi = textFilmAdi.Text;
                    d.tur = comboBoxtur.Text;
                    labelfilm1.Text = d.FilmAdi;
                    labeltur1.Text = d.tur;
                    FilmKonu = KonuText.Text;
                    YeniFilm1Ayari();
                }
                else if (comboBoxtur.Text == f.tur)
                {
                    f.FilmAdi = textFilmAdi.Text;
                    f.tur = comboBoxtur.Text;
                    labelfilm1.Text = f.FilmAdi;
                    labeltur1.Text = f.tur;
                    FilmKonu = KonuText.Text;
                    YeniFilm1Ayari();
                }
                else if (comboBoxtur.Text == k.tur)
                {
                    k.FilmAdi = textFilmAdi.Text;
                    k.tur = comboBoxtur.Text;
                    labelfilm1.Text = k.FilmAdi;
                    labeltur1.Text = k.tur;
                    FilmKonu = KonuText.Text;
                    YeniFilm1Ayari();
                }
                else if (comboBoxtur.Text == m.tur)
                {
                    m.FilmAdi = textFilmAdi.Text;
                    m.tur = comboBoxtur.Text;
                    labelfilm1.Text = m.FilmAdi;
                    labeltur1.Text = m.tur;
                    FilmKonu = KonuText.Text;
                    YeniFilm1Ayari();
                }
                else
                {
                    MessageBox.Show("Tür Seçin.");
                }
            }
            else if (filmSayaci == 1)
            {
                if (comboBoxtur.Text == a.tur)
                {
                    a.FilmAdi = textFilmAdi.Text;
                    a.tur = comboBoxtur.Text;
                    labelfilm2.Text = a.FilmAdi;
                    labeltur2.Text = a.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();

                }
                else if (comboBoxtur.Text == b.tur)
                {
                    b.FilmAdi = textFilmAdi.Text;
                    b.tur = comboBoxtur.Text;
                    labelfilm2.Text = b.FilmAdi;
                    labeltur2.Text = b.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();

                }
                else if (comboBoxtur.Text == bk.tur)
                {
                    bk.FilmAdi = textFilmAdi.Text;
                    bk.tur = comboBoxtur.Text;
                    labelfilm2.Text = bk.FilmAdi;
                    labeltur2.Text = bk.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();
                }
                else if (comboBoxtur.Text == d.tur)
                {
                    d.FilmAdi = textFilmAdi.Text;
                    d.tur = comboBoxtur.Text;
                    labelfilm2.Text = d.FilmAdi;
                    labeltur2.Text = d.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();
                }
                else if (comboBoxtur.Text == f.tur)
                {
                    f.FilmAdi = textFilmAdi.Text;
                    f.tur = comboBoxtur.Text;
                    labelfilm2.Text = f.FilmAdi;
                    labeltur2.Text = f.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();
                }
                else if (comboBoxtur.Text == k.tur)
                {
                    k.FilmAdi = textFilmAdi.Text;
                    k.tur = comboBoxtur.Text;
                    labelfilm2.Text = k.FilmAdi;
                    labeltur2.Text = k.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();
                }
                else if (comboBoxtur.Text == m.tur)
                {
                    m.FilmAdi = textFilmAdi.Text;
                    m.tur = comboBoxtur.Text;
                    labelfilm2.Text = m.FilmAdi;
                    labeltur2.Text = m.tur;
                    FilmKonu1 = KonuText.Text;
                    YeniFilm2Ayari();
                }
                else
                {
                    MessageBox.Show("Tür Seçin.");
                }
            }
            else if (filmSayaci == 2)
            {
                if (comboBoxtur.Text == a.tur)
                {
                    a.FilmAdi = textFilmAdi.Text;
                    a.tur = comboBoxtur.Text;
                    labelfilm3.Text = a.FilmAdi;
                    labeltur3.Text = a.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();

                }
                else if (comboBoxtur.Text == b.tur)
                {
                    b.FilmAdi = textFilmAdi.Text;
                    b.tur = comboBoxtur.Text;
                    labelfilm3.Text = b.FilmAdi;
                    labeltur3.Text = b.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();

                }
                else if (comboBoxtur.Text == bk.tur)
                {
                    bk.FilmAdi = textFilmAdi.Text;
                    bk.tur = comboBoxtur.Text;
                    labelfilm3.Text = bk.FilmAdi;
                    labeltur3.Text = bk.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();
                }
                else if (comboBoxtur.Text == d.tur)
                {
                    d.FilmAdi = textFilmAdi.Text;
                    d.tur = comboBoxtur.Text;
                    labelfilm3.Text = d.FilmAdi;
                    labeltur3.Text = d.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();
                }
                else if (comboBoxtur.Text == f.tur)
                {
                    f.FilmAdi = textFilmAdi.Text;
                    f.tur = comboBoxtur.Text;
                    labelfilm3.Text = f.FilmAdi;
                    labeltur3.Text = f.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();
                }
                else if (comboBoxtur.Text == k.tur)
                {
                    k.FilmAdi = textFilmAdi.Text;
                    k.tur = comboBoxtur.Text;
                    labelfilm3.Text = k.FilmAdi;
                    labeltur3.Text = k.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();
                }
                else if (comboBoxtur.Text == m.tur)
                {
                    m.FilmAdi = textFilmAdi.Text;
                    m.tur = comboBoxtur.Text;
                    labelfilm3.Text = m.FilmAdi;
                    labeltur3.Text = m.tur;
                    FilmKonu2 = KonuText.Text;
                    YeniFilm3Ayari();
                }
                else
                {
                    MessageBox.Show("Tür Seçin.");
                }
            }
            else if (filmSayaci == 3)
            {
                if (comboBoxtur.Text == a.tur)
                {
                    a.FilmAdi = textFilmAdi.Text;
                    a.tur = comboBoxtur.Text;
                    labelfilm4.Text = a.FilmAdi;
                    labeltur4.Text = a.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();

                }
                else if (comboBoxtur.Text == b.tur)
                {
                    b.FilmAdi = textFilmAdi.Text;
                    b.tur = comboBoxtur.Text;
                    labelfilm4.Text = b.FilmAdi;
                    labeltur4.Text = b.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();

                }
                else if (comboBoxtur.Text == bk.tur)
                {
                    bk.FilmAdi = textFilmAdi.Text;
                    bk.tur = comboBoxtur.Text;
                    labelfilm4.Text = bk.FilmAdi;
                    labeltur4.Text = bk.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();
                }
                else if (comboBoxtur.Text == d.tur)
                {
                    d.FilmAdi = textFilmAdi.Text;
                    d.tur = comboBoxtur.Text;
                    labelfilm4.Text = d.FilmAdi;
                    labeltur4.Text = d.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();
                }
                else if (comboBoxtur.Text == f.tur)
                {
                    f.FilmAdi = textFilmAdi.Text;
                    f.tur = comboBoxtur.Text;
                    labelfilm4.Text = f.FilmAdi;
                    labeltur4.Text = f.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();
                }
                else if (comboBoxtur.Text == k.tur)
                {
                    k.FilmAdi = textFilmAdi.Text;
                    k.tur = comboBoxtur.Text;
                    labelfilm4.Text = k.FilmAdi;
                    labeltur4.Text = k.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();
                }
                else if (comboBoxtur.Text == m.tur)
                {
                    m.FilmAdi = textFilmAdi.Text;
                    m.tur = comboBoxtur.Text;
                    labelfilm4.Text = m.FilmAdi;
                    labeltur4.Text = m.tur;
                    FilmKonu3 = KonuText.Text;
                    YeniFilm4Ayari();
                }
                else
                {
                    MessageBox.Show("Tür Seçin.");
                }
            }
            else if (filmSayaci == 4)
            {
                MessageBox.Show("DAHA FAZLA FILM EKLENEMEZ");
                sinemaolusturpanel.Visible = false;
                sinemapaneli.Visible = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            if (radioButton1.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.Lime;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show("Özet ve Detaylar Organize İşler Sazan Sarmalı, Asım Noyan ve çetesinin maceralarını konu ediyor.İstanbul şehrinde organize işler tam gaz devam etmektedir.Asım Noyan, yıllardır söylediği yalanlar ve çevirdiği oyunlarla insanları dolandırmaktadır.Kimsenin yakalamayı başaramadığı Asım Noyan ve çetesi, bu kez de “sazan sarmalı” olarak adlandırdıkları bir üç kağıda bulaşır.Dolandırıcılar kralının biricik kızı Nazlı dolandırılınca, Asım Noyan ve ekibi hemen harekete geçer.Nazlı, her ne kadar babasını organize işlerden vazgeçirmeye çalışsa da, kendisini birden sazan sarmalının içerisinde bulur. Organize İşler filminin devam halkası olan yapımın senaryosu ve yönetmenliği Yılmaz Erdoğan'a ait. Filmin oyuncu kadrosunda Yılmaz Erdoğan, Kıvanç Tatlıtuğ, Ezgi Mola, Bensu Soral, Rıza Kocaoğlu, Okan Çabalar, Güven Kıraç, Ahmet Mümtaz Taylan, Ersin Korkut, Erdem Baş, Mahir İpek, Ekin Türkmen, Atakan Çelik ve Safa Sarı gibi isimler yer alıyor.", "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FilmAdi = LabelSinema1.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            if (radioButton2.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.Lime;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show("Özet ve Detaylar Organize İşler Sazan Sarmalı, Asım Noyan ve çetesinin maceralarını konu ediyor.İstanbul şehrinde organize işler tam gaz devam etmektedir.Asım Noyan, yıllardır söylediği yalanlar ve çevirdiği oyunlarla insanları dolandırmaktadır.Kimsenin yakalamayı başaramadığı Asım Noyan ve çetesi, bu kez de “sazan sarmalı” olarak adlandırdıkları bir üç kağıda bulaşır.Dolandırıcılar kralının biricik kızı Nazlı dolandırılınca, Asım Noyan ve ekibi hemen harekete geçer.Nazlı, her ne kadar babasını organize işlerden vazgeçirmeye çalışsa da, kendisini birden sazan sarmalının içerisinde bulur. Organize İşler filminin devam halkası olan yapımın senaryosu ve yönetmenliği Yılmaz Erdoğan'a ait. Filmin oyuncu kadrosunda Yılmaz Erdoğan, Kıvanç Tatlıtuğ, Ezgi Mola, Bensu Soral, Rıza Kocaoğlu, Okan Çabalar, Güven Kıraç, Ahmet Mümtaz Taylan, Ersin Korkut, Erdem Baş, Mahir İpek, Ekin Türkmen, Atakan Çelik ve Safa Sarı gibi isimler yer alıyor.", "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = LabelSinema2.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            if (radioButton3.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.Lime;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show("Özet ve Detaylar Organize İşler Sazan Sarmalı, Asım Noyan ve çetesinin maceralarını konu ediyor.İstanbul şehrinde organize işler tam gaz devam etmektedir.Asım Noyan, yıllardır söylediği yalanlar ve çevirdiği oyunlarla insanları dolandırmaktadır.Kimsenin yakalamayı başaramadığı Asım Noyan ve çetesi, bu kez de “sazan sarmalı” olarak adlandırdıkları bir üç kağıda bulaşır.Dolandırıcılar kralının biricik kızı Nazlı dolandırılınca, Asım Noyan ve ekibi hemen harekete geçer.Nazlı, her ne kadar babasını organize işlerden vazgeçirmeye çalışsa da, kendisini birden sazan sarmalının içerisinde bulur. Organize İşler filminin devam halkası olan yapımın senaryosu ve yönetmenliği Yılmaz Erdoğan'a ait. Filmin oyuncu kadrosunda Yılmaz Erdoğan, Kıvanç Tatlıtuğ, Ezgi Mola, Bensu Soral, Rıza Kocaoğlu, Okan Çabalar, Güven Kıraç, Ahmet Mümtaz Taylan, Ersin Korkut, Erdem Baş, Mahir İpek, Ekin Türkmen, Atakan Çelik ve Safa Sarı gibi isimler yer alıyor.", "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = LabelSinema3.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                
            }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            if (radioButton4.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.Lime;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show("Özet ve Detaylar Organize İşler Sazan Sarmalı, Asım Noyan ve çetesinin maceralarını konu ediyor.İstanbul şehrinde organize işler tam gaz devam etmektedir.Asım Noyan, yıllardır söylediği yalanlar ve çevirdiği oyunlarla insanları dolandırmaktadır.Kimsenin yakalamayı başaramadığı Asım Noyan ve çetesi, bu kez de “sazan sarmalı” olarak adlandırdıkları bir üç kağıda bulaşır.Dolandırıcılar kralının biricik kızı Nazlı dolandırılınca, Asım Noyan ve ekibi hemen harekete geçer.Nazlı, her ne kadar babasını organize işlerden vazgeçirmeye çalışsa da, kendisini birden sazan sarmalının içerisinde bulur. Organize İşler filminin devam halkası olan yapımın senaryosu ve yönetmenliği Yılmaz Erdoğan'a ait. Filmin oyuncu kadrosunda Yılmaz Erdoğan, Kıvanç Tatlıtuğ, Ezgi Mola, Bensu Soral, Rıza Kocaoğlu, Okan Çabalar, Güven Kıraç, Ahmet Mümtaz Taylan, Ersin Korkut, Erdem Baş, Mahir İpek, Ekin Türkmen, Atakan Çelik ve Safa Sarı gibi isimler yer alıyor.", "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = LabelSinema4.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
            if (radioButton5.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.Lime;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show(FilmKonu, "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = labelfilm1.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
            if (radioButton6.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.Lime;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show(FilmKonu1, "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = labelfilm2.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
            if (radioButton7.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.Lime;
                yenipanel4.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show(FilmKonu2, "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = labelfilm3.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
            if (radioButton8.Checked == true)
            {
                Thread.Sleep(100);
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                panel8.BackColor = Color.White;
                yenipanel1.BackColor = Color.White;
                yenipanel2.BackColor = Color.White;
                yenipanel3.BackColor = Color.White;
                yenipanel4.BackColor = Color.Lime;
                DialogResult dialogResult = MessageBox.Show(FilmKonu3, "Bilet Almak İster Misin?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    FilmAdi = labelfilm4.Text;
                    FilmAdiLabel.Text = FilmAdi;
                    biletalpanel.Visible = true;
                    sinemapaneli.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void SinemalarButton_Click(object sender, EventArgs e)
        {

            SinemalarButton.BackColor = Color.Tomato;
            sinemaolusturpanel.Visible = false;
            sinemapaneli.Visible = true;
            KullaniciPanel.Visible = false;
            biletalpanel.Visible = false;
        }

        private void SinemaOlusturButton_Click(object sender, EventArgs e)
        {
            sinemaolusturpanel.Visible = true;
            sinemapaneli.Visible = false;
            KullaniciPanel.Visible = false;
            /*          FİLMLERİN GÖZÜKTÜĞÜ DATAGRİD BAŞLANGIÇ          */
            string connectionString1 = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
            MySqlConnection con1 = new MySqlConnection(connectionString1);
            MySqlDataAdapter adapter1;
            DataTable dt1 = new DataTable();

            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "film_no";
            dataGridView2.Columns[1].Name = "film_adi";
            dataGridView2.Columns[2].Name = "film_turu";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;



            dataGridView2.Rows.Clear();
            string sql1 = "SELECT * FROM film_kayit";
            MySqlCommand com2 = new MySqlCommand(sql1, con1);
            try
            {
                adapter1 = new MySqlDataAdapter(com2);
                adapter1.Fill(dt1);
                foreach (DataRow row in dt1.Rows)
                {

                    dataGridView2.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
                }
                dt1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            /*          FİLMLERİN GÖZÜKTÜĞÜ DATAGRİD BİTİŞ          */
        }
        private void FilmEkleButton_Click(object sender, EventArgs e)
        {
            FilmKaydet();
            string eklesorgu = "INSERT INTO film_kayit (film_no,film_adi,film_turu,film_konusu) VALUES (NULL, '" + textFilmAdi.Text + "', '" + comboBoxtur.Text + "','" + KonuText.Text + "')";
            Baglanti bagla = new Baglanti();
            bagla.FilmSilGuncelleEkle(eklesorgu);
            MessageBox.Show(bagla.bilgimetin);
            bagla.BaglantiKapat();
            Yenile2();
            FormTemizle();
            filmSayaci++;
        }

        private void AfisButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox9.ImageLocation = openFileDialog1.FileName;
            AfisButton.Enabled = false;
        }

        private void OturumKapatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm f = new GirisForm();
            f.Show();
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SinemaForm_Load(object sender, EventArgs e)
        {
            Aksiyon a = new Aksiyon();
            a.FilminTuru();
            comboBoxtur.Items.Add(a.tur);
            BilimKurgu bk = new BilimKurgu();
            bk.FilminTuru();
            comboBoxtur.Items.Add(bk.tur);
            Biyografi b = new Biyografi();
            b.FilminTuru();
            comboBoxtur.Items.Add(b.tur);
            Dram d = new Dram();
            d.FilminTuru();
            comboBoxtur.Items.Add(d.tur);
            Fantastik f = new Fantastik();
            f.FilminTuru();
            comboBoxtur.Items.Add(f.tur);
            Komedi k = new Komedi();
            k.FilminTuru();
            comboBoxtur.Items.Add(k.tur);
            Macera m = new Macera();
            m.FilminTuru();
            comboBoxtur.Items.Add(m.tur);
            try
            {
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "ID";
                dataGridView1.Columns[1].Name = "Kullanici_Adi";
                dataGridView1.Columns[2].Name = "Sifre";
                dataGridView1.Columns[3].Name = "Yetki";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                connectionString = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
                con = new MySqlConnection(connectionString);
                con.Open();
                dataGridView1.Rows.Clear();
                string sql = "SELECT * FROM kullanci_kayit";
                MySqlCommand com1 = new MySqlCommand(sql, con);
                try
                {
                    adapter = new MySqlDataAdapter(com1);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        doldur(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                    }
                    con.Close();
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
                

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("MYSQL BAGLANTI HATASI : " + ex.Message.ToString());
            }
            
        }

        private void sinemapaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        MySqlConnection con;
        string connectionString;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        Sinemalar bilet;
        string koltukno;
        string seansno;


        void doldur(String id, String k_ad, String sifre, String yetki)
        {
            dataGridView1.Rows.Add(id, k_ad, sifre, yetki);
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            string eklesql = "INSERT INTO kullanci_kayit (id,k_adi,sifre,yetki) VALUES (NULL, '" + KullaniciText.Text + "', '" + SifreText.Text + "','" + YetkiText.Text + "')";
            MySqlCommand com2 = new MySqlCommand(eklesql, con);
            con.Open();
            if (com2.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("KAYDEDILDI");
                con.Close();
            }
            else
            {
                MessageBox.Show("KAYIT BAŞARISIZ");
                con.Close();
            }
            Yenile();
        }

       
        void Yenile()
        {
            dataGridView1.Rows.Clear();
            string sql = "SELECT * FROM kullanci_kayit";
            MySqlCommand com1 = new MySqlCommand(sql, con);
            try
            {
                adapter = new MySqlDataAdapter(com1);
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    doldur(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }
                con.Close();
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        void Yenile2()
        {
            dataGridView2.Rows.Clear();
            string connectionString1 = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
            MySqlConnection con1 = new MySqlConnection(connectionString1);
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            DataTable dt1 = new DataTable();
            string sql1 = "SELECT * FROM film_kayit";
            MySqlCommand com1 = new MySqlCommand(sql1, con1);
            try
            {
                adapter = new MySqlDataAdapter(com1);
                adapter.Fill(dt1);
                foreach (DataRow row in dt1.Rows)
                {
                    dataGridView2.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
                }
                con1.Close();
                dt1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con1.Close();
            }

        }

        private void KullanicilarButton_Click(object sender, EventArgs e)
        {
            KullaniciPanel.Visible = true;
            sinemaolusturpanel.Visible = false;
            sinemapaneli.Visible = false;
            biletalpanel.Visible = false;
        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            if (KullaniciText.Text == "" && SifreText.Text == "" && YetkiText.Text == "")
            {
                MessageBox.Show("Lütfen Boş Olan Textlere Gerekli Verileri Girin");
            }
            else
            {

                String secili = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int id = Convert.ToInt32(secili);
                string guncellesql = "UPDATE kullanci_kayit SET k_adi='" + KullaniciText.Text + "',sifre='" + SifreText.Text + "',yetki='" + YetkiText.Text + "' WHERE ID=" + id + "";
                MySqlCommand com3 = new MySqlCommand(guncellesql, con);
                con.Open();
                adapter = new MySqlDataAdapter(com3);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = guncellesql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("GUNCELLENDI");
                    con.Close();
                }

                else
                {
                    MessageBox.Show("GUNCELLEME BAŞARISIZ");
                    con.Close();
                }
                Yenile();
            }
        }

        private void FilmSilButton_Click(object sender, EventArgs e)
        {

            string connectionString1 = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
            MySqlConnection con1 = new MySqlConnection(connectionString1);
            MySqlDataAdapter adapter1;
            String secili = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            int film_no = Convert.ToInt32(secili);
            string silsql = "DELETE FROM film_kayit WHERE film_no=" + film_no + "";
            MySqlCommand com4 = new MySqlCommand(silsql, con1);
            con1.Open();
            try
            {
                adapter1 = new MySqlDataAdapter(com4);
                adapter1.DeleteCommand = con1.CreateCommand();
                adapter1.DeleteCommand.CommandText = silsql;
                if (MessageBox.Show("Emin Misin?", "SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (com4.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("BAŞARIYLA SİLİNDİ");
                        con1.Close();
                    }
                    else
                    {
                        MessageBox.Show("SİLME İŞLEMİ BAŞARISIZ");
                        con1.Close();
                    }
                 Yenile2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (koltuk1.Checked == true)
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
            else if (koltuk16.Checked == true)
            {
                koltukno = "16";
                koltuk16.Enabled = false;
                koltuk16.Checked = false;
            }
            else
            {
                MessageBox.Show("Lütfen Koltuk Seçiniz..");
            }


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
        private void BiletAlButton_Click(object sender, EventArgs e)
        {
            bilet = new Sinemalar(radioSalon1.Text, 16);
            bilet.BiletSat(radioIndirimli.Checked);
            KoltukNoOgren();
            SeansOgren();
            BiletSat();
        }

        private void BiletKapatButton_Click(object sender, EventArgs e)
        {
            biletalpanel.Visible = false;
            sinemapaneli.Visible = true;
        }

        private void FilmGuncelleButton_Click(object sender, EventArgs e)
        {
            string connectionString1 = "Server=localhost;PORT=3306;Database=kullanici;Uid=kivanc;Pwd=123;";
            MySqlConnection con1 = new MySqlConnection(connectionString1);
            MySqlDataAdapter adapter1;
            String secili = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(secili);
            string guncellesql = "UPDATE film_kayit SET film_adi='" + textFilmAdi.Text + "',film_turu='" + comboBoxtur.Text + "',film_konusu='" + KonuText.Text + "' WHERE film_no=" + id + "";
            MySqlCommand com3 = new MySqlCommand(guncellesql, con1);
            con1.Open();
            adapter1 = new MySqlDataAdapter(com3);
            adapter1.UpdateCommand = con1.CreateCommand();
            adapter1.UpdateCommand.CommandText = guncellesql;
            if (adapter1.UpdateCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("GUNCELLENDI");
                con1.Close();
            }

            else
            {
                MessageBox.Show("GUNCELLEME BAŞARISIZ");
                con1.Close();
            }
            Yenile2();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {

            String secili = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(secili);
            string silsql = "DELETE FROM kullanci_kayit WHERE ID=" + id + "";
            MySqlCommand com4 = new MySqlCommand(silsql, con);
            con.Open();
            try
            {
                adapter = new MySqlDataAdapter(com4);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = silsql;
                if (MessageBox.Show("Emin Misin?", "SİL", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (com4.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("BAŞARIYLA SİLİNDİ");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("SİLME İŞLEMİ BAŞARISIZ");
                        con.Close();
                    }
                    Yenile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
