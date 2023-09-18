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
    public partial class _26 : Form
    {
        public _26()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = Double.Parse(txtmonto.Text);
            double prestamo = 0.0;

            if (monto > 5000) prestamo = 0.3;
            else prestamo = 0.2;

            double pago_propio = monto * (1 - prestamo);
            double pago_banco = (monto * prestamo) * 1.1;

            txtres.Text = "";
            txtres.AppendText("Pago de la empresa: S/ " + pago_propio.ToString("##.00") + "\n");
            txtres.AppendText("Prestamo: S/ " + pago_banco.ToString("##.00") + "\n");
        }
    }
}
