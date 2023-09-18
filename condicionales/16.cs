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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ingreso = Double.Parse(txtimporte.Text);
            double casa = Double.Parse(txtcasa.Text);
            double cuotas_mensuales = 0.0;
            double cuota_inicial = 0.0;

            if (ingreso < 1250)
            {
                cuota_inicial = casa * 0.15;
                cuotas_mensuales = (casa - cuota_inicial) / 120;
            }
            else
            {
                cuota_inicial = casa * 0.3;
                cuotas_mensuales = (casa - cuota_inicial) / 75;
            }

            txtres.Text = "";
            txtres.AppendText("Cuota inicial: " + cuota_inicial.ToString("##.00") + " S/\n");
            txtres.AppendText("Cuota Mensual: " + cuotas_mensuales.ToString("##.00") + " S/\n");
        }
    }
}
