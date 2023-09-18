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
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double donacion = Double.Parse(txtdonacion.Text);
            double centroS = 0.0;
            double centroN = 0.0;
            double bolsa = 0.0;
            if (donacion >= 10000)
            {
                centroS = donacion * 0.3;
                centroN = donacion * 0.5;
                bolsa = donacion - (centroN + centroS);
            }
            else
            {
                centroS = donacion * 0.25;
                centroN = donacion * 0.6;
                bolsa = donacion - (centroN + centroS);
            }

            txtres.Text = "";
            txtres.AppendText("Centro de Salud: " + centroS.ToString("##.00") + " S/\n");
            txtres.AppendText("Comedor de niños: " + centroN.ToString("##.00") + " S/\n");
            txtres.AppendText("Bolsa: " + bolsa.ToString("##.00") + " S/\n");
        }
    }
}
