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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnum.Text);
            int contador = 0;

            String fila = "";

            for (int i = 1; i <= numero + 1; i++)
            {
                if (numero % i == 0)
                {
                    fila += (i).ToString() + (i < numero ? ", " : "");
                    contador += 1;
                }
            }

            txtres.Text = "";
            txtres.AppendText("Divisores: " + fila + "\n");
            txtres.AppendText("Cantidad de divisores: " + contador + "\n");
        }
    }
}
