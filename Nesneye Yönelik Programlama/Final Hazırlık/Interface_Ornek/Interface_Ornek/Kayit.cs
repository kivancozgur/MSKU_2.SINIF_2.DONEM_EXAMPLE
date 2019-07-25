using System.Windows.Forms;

namespace Interface_Ornek
{

    class Kayit : IKayit
    {
        public void Guncelle()
        {
            MessageBox.Show("Güncellendi");
        }

        public void Kaydet()
        {
            MessageBox.Show("Kaydedildi");
        }

        public void Sil()
        {
            MessageBox.Show("Silindi");
        }
    }
}
