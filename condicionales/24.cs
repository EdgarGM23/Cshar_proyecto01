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
    public partial class _24 : Form
    {
        public _24()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int monto = int.Parse(txtmonto.Text);
            int contador = 0;
            double sueldo = 0.0;

            if (monto > 5000)
            {
                int extra = monto - 5000;
                while (extra >= 500)
                {
                    extra -= 500;
                    contador += 1;
                    sueldo = (monto * 0.1) + (25 * contador);
                }
            }
            else sueldo = monto * 0.1;

            txtres.Text = "Sueldo: " + sueldo.ToString("##.00");
        }
    }
}
