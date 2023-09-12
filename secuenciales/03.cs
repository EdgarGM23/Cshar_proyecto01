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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int kilometros = int.Parse(txtkilometros.Text);
            int pies = int.Parse(txtpies.Text);
            int millas = int.Parse(txtmillas.Text);
            double converkilometros = kilometros / 1000;
            double converPies = pies / 3.2808;
            double convermillas = millas * 1609;

            double metros = converkilometros + converPies + convermillas;
            double yardas = metros * 1.094;


            txtmetrosTotales.Text = metros.ToString("##.00");
            txtyardasTotales.Text = yardas.ToString("##.00");
        }
    }
}
