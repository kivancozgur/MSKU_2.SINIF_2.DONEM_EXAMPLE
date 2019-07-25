using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class BilimKurgu:Film
    {
        public string tur;
        public override void FilminTuru()
        {
            tur = "Bilim Kurgu";
        }
    }
}
