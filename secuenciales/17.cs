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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = Double.Parse(txtmonto.Text);

            double centroSalud = monto * 0.35;
            double comedorInfantil = monto * 0.25;
            double asilo = monto - (centroSalud + comedorInfantil);

            txtresultado.Text = "";
            txtresultado.AppendText("Centro de salud: " + centroSalud.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Comedor fnfantil: " + comedorInfantil.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Asilo: " + asilo.ToString("##.00") + " S/\n");
        }
    }
}
