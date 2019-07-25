using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Abstact_Class
{
    class Calisma : Ornek
    {
        public override int Y
        {
            get
            {
                return sayi;
            }
            set
            {
                sayi = value;
            }
        }

        public override void X()
        {
            MessageBox.Show("X");
        }

        public override void Z()
        {
            MessageBox.Show("Z");
        }
    }
}
