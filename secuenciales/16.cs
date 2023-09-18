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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txthoras.Text);
            double tarifa = int.Parse(txttarifa.Text);

            double sbasico = horas * tarifa;
            double sbruto = sbasico * (1 + 0.2);
            double sneto = sbruto * (1 - 0.1);

            txtresultado.Text = "";
            txtresultado.AppendText("Sueldo basico: S/" + sbasico + "\n");
            txtresultado.AppendText("Sueldo bruto: S/" + sbruto + "\n");
            txtresultado.AppendText("Sueldo neto: S/" + sneto.ToString("##.00") + "\n");
        }
    }
}
