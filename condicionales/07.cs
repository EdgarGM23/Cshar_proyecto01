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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtnumero1.Text);
            int numero2 = int.Parse(txtnumero2.Text);
            int numero3 = int.Parse(txtnumero3.Text);

            int[] lista = { numero1, numero2, numero3 };
            Array.Sort(lista);

            txtresultado.Text = "";
            txtresultado.AppendText("Intermedio: " + (lista[1]) + "\n");
        }
    }
}
