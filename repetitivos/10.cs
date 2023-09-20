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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int contador = 0;

            txtres.Text = "";
            for (int i = 1000; i <= 10000; i++)
            {
                int pares = 0;
                int impares = 0;

                int cifra1 = (i / 1000);
                int cifra2 = (i / 100) % 10;
                int cifra3 = (i / 10) % 10;
                int cifra4 = (i % 1000) % 10;

                if (cifra1 % 2 == 0) pares += cifra1;
                if (cifra2 % 2 == 0) pares += cifra2;
                if (cifra3 % 2 == 0) pares += cifra3;
                if (cifra4 % 2 == 0) pares += cifra4;

                if (cifra1 % 2 != 0) impares += cifra1;
                if (cifra2 % 2 != 0) impares += cifra2;
                if (cifra3 % 2 != 0) impares += cifra3;
                if (cifra4 % 2 != 0) impares += cifra4;

                if (pares == impares)
                {
                    txtres.AppendText(i + "\n");
                    contador += 1;
                }
            }
            txtcumple.Text = contador.ToString();
        }
    }
}
