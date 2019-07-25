using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Araba
    {
        public string yil;
        public double yakit;
        public int km;
        public double litrefiyat;

        public double Hesapla(Araba bilgi)
        {
            double hesap = (bilgi.km * bilgi.yakit / 100);
            hesap = hesap * bilgi.litrefiyat;
            return hesap;
        }
    }
    
}
