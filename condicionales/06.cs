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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int edad1 = int.Parse(txtedad1.Text);
            int edad2 = int.Parse(txtedad2.Text);
            int edad3 = int.Parse(txtedad3.Text);

            int[] lista = { edad1, edad2, edad3 };
            Array.Sort(lista);

            txtresultado.Text = "";
            txtresultado.AppendText("Menor: " + lista[0] + "\n");
            txtresultado.AppendText("Mayor: " + lista[2] + "\n");
        }
    }
}
