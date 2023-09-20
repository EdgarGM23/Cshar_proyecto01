using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto01.repetitivos
{
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            int de = int.Parse(txtde.Text);
            int a = int.Parse(txta.Text);
            int resultado = 0;

            txtres.Text = "";

            for (int i = de; i <= a + 1; i++)
            {
                resultado = numero * i;
                txtres.AppendText(numero + " * " + i + " = " + resultado + "\n");
            }
        }
    }
}
