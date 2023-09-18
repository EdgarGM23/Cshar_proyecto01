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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            int c1 = (numero / 100);
            int c2 = ((numero / 10) % 10);
            int c3 = (numero % 10);

            if (c1 > c2 && c2 > c3)
            {
                txtresultado.Text = "Consecutiva";
                txtresultado2.Text = "Descendente";
            }
            else if (c1 < c2 && c2 < c3)
            {
                txtresultado.Text = "Consecutiva";
                txtresultado2.Text = "Ascendente";
            }
            else
            {
                txtresultado.Text = "No consecutiva";
                txtresultado2.Text = "";
            }
        }
    }
}
