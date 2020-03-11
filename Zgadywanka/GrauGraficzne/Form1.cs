using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GrauGraficzne
{
    public partial class Form1 : Form
    {
        private Gra g;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPrzebij.Visible = true;
        }

        private void buttonPrzebij_Click(object sender, EventArgs e)
        {

        }

        //wylosuj
        private void buttonWylosuj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxZakresOd.Text);
            int b = int.Parse(textBoxZakresDo.Text);

            g = new Gra(a, b);
            // wpisz komunikat, zeby odgadywac
            labelKomunikat1.Text = $"Wylosowano liczbe od {a} do {b}.";
            groupBoxLosowanie.Enabled = false;

            groupBoxPropozycja.Visible = true;
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);

            var odp = g.Odpowiedz(propozycja);

            switch(odp)
            {
                case Odp.ZaMalo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za malo";
                    break;
                case Odp.ZaDuzo:
                    labelOdpowiedz.ForeColor = Color.Red;
                    labelOdpowiedz.Text = "Za duzo";
                    break;
                case Odp.Trafiono:
                    labelOdpowiedz.ForeColor = Color.Green;
                    labelOdpowiedz.Text = "Trafiono";
                    groupBoxPropozycja.Enabled = false;
                    buttonNowaGra.Enabled = true;
                    break;



            }
        }

        private void textBoxZakresOd_TextChanged(object sender, EventArgs e)
        {
            int wynik = 0;
            if (int.TryParse(textBoxZakresOd.Text, out wynik))
            {
                textBoxZakresOd.BackColor = Color.LightGreen;
                buttonWylosuj.Enabled = true;
            }
                
            else
            {
                textBoxZakresOd.BackColor = Color.PaleVioletRed;
                buttonWylosuj.Enabled = false;
            }
                
        }
    }
}
