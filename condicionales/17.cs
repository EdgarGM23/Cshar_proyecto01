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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double precio = Double.Parse(txtprecio.Text);
            double docenas = Double.Parse(txtdocenas.Text);
            int lapiceros = 0;
            double descuento = 0.0;

            if (docenas >= 6) descuento = 0.15;
            else descuento = 0.1;

            if (docenas >= 30) lapiceros = (int)(docenas / 3);
            else lapiceros = 0;

            double total = (docenas * precio) * (1 - descuento);

            txtres.Text = "";
            txtres.AppendText("Monto: " + (docenas * precio).ToString("##.00") + " S/\n");
            txtres.AppendText("Descuento: " + (int)(descuento * 100) + " %\n");
            txtres.AppendText("Total: " + total.ToString("##.00") + " S/\n");
            txtres.AppendText("Lapiceros: " + lapiceros + "\n");
        }
    }
}
