using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.condicionales
{
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = new Random().Next(0, 300);
            double importe = Double.Parse(txtimporte.Text);
            double descuento = 0.0;

            if (numero >= 100) descuento = 0.15;
            else descuento = 0.05;

            double total = importe * (1 - descuento);
            double dst = importe - total;

            txtdesc.Text = dst.ToString("##.00") + "S/";
            txttotal.Text = total.ToString("##.00") + "S/";
            txtnumero.Text = numero.ToString();
        }
    }
}
