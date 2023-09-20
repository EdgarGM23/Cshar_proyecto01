using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.repetitivos
{
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int contador = 0;

            txtres.Text = "";
            for (int i = 100; i <= 999; i++)
            {
                int cifra1 = (i / 100);
                int cifra2 = (i / 10) % 10;
                int cifra3 = i % 10;

                String patron1 = cifra1.ToString() + cifra2.ToString() + cifra3.ToString();
                String patron2 = cifra3.ToString() + cifra2.ToString() + cifra1.ToString();

                if (patron1.Equals(patron2))
                {
                    txtres.AppendText(i + "\n");
                    contador += 1;
                }
            }
            txtcumple.Text = contador.ToString() + " capicuas";
        }
    }
}
