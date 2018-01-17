using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronik
{
    class Telewizor : Elektornika
    {
        public Telewizor(string marka, int numerSeryjny, string usterka): base(marka, numerSeryjny, usterka)
        { }
        public override string ToString()
        {
            return "Telewizor  : " + marka + " numer seryjny " + numerSeryjny + " usterka " + usterka;
        }

    }
}
