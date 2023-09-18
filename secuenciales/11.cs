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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtnumero1.Text);
            int numero2 = int.Parse(txtnumero2.Text);
            String Ac1 = Convert.ToString((numero1 / 100) % 10);
            String Ac2 = Convert.ToString((numero1 / 10) % 10);
            String Ac3 = Convert.ToString(numero1 % 10);

            String Bc1 = Convert.ToString((numero2 / 100) % 10);
            String Bc2 = Convert.ToString((numero2 / 10) % 10);
            String Bc3 = Convert.ToString(numero2 % 10);

            String primero = Bc3 + Ac2 + Bc1;
            String segundo = Ac3 + Bc2 + Ac1;

            txtprimero.Text = (primero);
            txtsegundo.Text = (segundo);
        }
    }
}
