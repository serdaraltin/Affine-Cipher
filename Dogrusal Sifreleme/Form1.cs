using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogrusal_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_a.Text); // a degeri
            int b = Convert.ToInt32(tx_b.Text); // b degeri
            
            for (int i = 0; i < tx_acikmesaj.TextLength; i++)
            {
                int ascii_degeri = tx_acikmesaj.Text[i] - 96;
                int y = (a * ascii_degeri) + b;

                while (y > 26)
                {
                    y = y - 26;
                }

                char sifrelenmis_harf = (char)(y + 96);

                tx_sifrelimesaj.Text += sifrelenmis_harf;
            }
        }
    }
}
