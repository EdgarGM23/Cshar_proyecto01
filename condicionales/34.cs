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
    public partial class _34 : Form
    {
        public _34()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso = Double.Parse(txtpeso.Text);
            double estatura = Double.Parse(txtestatura.Text);
            String grado_obesidad = "";
            double imc = peso / (estatura * estatura);

            if (imc < 20) grado_obesidad = "Delgado";
            else if (imc >= 20 && imc < 25) grado_obesidad = "Normal";
            else if (imc >= 25 && imc <= 27) grado_obesidad = "Sobrepeso";
            else if (imc > 27) grado_obesidad = "Obesidad";

            txtres.Text = "";
            txtres.AppendText("IMC: " + imc.ToString("##.00") + "\n");
            txtres.AppendText("Grado de obesidad: " + grado_obesidad);
        }
    }
}
