using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.secuenciales
{
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtnumero1.Text);
            int numero2 = int.Parse(txtnumero2.Text);
            int numero3 = int.Parse(txtnumero3.Text);
            int numero4 = int.Parse(txtnumero4.Text);
            int numero5 = int.Parse(txtnumero5.Text);

            int[] numeros = { numero1, numero2, numero3, numero4, numero5 };

            Array.Sort(numeros);

            int primero = numeros[4];
            int segundo = numeros[3];
            int tercero = numeros[2];

            double promedio = (primero + segundo + tercero) / 3;

            txtres1.Text = promedio.ToString("##.00");
        }
    }
}
