using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elektronik
{
    class Komputer : Elektornika
    {

        public Komputer(string marka, int numerSeryjny, string usterka): base(marka, numerSeryjny, usterka)
        {}
        public override string ToString()
        {
            return "Komputer : " + marka + " numer seryjny " + numerSeryjny + " usterka " + usterka;
        }
    }
}
