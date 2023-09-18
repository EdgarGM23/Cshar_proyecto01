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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidad = Double.Parse(txtcantidad.Text);
            double precio = Double.Parse(txtprecio.Text);

            double pridesc = precio * 0.15;
            double segdesc = (precio - pridesc) * 0.15;
            double importecom = precio * cantidad;
            double importefinal = (precio - (pridesc + segdesc)) * cantidad;
            double descuento = importecom - importefinal;

            txtresultado.Text = "";
            txtresultado.AppendText("Importe de compra: " + importecom.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Importe a pagar: " + importefinal.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Descuento: " + descuento.ToString("##.00") + " S/\n");
        }
    }
}
