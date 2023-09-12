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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void lblvarones_Click(object sender, EventArgs e)
        {

        }

        private void txtVarones_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMujeres_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(txtmetros.Text);
            double centimetros = metros * 100.0;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12.0;
            double yardas = pies / 3.0;

            txtcentimetros.Text = centimetros.ToString("##.00");
            txtpulgadas.Text = pulgadas.ToString("##.00");
            txtpies.Text = pies.ToString("##.00");
            txtyardas.Text = yardas.ToString("##.00");
        }
    }
}
