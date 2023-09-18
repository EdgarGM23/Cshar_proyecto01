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
    public partial class _25 : Form
    {
        public _25()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int sueldo = int.Parse(txtsueldo.Text);
            int hijos = int.Parse(txthijos.Text);

            int bono = 1;
            double bonificacion = 0.0;
            int contador = 0;
            int extra = 0;

            txtres.Text = "";
            if (hijos > 1)
            {
                bonificacion = sueldo * 0.125;
                contador = hijos;
                while (contador > 0)
                {
                    contador -= 1;
                    bono += 1;
                }
                extra = 40 * (bono - 1);
            }
            else
            {
                bonificacion = sueldo * 0.1;
                extra = 40;
            }

            double sueldo_neto = sueldo + bonificacion + extra;
            
            txtres.AppendText("Bonificacion:  S/ " + bonificacion.ToString("##.00") + "\n");
            txtres.AppendText("Sueldo total:  S/ " + sueldo_neto.ToString("##.00") + "\n");
        }
    }
}
