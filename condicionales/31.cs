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
    public partial class _31 : Form
    {
        public _31()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txthoras.Text);
            String sCategoria = txtcategoria.Text;

            double tarifa = 0;
            if (sCategoria.Equals("A")) tarifa = 21;
            else if (sCategoria.Equals("B")) tarifa = 19.50;
            else if (sCategoria.Equals("C")) tarifa = 17;
            else tarifa = 15.50;

            double sbruto = horas * tarifa;
            double descuento = (sbruto > 2500 ? 0.20 : 0.15) * sbruto;

            txtres.Text = "";
            txtres.AppendText("Horas: " + horas + "\n");
            txtres.AppendText("Categoria: " + sCategoria + "\n");
            txtres.AppendText("Sueldo bruto: " + sbruto.ToString("##.00") + "\n");
            txtres.AppendText("Descuento: " + descuento.ToString("##.00") + "\n");
            txtres.AppendText("Sueldo Neto: " + (sbruto - descuento).ToString("##.00"));
        }
    }
}
