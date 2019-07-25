using System.Windows.Forms;

namespace Interface_Ornek
{
    class Rehber : IKayit
    {
        public void Guncelle()
        {
            MessageBox.Show("Rehber Güncellendi");
        }

        public void Kaydet()
        {
            MessageBox.Show("Rehber Kaydedildi");
        }

        public void Sil()
        {
            MessageBox.Show("Rehber Silindi");
        }
    }
}
