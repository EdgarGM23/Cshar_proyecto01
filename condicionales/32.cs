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
    public partial class _32 : Form
    {
        public _32()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int promedio = int.Parse(txtprom.Text);
            String categoria = txtcat.Text;

            double descuento = 0;
            double pension = 0;

            txtres.Text = "";

            if (promedio >= 14 && promedio < 16) descuento = 0.1;
            else if (promedio >= 16 && promedio < 18) descuento = 0.12;
            else if (promedio >= 18 && promedio <= 20) descuento = 0.15;
            else txtres.AppendText("El promedio no es valido");

            if (categoria.Equals("A")) pension = 550;
            else if (categoria.Equals("B")) pension = 500;
            else if (categoria.Equals("C")) pension = 450;
            else if (categoria.Equals("D")) pension = 400;
            else txtres.AppendText("La categoria no es valida");

            double total = pension - (pension * descuento);

            txtres.AppendText("La pension es: S/" + pension + "\n");
            txtres.AppendText("El descuento es: " + descuento * 100 + "% \n");
            txtres.AppendText("La nueva pension es: S/" + total);
        }
    }
}
