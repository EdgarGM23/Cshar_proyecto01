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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double angulo = Double.Parse(txtangulo.Text);

            String tipo = "nada"; double desc = 0.05;

            if (angulo == 0) tipo = "Nulo";
            else if (angulo > 0 && angulo < 90) tipo = "Agudo";
            else if (angulo == 90) tipo = "Recto";
            else if (angulo > 90 && angulo < 180) tipo = "Obtuso";
            else if (angulo == 180) tipo = "Llano";
            else if (angulo > 180 && angulo < 360) tipo = "Concavo";
            else if (angulo == 360) tipo = "Completo";
            else tipo = "No existe";

            txtresultado.Text = "";
            txtresultado.AppendText("El tipo es: " + (tipo));
        }
    }
}
