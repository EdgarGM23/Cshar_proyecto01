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
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);
            int j = 0;

            txtres.Text = "";
            if (numero >= 4)
            {
                while (j < numero)
                {
                    String fila = "";
                    for (int i = 1; i <= numero * 2; i++)
                    {
                        fila += "*";
                    }
                    txtres.AppendText(fila + "\n");
                    j += 1;
                }
            }
            else txtres.AppendText("El numero tiene que ser mayor a 4");
        }
    }
}
