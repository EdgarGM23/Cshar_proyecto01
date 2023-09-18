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
    public partial class _22 : Form
    {
        public _22()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int A = int.Parse(txta.Text);
            int B = int.Parse(txtb.Text);
            double descuento_A = 0.0;
            double descuento_B = 0.0;
            int descuento = 0;

            txtres.Text = "";
            if (A > 50) descuento_A = 0.15;
            else descuento = 0;
            if (B > 60) descuento_B = 0.1;
            else descuento = 0;

            int costo_A = A * 25;
            int costo_B = B * 30;

            double total_A = costo_A * (1 - descuento_A);
            double total_B = costo_B * (1 - descuento_B);

            double total_final = total_A + total_B;
            double dst_A = costo_A - total_A;
            double dst_B = costo_B - total_B;
            double dst_final = dst_A + dst_B;

            txtres.AppendText("Importe bruto A: S/ " + costo_A + "\n");
            txtres.AppendText("Importe bruto B: S/ " + costo_B + "\n");
            txtres.AppendText("Descuento A: S/ " + dst_A + "\n");
            txtres.AppendText("Descuento B: S/ " + dst_B + "\n");
            txtres.AppendText("Descuento final: S/ " + dst_final + "\n");
            txtres.AppendText("Total final a pagar: S/ " + total_final + "\n");
        }
    }
}
