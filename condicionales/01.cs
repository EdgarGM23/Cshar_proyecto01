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
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidad = Double.Parse(txtcantidad.Text);

            double precio = 0; double desc = 0.05;

            if (cantidad >= 1 && cantidad <= 25) precio = 27;
            else if (cantidad >= 26 && cantidad <= 50) precio = 25;
            else if (cantidad > 50)
            {
                precio = 23;
                desc = 0.15;
            }

            double importe = cantidad * precio;
            double total = importe * (1 - desc);
            double descuento = importe - total;

            txtresultado.Text = "";
            txtresultado.AppendText("Importe de compra: " + importe.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Total: " + total.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Descuento: " + descuento.ToString("##.00") + " S/\n");
        }
    }
}
