using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronik
{
    class Serwis : ISerwis
    {
        private HashSet<Elektornika> doNaprawy = new HashSet<Elektornika>();
        private HashSet<Komputer> komputery = new HashSet<Komputer>();

        public Serwis() { }
        public void DodajTelewizor(string marka, int numerSeryjny, string usterka)
        {
            doNaprawy.Add(new Telewizor(marka, numerSeryjny, usterka));           
        }
        public void DodajKomputer(string marka, int numerSeryjny, string usterka) 
        {
            komputery.Add(new Komputer(marka, numerSeryjny, usterka));
        }
        public void Polacz() 
        {
            try
            {
                doNaprawy.UnionWith(komputery);
            }
            catch (Exception) { MessageBox.Show("Lista pusta!"); ; }
        }
        public void Podziel() 
        {
            try
            {
                doNaprawy.ExceptWith(komputery);
            }
            catch (Exception) { MessageBox.Show("Lista pusta!"); ; }
        }
        public void Napraw() 
        {
            try
            {
                doNaprawy.Remove(doNaprawy.First<Elektornika>());
            }
            catch (Exception) { MessageBox.Show("Lista pusta!"); ; }
        }
        public void Napraw(int ile) 
        {
            if (doNaprawy.Count != 0)
            {
                foreach (Elektornika el in doNaprawy)
                {
                    if (el.NumerSeryjny == ile)
                    {
                        doNaprawy.Remove(el);
                    }
                }
            }
            else 
            {
                MessageBox.Show("Lista napraw pusta");
            }

        }
        public override string ToString()
        {
            string zw = "";           

            foreach (Elektornika naprawa in doNaprawy)
            {
                zw += naprawa.ToString() + Environment.NewLine;
            }

            return zw;
        }
    }
}
