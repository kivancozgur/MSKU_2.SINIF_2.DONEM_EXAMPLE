using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    abstract class Film
    {
        public string FilmAdi { get; set; }
        public string CikisYili { get; set; }
        public string Sure { get; set; }
        public abstract void FilminTuru();
    }
}
