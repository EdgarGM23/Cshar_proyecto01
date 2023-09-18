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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidad = int.Parse(txtcantidad.Text);
            double codigo = int.Parse(txtcodigo.Text);

            double precio = 0; double desc = 0.00;

            if (codigo == 101) precio = 17;
            else if (codigo == 102) precio = 25;
            else if (codigo == 103) precio = 16;
            else if (codigo == 104) precio = 27;

            if (cantidad >= 1 && cantidad <= 10) desc = 0.05;
            else if (cantidad >= 11 && cantidad <= 20) desc = 0.8;
            else if (cantidad >= 21 && cantidad <= 30) desc = 0.1;
            else if (cantidad > 31) desc = 0.13;

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
        }
    }
}
