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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnum.Text);
            int resultado = 0;

            String fila = "";
            txtres.Text = "";

            for (int i = 1; i <= 12; i++)
            {
                resultado = numero * i;
                txtres.AppendText(numero + " * " + i + " = " + resultado + "\n");
            }
        }
    }
}
