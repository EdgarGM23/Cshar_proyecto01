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
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtareabase_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            String c1 = Convert.ToString(numero / 1000);
            String c2 = Convert.ToString((numero / 100) % 10);
            String c3 = Convert.ToString((numero / 10) % 10);
            String c4 = Convert.ToString(numero % 10);

            String suma = c4 + c3 + c2 + c1;
            txtreverso.Text = suma;
        }
    }
}
