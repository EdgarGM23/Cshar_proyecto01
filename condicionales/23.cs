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
    public partial class _23 : Form
    {
        public _23()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int matematica = int.Parse(txtmat.Text);
            int fisica = int.Parse(txtfis.Text);
            double descuento_A = 0.0;
            double descuento_B = 0.0;
            double mat_propina = 0;
            double fis_propina = 0;

            txtres.Text = "";
            if (matematica > 17) mat_propina = matematica + 3;
            else mat_propina = matematica;

            if (fisica > 15) fis_propina = (fisica * 0.5) + 2;
            else fis_propina = fisica * 0.5;

            double promedio = (matematica + fisica) / 2;

            txtres.AppendText("Propina de matematica es: S/ " + mat_propina + "\n");
            txtres.AppendText("Propina de fisica es: S/ " + fis_propina + "\n");
            txtres.AppendText("Propina total : S/ " + (mat_propina + fis_propina).ToString("##.00") + "\n");

            if (promedio > 16) txtres.AppendText("Obtiene un reloj con promedio de " + promedio + "\n");
            else txtres.AppendText("No obtiene un rejol con promedio\n de: " + promedio + "\n");
        }
    }
}
