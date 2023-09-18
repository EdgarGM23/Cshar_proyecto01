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
    public partial class _15 : Form
    {
        public _15()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = Double.Parse(txtimporte.Text);
            double descuento = 0.0;
            double comision = 0.0;

            if (monto <= 5000) comision = 0.05;
            else if (monto > 5000 && monto <= 10000) comision = 0.08;
            else if (monto > 10000 && monto <= 20000) comision = 0.1;
            else comision = 0.15;

            double sueldo_bruto = 250 + (monto * comision);

            if (sueldo_bruto > 3500) descuento = 0.15;
            else descuento = 0.08;

            double sueldo_neto = sueldo_bruto * (1 - descuento);

            txtresultado.Text = "";
            txtresultado.AppendText("Sueldo bruto: " + sueldo_bruto.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Sueldo neto: " + sueldo_neto.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Descuento: " + (sueldo_bruto - sueldo_neto).ToString("##.00") + " S/\n");
            txtresultado.AppendText("Comision: " + comision * 100 + " %\n");
        }
    }
}
