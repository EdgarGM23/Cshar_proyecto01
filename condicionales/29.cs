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
    public partial class _29 : Form
    {
        public _29()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txthoras.Text);
            double tarifa = Double.Parse(txttarifa.Text);

            double sueldo_bruto = 0;
            double sueldo_neto = 0;
            double descuento = 0;
            double pago_horas = 0;
            double dst = 0;

            if (horas > 48) sueldo_bruto = (horas * tarifa) * 1.2;
            else sueldo_bruto = horas * tarifa;

            if (sueldo_bruto > 1500) descuento = 0.11;
            else descuento = 0;

            sueldo_neto = sueldo_bruto * (1 - descuento);
            dst = sueldo_bruto - sueldo_neto;
            pago_horas = sueldo_neto / horas;

            txtres.Text = "";

            txtres.AppendText("Las horas trabajadas " + horas + "\n");
            txtres.AppendText("El pago por hora es: S/ " + pago_horas.ToString("##.00") + "\n");
            txtres.AppendText("El sueldo bruto es:     S/ " + sueldo_bruto.ToString("##.00") + "\n");
            txtres.AppendText("El descuento es de:     S/ " + dst.ToString("##.00") + "\n");
            txtres.AppendText("El total a pagar es:    S/ " + sueldo_neto.ToString("##.00") + "\n");
        }
    }
}
