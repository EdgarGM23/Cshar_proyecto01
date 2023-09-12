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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int pies = int.Parse(txtpies.Text);
            int pulgadas = int.Parse(txtpulgadas.Text);
            double converpies = pies * 3.281;
            double converpulgadas = pulgadas / 39.37;

            double metros = converpies + converpulgadas;

            txtmetros.Text = metros.ToString("##.00");
        }
    }
}
