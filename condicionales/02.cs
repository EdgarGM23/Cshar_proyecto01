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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidad = Double.Parse(txtcantidad.Text);

            double precio = 20; double desc = 0.00; int caramelos = 0;

            if (cantidad >= 1 && cantidad <= 50) caramelos = 5;
            else if (cantidad >= 51 && cantidad <= 100) caramelos = 10;
            else if (cantidad > 100)
            {
                caramelos = 15;
            }

            double importe = cantidad * precio;

            if (importe > 700) desc = 0.16;
            else if (importe <= 700 && importe >= 501) desc = 0.14;
            else desc = 0.12;

            double total = importe * (1 - desc);
            double descuento = importe - total;

            txtresultado.Text = "";
            txtresultado.AppendText("Importe de compra: " + importe.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Total: " + total.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Descuento: " + descuento.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Caramelos: " + caramelos);
        }
    }
}
