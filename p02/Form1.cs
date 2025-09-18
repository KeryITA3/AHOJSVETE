using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifra = textBox1.Text;
            int kolik=Convert.ToInt32(textBox2.Text);
            string zasifrovane = string.Empty;
       
            foreach(char c in sifra)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    if (c+(char)kolik>'Z')
                    {
                        zasifrovane += (char)('A' + (kolik-1))%26;
                    }
                    else
                    {
                        zasifrovane += (char)(c + (kolik));
                    }
                    
                }
                else
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        if (c + (char)kolik > 'z')
                        {
                            zasifrovane += (char)('a' + (kolik-1) )%26;
                        }
                        else
                        {
                            zasifrovane += (char)(c + (kolik));
                        }
                    }
                }

                
            }
            MessageBox.Show("Zasifrovane je " + zasifrovane);
            label2.Text = zasifrovane;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string zasifrovane = label2.Text;
            int kolik = Convert.ToInt32(textBox2.Text);
            string odsifrovane = string.Empty;
            foreach(char c in zasifrovane)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    if (c - (char)kolik > 'Z')
                    {
                        odsifrovane += (char)('Z' - (kolik) - 1);
                    }
                    else
                    {
                        odsifrovane += (char)(c - (kolik));
                    }

                }
                else
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        if (c - (char)kolik > 'z')
                        {
                            odsifrovane += (char)('z' - (kolik) - 1);
                        }
                        else
                        {
                            odsifrovane += (char)(c - (kolik));
                        }
                    }
                }
            }
            MessageBox.Show("Zasifrovane je " + odsifrovane);
        }
    }
}
