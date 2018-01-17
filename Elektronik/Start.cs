using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronik
{
    public partial class Start : Form
    {
        Serwis serewi = new Serwis();
        public Start()
        {
            InitializeComponent();
           
        }

        private void DodajTV(object sender, EventArgs e)
        {
            try
            {
                serewi.DodajTelewizor(markaBox.Text, Int32.Parse(numerSeryjnyBox.Text), usterkaBox.Text);
                listaNaprawL.Text = serewi.ToString();
            }
            catch (Exception) { MessageBox.Show("Ma byc wupelnione wszystkie polia prawidlowo!"); ; }
        }

        private void DodajKomputer(object sender, EventArgs e)
        {
            try
            {
                serewi.DodajKomputer(markaBox.Text, Int32.Parse(numerSeryjnyBox.Text), usterkaBox.Text);
                listaNaprawL.Text = serewi.ToString();
            }
            catch (Exception) { MessageBox.Show("Ma byc wupelnione wszystkie polia prawidlowo!"); }
        }

        private void Polocz(object sender, EventArgs e)
        {
            serewi.Polacz();
        }

        private void PodzielZ(object sender, EventArgs e)
        {
            serewi.Podziel();
        }

        private void NaprawaZ(object sender, EventArgs e)
        {
            serewi.Napraw();
        }

        private void NaprawaPoNr(object sender, EventArgs e)
        {
            try
            {
                serewi.Napraw(Int32.Parse(numerSeryjnyDoNapBox.Text));
            }
            catch (Exception) { MessageBox.Show("Ma byc podano liczbe!"); }
        }
    }
}
