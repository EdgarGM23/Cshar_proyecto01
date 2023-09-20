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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int multiplos = int.Parse(txtmultiplos.Text);
            int numero = int.Parse(txtnum.Text);
            int resultado = 0;
            String fila = "";

            for (int i = 1; i <= multiplos; i++)
            {
                resultado = numero * i;
                fila += (resultado).ToString() + (i < multiplos ? ", " : "");
            }

            txtres.Text = "";
            txtres.AppendText("Los multiplos de " + numero + " son:\n" + fila);
        }
    }
}
