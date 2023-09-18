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
    public partial class _27 : Form
    {
        public _27()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = Double.Parse(txtmonto.Text);
            double descuento = 0.0;
            int polos = 0;
            double sueldo_bruto = 600 + (monto * 0.15);

            if (sueldo_bruto > 1800) descuento = 0.1;
            else descuento = 0.05;
            if (monto > 1000) polos = 3;
            else polos = 1;

            double sueldo_neto = sueldo_bruto * (1 - descuento);
            double dst = sueldo_bruto - sueldo_neto;

            txtres.Text = "";
            txtres.AppendText("Sueldo bruto: S/ " + sueldo_bruto.ToString("##.00") + "\n");
            txtres.AppendText("Descuento: S/ " + dst.ToString("##.00") + "\n");
            txtres.AppendText("Sueldo neto: S/ " + sueldo_neto.ToString("##.00") + "\n");
            txtres.AppendText("Polos: " + polos + "\n");
        }
    }
}
