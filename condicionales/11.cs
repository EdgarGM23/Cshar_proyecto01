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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            if (numero < 0) txtrpta.Text = "Negativo";
            else if (numero == 0) txtrpta.Text = "Cero";
            else
            {
                txtrpta.Text = "Positivo";
            }
        }

        private void lblnota1_Click(object sender, EventArgs e)
        {

        }

        private void txtnota1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
