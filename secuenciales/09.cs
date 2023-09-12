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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            int c1 = numero / 1000;
            int c2 = (numero / 100) % 10;
            int c3 = (numero / 10) % 10;
            int c4 = numero % 10;

            int suma = c1 + c2 + c3 + c4;
            txtsuma.Text = Convert.ToString(suma);
        }
    }
}
