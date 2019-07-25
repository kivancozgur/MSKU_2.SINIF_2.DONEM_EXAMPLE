using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis
{
    public class Sinema
    {
        public int toplamKoltukSayisi;
        public int bosKoltukSayisi;
        public double bakiye;
        public string salonNo;
        public const double TAM = 15.0;
        public const double INDIRIMLI = 10.0;
        public Sinema(string salonn, int koltuksayisi)
        {
            toplamKoltukSayisi = koltuksayisi;
            salonNo = salonn;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;
        }
        public void BiletSat(bool indirimli)
        {
            bosKoltukSayisi--;
            if (indirimli)
            {
                bakiye += INDIRIMLI;
            }
            else
            {
                bakiye += TAM;
            }
        }
        public void BiletIptal(bool indirimli)
        {
            bosKoltukSayisi++;
            if (indirimli)
            {
                bakiye -= INDIRIMLI;
            }
            else
            {
                bakiye -= TAM;
            }
        }
        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }
        public double BakiyeOgren()
        {
            return bakiye;
        }
    }
   
    
}
