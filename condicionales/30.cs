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
    public partial class _30 : Form
    {
        public _30()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int cuota = int.Parse(txtcuota.Text);
            int dia = int.Parse(txtdia.Text);

            double descuento = 0.0, total = 0.0, aumento = 0;

            if (dia <= 10)
            {
                if (5 < (cuota * 0.02))
                {
                    descuento = 0.02;
                    total = cuota - (cuota * descuento);
                }
                else total = cuota - 5;
            }
            else if (dia <= 20 && dia > 10)
            {
                descuento = 0;
                total = cuota - (cuota * descuento);
            }
            else
            {
                if (10 < (cuota * 0.03))
                {
                    aumento = 0.03;
                    total = cuota + (cuota * aumento);
                }
                else
                {
                    aumento = 10;
                    total = cuota + aumento;
                }
            }
            
            txtres.Text = "Pago: " + total.ToString("##.00");
        }
    }
}
