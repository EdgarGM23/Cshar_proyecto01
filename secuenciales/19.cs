using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.secuenciales
{
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double monto = int.Parse(txtmonto.Text);

            double sbruto = 500 + monto * 0.09;
            double sneto = sbruto * (1 - 0.11);
            double comision = monto * 0.09;

            txtresultado.Text = "";
            txtresultado.AppendText("Sueldo bruto: " + sbruto.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Comision: " + comision.ToString("##.00") + " S/\n");
            txtresultado.AppendText("Descuento: " + sneto.ToString("##.00") + " S/\n");
        }
    }
}
