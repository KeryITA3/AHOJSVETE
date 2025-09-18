using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            string veta=textBox1.Text;
            int pocetsam = 0;
            int pocetsouh = 0;
            int nepismene = 0;
            veta = veta.ToLower();
            foreach(char c in veta)
            {
                if (samohlasky.Contains(c))
                {
                    pocetsam++;
                }
                else
                {
                    if (souhlasky.Contains(c))
                    {
                        pocetsouh++;
                    }
                    else
                    {
                        nepismene++;
                    }
                }
            }
            MessageBox.Show("Samohlasek je " + pocetsam + " a souhlasek je " + pocetsouh + " a nepismenych znaku je " + nepismene);
        }
    }
}
