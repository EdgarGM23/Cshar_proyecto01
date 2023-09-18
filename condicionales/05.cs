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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpractica2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            String c1 = Convert.ToString(numero / 1000);
            String c2 = Convert.ToString((numero / 100) % 10);
            String c3 = Convert.ToString((numero / 10) % 10);
            String c4 = Convert.ToString(numero % 10);

            String[] lista = { c1, c2, c3, c4 };
            Array.Sort(lista);

            String resultado = lista[3] + lista[0];
            txtresultado.Text = resultado;
        }
    }
}
