using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Abstact_Class
{
    abstract class Ornek
    {
        public int sayi;
        abstract public void X();
        public void W() { }
        abstract public void Z();
        abstract public int Y { get; set; }
    }
}
