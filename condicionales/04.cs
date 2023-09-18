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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void lblcantidad_Click(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double practica1 = Double.Parse(txtpractica1.Text);
            double practica2 = Double.Parse(txtpractica2.Text);
            double practica3 = Double.Parse(txtpractica3.Text);

            if (practica3 >= 10) practica3 += 2;

            double promedio = (practica1 + practica2 + practica3) / 3;

            txtresultado.Text = "";
            txtresultado.AppendText("Promedio: " + promedio.ToString("##.00") + "\n");
            txtresultado.AppendText("Nota 1: " + practica1.ToString("##.00") + "\n");
            txtresultado.AppendText("Nota 2: " + practica2.ToString("##.00") + "\n");
            txtresultado.AppendText("Nota 3: " + practica3.ToString("##.00") + "\n");
        }
    }
}
